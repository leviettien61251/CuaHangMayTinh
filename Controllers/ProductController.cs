using CuaHangMayTinh.Models;
using DocumentFormat.OpenXml.Math;
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
            return DataProvider.Instance.ExecuteScalar(script, new object[] { minStock, maxStock });
        }

        public void LoadProduct(DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_GetSanPham";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }

        public void LoadProductOnlyStock(DataGridView dataGridViewName, int minStock, int maxStock)
        {
            try
            {
                string script = @"EXEC usp_GetSanPhamByOnlyStock @MinStock , @MaxStock ";
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { minStock, maxStock });
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public void LoadProductByIDCategory(DataGridView dataGridViewName, int maDanhMuc)
        {
            string script = @"EXEC usp_GetSanPhamByStock @MaDanhMuc ";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { maDanhMuc });
        }

        public void LoadProductByIDCategoryAndStock(DataGridView dataGridViewName, int maDanhMuc, int minStock, int maxStock)
        {
            try
            {
                string script = @"EXEC usp_GetSanPhamByStock @MaDanhMuc , @MinStock , @MaxStock ";
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { maDanhMuc, minStock, maxStock });
            }
            catch (SqlException ex)
            {

                throw ex;
            }

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

        #region INVENTORY MANAGEMENT

        //public int GetTotalProduct()
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_CountSanPham";
        //        return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm tổng sản phẩm: " + ex.Message);
        //        return 0;
        //    }
        //}

        //public int GetOutOfStockProduct()
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_CountSanPhamHetHang";
        //        return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm sản phẩm hết hàng: " + ex.Message);
        //        return 0;
        //    }
        //}

        //public int GetLowStockProduct(int threshold = 5)
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_CountSanPhamSapHetHang @SoLuongTon";
        //        return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script, new object[] { threshold }));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi đếm sản phẩm sắp hết hàng: " + ex.Message);
        //        return 0;
        //    }
        //}

        //public bool UpdateProductStock(int productId, int quantity)
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_UpdateProductStock @MaSP, @SoLuongTon";
        //        int result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { productId, quantity });
        //        return result > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi cập nhật tồn kho sản phẩm ID {productId}: " + ex.Message);
        //        return false;
        //    }
        //}

        #endregion

        #region SEARCH AND FILTER

        //public List<Product> GetProductsByCategory(int categoryId)
        //{
        //    List<Product> list = new List<Product>();

        //    try
        //    {
        //        string script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc";
        //        DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId });

        //        foreach (DataRow item in dt.Rows)
        //        {
        //            Product product = new Product(item);
        //            list.Add(product);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi lấy sản phẩm theo danh mục {categoryId}: " + ex.Message);
        //    }

        //    return list;
        //}

        //public List<Product> GetProductsByStockRange(int minStock, int maxStock)
        //{
        //    List<Product> list = new List<Product>();

        //    try
        //    {
        //        string script = @"EXEC usp_GetSanPhamByStockRange @MinStock, @MaxStock";
        //        DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { minStock, maxStock });

        //        foreach (DataRow item in dt.Rows)
        //        {
        //            Product product = new Product(item);
        //            list.Add(product);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi lấy sản phẩm theo khoảng tồn kho: " + ex.Message);
        //    }

        //    return list;
        //}

        //public List<Product> SearchProducts(string keyword)
        //{
        //    List<Product> list = new List<Product>();

        //    try
        //    {
        //        string script = @"EXEC usp_SearchProduct @Keyword";
        //        DataTable dt = DataProvider.Instance.ExecuteQuery(script, new object[] { "%" + keyword + "%" });

        //        foreach (DataRow item in dt.Rows)
        //        {
        //            Product product = new Product(item);
        //            list.Add(product);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
        //    }

        //    return list;
        //}

        #endregion

        #region DATA BINDING

        //public void LoadProduct(DataGridView dataGridViewName)
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_GetSanPham";
        //        dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm: " + ex.Message);
        //    }
        //}

        //public void LoadProductByIDCategory(DataGridView dataGridViewName, int categoryId)
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_GetSanPhamByMaDanhMuc @MaDanhMuc";
        //        dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId });
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm theo danh mục: " + ex.Message);
        //    }
        //}

        //public void LoadProductOnlyStock(DataGridView dataGridViewName, int minStock, int maxStock)
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_GetSanPhamByStockRange @MinStock, @MaxStock";
        //        dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { minStock, maxStock });
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm theo khoảng tồn: " + ex.Message);
        //    }
        //}

        //public void LoadProductByIDCategoryAndStock(DataGridView dataGridViewName, int categoryId, int minStock, int maxStock)
        //{
        //    try
        //    {
        //        string script = @"EXEC usp_GetSanPhamByCategoryAndStock @MaDanhMuc, @MinStock, @MaxStock";
        //        dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { categoryId, minStock, maxStock });
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải dữ liệu sản phẩm theo danh mục và khoảng tồn: " + ex.Message);
        //    }
        //}

        #endregion

        #region COMBOBOX METHODS

        public void FillProductComboBox(string script, ComboBox DropDownName)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = DataProvider.Instance.ExecuteQuery(script);
                DropDownName.DataSource = dt;
                DropDownName.ValueMember = dt.Columns[0].ColumnName;
                DropDownName.DisplayMember = dt.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổ dữ liệu vào combobox: " + ex.Message);
            }
        }


        public bool HasProducts()
        {
            try
            {
                string script = @"SELECT COUNT(*) FROM SanPham WHERE TrangThai = 1";
                int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(script));
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra sản phẩm: " + ex.Message);
                return false;
            }
        }
        #endregion
    }
}

