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
    public class EmployeeController
    {
        private static EmployeeController instance;

        public static EmployeeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeController();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private EmployeeController() { }

        public List<Employee> GetSupplier()
        {

            List<Employee> list = new List<Employee>();

            string script = @"EXEC usp_GetEmployee";

            DataTable dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Employee employee = new Employee(item);

                list.Add(employee);
            }
            return list;
        }

        public void LoadEmployee(DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_GetEmployee";
            try
            {
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool AddEmployee(string hoTen, string soDienThoai, string email, string diaChi, float luongCoBan)
        {
            int result;

            string script = @"EXEC usp_AddEmployee @HoTen , @SoDienThoai , @Email , @DiaChi , @LuongCoBan ";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { hoTen, soDienThoai, email, diaChi, luongCoBan });
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result == 1;
        }

        public bool UpdateEmployee(int maNV, string hoTen, string soDienThoai, string email, string diaChi, float luongCoBan)
        {
            int result;

            string script = @"EXEC usp_UpdateEmployeeInfo @MaNV , @HoTen , @SoDienThoai , @Email , @DiaChi , @LuongCoBan ";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maNV, hoTen, soDienThoai, email, diaChi, luongCoBan });
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result == 1;
        }

        public bool DeleteEmployee(int maNV)
        {
            int result;

            string script = @"EXEC usp_DelEmployeeById @MaNV";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maNV });
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return result == 1;
        }

        public void SearchEmployee(string search, DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_SearchEmployee @Search = N'" + search + "'";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }
    }
}
