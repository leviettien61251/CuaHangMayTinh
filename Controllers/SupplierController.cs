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

            string script = @"EXEC usp_GetNhaCungCap";

            DataTable dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Supplier supplier = new Supplier(item);

                list.Add(supplier);
            }
            return list;
        }
    }
}
