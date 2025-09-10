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
    public class SupplierController
    {
        private static SupplierController instance;

        private string connectionString = @"Data Source=TIENLV;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static SupplierController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SupplierController();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private SupplierController() { }

        public void FillSupplierComboBox(string script, ComboBox DropDownName)
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
            //DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[1].ColumnName;
        }

        public List<Supplier> GetSupplier()
        {

            List<Supplier> list = new List<Supplier>();

            string script = @"EXEC usp_GetSupplier";

            DataTable dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Supplier supplier = new Supplier(item);

                list.Add(supplier);
            }
            return list;
        }

        public void LoadSupplier(DataGridView dataGridViewName)
        {

            string script = @"EXEC usp_GetSupplier";
            try
            {
                dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool AddSupplier(string tenNCC, string email, string soDienThoai, string diaChi)
        {
            int result;

            string script = @"EXEC usp_AddSupplier @TenNCC , @Email , @SoDienThoai , @DiaChi ";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { tenNCC, email, soDienThoai, diaChi });
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result == 1;
        }

        public bool UpdateSupplier(int maNCC, string tenNCC, string email, string soDienThoai, string diaChi)
        {
            int result;

            string script = @"EXEC usp_UpdateSupplierInfo @MaNCC , @TenNCC , @Email , @SoDienThoai , @DiaChi ";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maNCC, tenNCC, email, soDienThoai, diaChi });
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return result == 1;
        }

        public bool DeleteSupplier(int maNCC)
        {
            int result;

            string script = @"EXEC usp_DelSupplierById @MaNCC";

            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(script, new object[] { maNCC });
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return result == 1;
        }

        public void SearchSupplier(string search, DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_SearchSupplier @Search = N'" + search + "'";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }
    }
}
