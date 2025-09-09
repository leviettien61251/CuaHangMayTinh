using CuaHangMayTinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class ProductController
    {

        private static ProductController instance;

        public static ProductController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductController();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ProductController() { }

        

        public List<Product> GetProduct()
        {
            string script = @"EXEC usp_GetSanPham";

            List<Product> list = new List<Product>();

            DataTable dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }

        public List<Product> GetProductByIdCategory(int maDanhMuc)
        {
            string script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc ";

            List<Product> list = new List<Product>();

            DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { maDanhMuc });

            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }


        public object GetTotalProduct()
        {
            string script = @"EXEC usp_CountSanPham";
            return DataProvider.Instance.ExecuteScalar(script);
        }

        public object GetOutOfStockProduct() 
        {
            string script = @"EXEC usp_CountSanPhamHetHang";
            return DataProvider.Instance.ExecuteScalar(script);
        }

        public object GetLowStockProduct()
        {
            string script = @"EXEC usp_CountSanPhamSapHetHang @SoLuongTon = 5";
            return DataProvider.Instance.ExecuteScalar(script);
        }

        public object GetInRangeProduct(int minStock, int maxStock) 
        {
            string script = @"EXEC usp_CountSanPhamByStock @MinStock , @MaxStock ";
            return DataProvider.Instance.ExecuteScalar(script, new object[] {minStock, maxStock});
        }

        public void LoadProduct(DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_GetSanPham";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }


        public void LoadProductByIDCategory(DataGridView dataGridViewName, int maDanhMuc)
        {
            //string script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc ";
            string script = @"EXEC usp_GetSanPhamByStock @MaDanhMuc ";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { maDanhMuc});
        }

        public void LoadCLickedProduct()
        {

        }

        public bool AddProduct(string TenSP, int MaDanhMuc, int MaNCC, string MoTa, int BaoHanh, float GiaNhap, float GiaBan, int SoLuongTon)
        {
            string script = @"EXEC usp_AddSanPhamTest @TenSP , @MaDanhMuc , @MaNCC , @MoTa , @BaoHanh , @GiaNhap , @GiaBan , @SoLuongTon ";

            int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { TenSP, MaDanhMuc, MaNCC, MoTa, BaoHanh, GiaNhap, GiaBan, SoLuongTon });

            return result == 1;
        }

        public bool UpdateProduct(int MaSP, string TenSP, int MaDanhMuc, int MaNCC, string MoTa, int BaoHanh, float GiaNhap, float GiaBan, int SoLuongTon)
        {
            string script = @"EXEC usp_UpdateSanPhamTest @MaSP , @TenSP , @MaDanhMuc , @MaNCC , @MoTa , @BaoHanh , @GiaNhap , @GiaBan , @SoLuongTon ";

            int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { MaSP, TenSP, MaDanhMuc, MaNCC, MoTa, BaoHanh, GiaNhap, GiaBan, SoLuongTon });

            return result == 1;
        }

        public void RemoveProduct(string MaSP)
        {
            string script = @"EXEC usp_DelSanPhamByID @MaSP";

            DataProvider.Instance.ExecuteNonQuery(script, new object[] { MaSP });

        }

        public void SearchProduct(string Search, DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_SearchProductByName_Category_Supplier @Search ";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { Search });
        }


    }
}
