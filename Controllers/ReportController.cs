using CuaHangMayTinh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class ReportController
    {
        private static ReportController instance;
        public static ReportController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReportController();
                }
                return instance;
            }
        }

        public ReportModel GenerateReport(ReportModel reportRequest)
        {
            try
            {
                switch (reportRequest.ReportType)
                {
                    case 1:
                        return GenerateInventoryReport(reportRequest);
                    case 2:
                        return GenerateBestSellersReport(reportRequest);
                    case 3:
                        return GenerateRevenueReport(reportRequest);
                    default:
                        throw new ArgumentException("Loại báo cáo không hợp lệ");
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Lỗi khi tạo báo cáo", ex);
            }
        }

        private ReportModel GenerateInventoryReport(ReportModel request)
        {
            string query = @"
                SELECT 
                    sp.MaSP, sp.TenSP, dm.TenDanhMuc, 
                    ISNULL(ncc.TenNCC, 'N/A') as TenNCC,
                    sp.SoLuongTon, sp.GiaBan, sp.GiaNhap,
                    (sp.SoLuongTon * sp.GiaNhap) AS TongGiaTriTonKho,
                    CASE 
                        WHEN sp.SoLuongTon = 0 THEN N'Hết hàng'
                        WHEN sp.SoLuongTon <= 10 THEN N'Sắp hết hàng'
                        ELSE N'Còn hàng'
                    END AS TrangThaiTonKho
                FROM SanPham sp
                INNER JOIN DanhMuc dm ON sp.MaDanhMuc = dm.MaDanhMuc
                LEFT JOIN NhaCungCap ncc ON sp.MaNCC = ncc.MaNCC
                WHERE sp.TrangThai = 1
                AND (@MaDanhMuc = 0 OR sp.MaDanhMuc = @MaDanhMuc)
                AND sp.SoLuongTon BETWEEN @MinStock AND @MaxStock
                ORDER BY sp.SoLuongTon ASC";

            int categoryId = request.CategoryId ?? 0;
            int minStock = request.MinStock ?? 0;
            int maxStock = request.MaxStock ?? int.MaxValue;

            DataTable data = DataProvider.Instance.ExecuteQuery(query,
                new object[] { categoryId, minStock, maxStock });

            var inventoryItems = new List<InventoryReportItem>();
            foreach (DataRow row in data.Rows)
            {
                inventoryItems.Add(new InventoryReportItem
                {
                    MaSP = Convert.ToInt32(row["MaSP"]),
                    TenSP = row["TenSP"].ToString(),
                    TenDanhMuc = row["TenDanhMuc"].ToString(),
                    TenNCC = row["TenNCC"].ToString(),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                    GiaBan = Convert.ToDecimal(row["GiaBan"]),
                    GiaNhap = Convert.ToDecimal(row["GiaNhap"]),
                    TongGiaTriTonKho = Convert.ToDecimal(row["TongGiaTriTonKho"]),
                    TrangThaiTonKho = row["TrangThaiTonKho"].ToString()
                });
            }

            // Cập nhật thông tin tổng quan
            UpdateInventorySummary(request, inventoryItems);

            request.ReportData = inventoryItems;
            return request;
        }

        /// <summary>
        /// Cập nhật thống kê tổng quan cho báo cáo tồn kho
        /// </summary>
        private void UpdateInventorySummary(ReportModel request, List<InventoryReportItem> inventoryItems)
        {
            request.TotalProducts = inventoryItems.Count;

            int outOfStockCount = 0;
            int lowStockCount = 0;
            foreach (var item in inventoryItems)
            {
                if (item.SoLuongTon == 0)
                {
                    outOfStockCount++;
                }
                else if (item.SoLuongTon > 0 && item.SoLuongTon <= 10)
                {
                    lowStockCount++;
                }
            }

            request.OutOfStockCount = outOfStockCount;
            request.LowStockCount = lowStockCount;
            request.TotalInventoryValue = CalculateTotalInventoryValue(inventoryItems);
        }

        private decimal CalculateTotalInventoryValue(List<InventoryReportItem> items)
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.TongGiaTriTonKho;
            }
            return total;
        }

        private ReportModel GenerateBestSellersReport(ReportModel request)
        {
            int orderByClause;
            if (request.SortBy == "Quantity")
            {
                orderByClause = 0;
            }
            else
            {
                orderByClause = 1;
            }

            string query = @"EXEC usp_BestSellers @FromDate , @ToDate , @OrderByClause , @TopCount ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query,
                new object[] { request.FromDate, request.ToDate, orderByClause, request.TopCount });

            var bestSellers = new List<BestSellerReportItem>();
            foreach (DataRow row in data.Rows)
            {
                bestSellers.Add(new BestSellerReportItem
                {
                    MaSP = Convert.ToInt32(row["MaSP"]),
                    TenSP = row["TenSP"].ToString(),
                    TenDanhMuc = row["TenDanhMuc"].ToString(),
                    TongSoLuongBan = Convert.ToInt32(row["TongSoLuongBan"]),
                    TongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]),
                    DonGiaTrungBinh = Convert.ToDecimal(row["DonGiaTrungBinh"]),
                    SoDonHang = Convert.ToInt32(row["SoDonHang"])
                });
            }

            request.ReportData = bestSellers;
            return request;
        }

        private ReportModel GenerateRevenueReport(ReportModel request)
        {
            string query;
            switch (request.GroupBy)
            {
                case "Day":
                    query = GetDailyRevenueQuery();
                    break;
                case "Month":
                    query = GetMonthlyRevenueQuery();
                    break;
                case "Quarter":
                    query = GetQuarterlyRevenueQuery();
                    break;
                case "Year":
                    query = GetYearlyRevenueQuery();
                    break;
                default:
                    query = GetMonthlyRevenueQuery();
                    break;
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query,
                new object[] { request.FromDate, request.ToDate });

            var revenueData = new List<RevenueReportItem>();
            foreach (DataRow row in data.Rows)
            {
                revenueData.Add(new RevenueReportItem
                {
                    Period = row["Period"].ToString(),
                    SoHoaDon = Convert.ToInt32(row["SoHoaDon"]),
                    TongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]),
                    TongThanhToan = Convert.ToDecimal(row["TongThanhToan"]),
                    TrungBinhHoaDon = Convert.ToDecimal(row["TrungBinhHoaDon"]),
                    TongSoLuongBan = Convert.ToInt32(row["TongSoLuongBan"]),
                    SoKhachHang = Convert.ToInt32(row["SoKhachHang"])
                });
            }

            // Cập nhật tổng quan
            UpdateRevenueStatistics(request, revenueData);
            
            request.ReportData = revenueData;
            return request;
        }

        private string GetDailyRevenueQuery()
        {
            return @"EXEC usp_GetDailyRevenue @FromDate , @ToDate ";
        }

        private string GetMonthlyRevenueQuery()
        {
            return @"EXEC usp_GetMonthlyRevenue @FromDate , @ToDate ";
        }

        private string GetQuarterlyRevenueQuery()
        {
            return @"
                EXEC usp_GetQuarterlyRevenue @FromDate , @ToDate ";
        }

        private string GetYearlyRevenueQuery()
        {
            return @"
                EXEC usp_GetYearlyRevenue @FromDate , @ToDate ";
        }

        /// <summary>
        /// Cập nhật thống kê tổng quan cho báo cáo doanh thu
        /// </summary>
        private void UpdateRevenueStatistics(ReportModel request, List<RevenueReportItem> revenueData)
        {
            request.TotalInvoices = 0;
            request.TotalRevenue = 0;
            request.TotalPayment = 0;
            request.TotalProductsSold = 0;
            request.TotalCustomers = 0;

            foreach (var item in revenueData)
            {
                request.TotalInvoices += item.SoHoaDon;
                request.TotalRevenue += item.TongDoanhThu;
                request.TotalPayment += item.TongThanhToan;
                request.TotalProductsSold += item.TongSoLuongBan;
                request.TotalCustomers += item.SoKhachHang;
            }

            if (request.TotalInvoices > 0)
            {
                request.AverageInvoiceValue = request.TotalRevenue / request.TotalInvoices;
            }
            else
            {
                request.AverageInvoiceValue = 0;
            }
        }
    }
}
