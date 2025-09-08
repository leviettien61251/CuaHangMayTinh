using CuaHangMayTinh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CuaHangMayTinh.Controllers
{
    public class CustomerController
    {
        private static CustomerController instance;

        public static CustomerController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerController();
                }
                return instance;
            }
            private set { CustomerController.instance = value; }
        }

        private CustomerController() { }

        private string connectionString = @"Data Source=TIENLV;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string script = @"";

        public void FillCategoryComboBox(string script, ComboBox DropDownName)
        {
            // If you use a DataTable (or any object which implmenets IEnumerable)
            // you can bind the results of your query directly as the 
            // datasource for the ComboBox. 
            DataTable dt = new DataTable();

            // Where possible, use the using block for data access. The 
            // using block handles disposal of resources and connection 
            // cleanup for you:
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(script, conn))
                {
                    conn.Open();

                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        // Do some logging or something. 
                        MessageBox.Show("Lỗi " + e.ToString());
                    }
                }
            }

            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[1].ColumnName;
        }

        public List<Customer> GetCustomer()
        {
            List<Customer> list = new List<Customer>();

            script = @"EXEC usp_GetCustomerInfo";

            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Customer customer = new Customer();
                list.Add(customer);
            }

            return list;
        }

        public void LoadCustomer(DataGridView dataGridViewName)
        {
            script = @"EXEC usp_GetCustomerInfo";

            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }

        public bool AddCustomer(string hoTen, string email, string soDienThoai, string diaChi, int diemTichLuy)
        {
            int result;

            script = @"EXEC usp_AddCustomer @HoTen , @Email , @SoDienThoai , @DiaChi  , @DiemTichLuy ";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { hoTen, email, soDienThoai, diaChi, diemTichLuy });
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result == 1;
        }

        public bool UpdateCustomer(int maKH, string hoTen, string email, string soDienThoai, string diaChi, int diemTichLuy)
        {
            int result;

            script = @"EXEC usp_UpdateCustomerInfo @MaKh , @HoTen , @Email , @SoDienThoai , @DiaChi  , @DiemTichLuy ";
            //script = @"EXEC usp_UpdateCustomerInfo @MaKH = 11, @HoTen = 'Khach Hang 1', @Email = 'khachhang1@gmail.com', @DiaChi = 'Back Khoa, Hai Ba Trung, Ha Noi', @SoDienThoai = '0936895426', @DiemTichLuy = 0";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maKH, hoTen, email, soDienThoai, diaChi, diemTichLuy });
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result == 1;
        }

        public bool DeleteCustomer(int maKH)
        {
            int result;

            script = @"EXEC usp_DelCustomerById @MaKH";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maKH });
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return result == 1;
        }

        public void SearchCustomer(string search, DataGridView dataGridViewName)
        {
            script = @"EXEC usp_SearchCustomer @Search = N'" + search + "'";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }
    }
}
