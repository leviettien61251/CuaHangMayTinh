using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class OrderController
    {
        private static OrderController instance;

        public static OrderController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderController();
                }
                return instance;
            }
            private set => instance = value;
        }

        private OrderController() { }

        public void LoadOrder(DataGridView dataGridViewName)
        {

            string script = @"EXEC usp_GetDonHang";
            try
            {
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void LoadOrder_Customer(DataGridView dataGridViewName)
        {

            string script = @"EXEC usp_GetDonHangKhachHang";
            try
            {
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void LoadOrderDetail(DataGridView dataGridViewName, int maDH)
        {
            string script = @"EXEC usp_GetDetailOrder @MaDH";
            try
            {
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[] { maDH });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool AddOrder(int maKH, int maNV, string phuongThucTT, string diaChi)
        {
            int result;
            string script = @"EXEC usp_AddDonHang @MaKH , @MaNV , @PhuongThucTT , @DiaChi ";
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maKH, maNV, phuongThucTT, diaChi });
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return result > 0;
        }

        public bool DeleteOrder(int maDH, int maNV)
        {
            int result;
            string script = @"EXEC usp_DelDonHang @MaDH , @NguoiThucHien , @LyDoXoa ";
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maDH, maNV, "Xoa" });
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return result > 0;
        }

        public bool AddProductToOrderDetail(int maDH, int maSP, int soLuong)
        {
            int result;
            string script = @"EXEC usp_AddChiTietDonHang @MaDH , @MaSP , @SoLuong ";
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maDH, maSP, soLuong });
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return result > 0;
        }

        public bool UpdateProductFromDetailOrder(int maCTDH, int maDH, int maSP, int soLuong)
        {
            int result;
            string script = @"EXEC usp_UpdateChiTietDonHang @MaCTDH , @MaDH , @MaSP , @newSoLuong ";
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maCTDH, maDH, maSP, soLuong });
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return result > 0;
        }

        public bool DelProductFromDetailOrder(int maCTDH, int maDH, int maSP)
        {
            int result;
            string script = @"EXEC usp_DeleteChiTietDonHangByID @MaCTDH , @MaDH , @MaSP ";
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maCTDH, maDH, maSP });
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return result > 0;
        }
    }
}
