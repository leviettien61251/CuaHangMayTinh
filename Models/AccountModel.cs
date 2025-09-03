using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Models
{
    internal class AccountModel
    {
        string connectionString = @"Data Source=TIENLV;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string script = @"";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;



        public void DangNhap(string username, string password)
        {
            try
            {
                script = @"
                            EXEC usp_KiemTraThongTinTaiKhoan 
                            @Username = @_username, 
                            @Password = @_password
                            ";
                conn = new SqlConnection(connectionString);
                conn.Open();
                cmd = new SqlCommand(script, conn);
                cmd.Parameters.Add("@_username", SqlDbType.NVarChar);
                cmd.Parameters["@_username"].Value = username;
                cmd.Parameters.Add("@_password", SqlDbType.NVarChar);
                cmd.Parameters["@_password"].Value = password;
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
