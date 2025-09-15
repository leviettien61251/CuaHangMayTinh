using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CuaHangMayTinh.Views.Report
{
    public partial class frmBestSellersReport : Form
    {
        public frmBestSellersReport()
        {
            InitializeComponent();
        }

        private void frmBestSellersReport_Load(object sender, EventArgs e)
        {
            cbReportType.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            // Gán sự kiện
            btnViewReport.Click += btnViewReport_Click;
            btnExport.Click += btnExport_Click;
        }



        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new ReportModel
                {
                    ReportType = 2, // Best Sellers
                    FromDate = dtpFromDate.Value,
                    ToDate = dtpToDate.Value,
                    TopCount = (int)Convert.ToDouble(nudTopCount.Value),
                    SortBy = cbReportType.SelectedIndex == 0 ? "Quantity" : "Revenue"
                };

                var result = ReportController.Instance.GenerateReport(request);
                BindBestSellersData(result);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindBestSellersData(ReportModel report)
        {
            var data = report.ReportData as List<BestSellerReportItem>;

            // Tạo DataTable để hiển thị
            var dt = new DataTable();
            dt.Columns.Add("Mã SP", typeof(int));
            dt.Columns.Add("Tên SP", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Số lượng bán", typeof(int));
            dt.Columns.Add("Doanh thu", typeof(string));
            dt.Columns.Add("Đơn giá TB", typeof(string));
            dt.Columns.Add("Số đơn hàng", typeof(int));

            if (data == null || data.Count == 0)
            {
                // Thêm dòng thông báo không có dữ liệu
                dt.Rows.Add(0, "Chưa có dữ liệu", "", 0, "0 đ", "0 đ", 0);
            }
            else
            {
                foreach (var item in data)
                {
                    dt.Rows.Add(
                        item.MaSP,
                        item.TenSP,
                        item.TenDanhMuc,
                        item.TongSoLuongBan,
                        item.TongDoanhThu.ToString("N0") + " đ",
                        item.DonGiaTrungBinh.ToString("N0") + " đ",
                        item.SoDonHang
                    );
                    if (cbReportType.SelectedIndex == 0)
                    {
                        this.chartBestSeller.Series["Giá thành"].Enabled = false;
                        this.chartBestSeller.Series["Số lượng"].Enabled = true;
                        this.chartBestSeller.Series["Số lượng"].Points.AddXY(item.TenSP, item.TongSoLuongBan);
                    }
                    else
                    {
                        this.chartBestSeller.Series["Giá thành"].Enabled = true;
                        this.chartBestSeller.Series["Số lượng"].Enabled = false;
                        this.chartBestSeller.Series["Giá thành"].Points.AddY(item.TongDoanhThu);
                    }
                }
            }

            dgvBestSellers.DataSource = dt;
            chartBestSeller.DataSource = dt;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelController.Instance.SaveExcel(dgvBestSellers, "Best Seller List", "Best Seller");
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }



        private void cbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
