using CuaHangMayTinh.Controllers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CuaHangMayTinh.Models
{
    public class AccountController
    {

        private static AccountController instance;

        public static AccountController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountController();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private AccountController() { }

        string script = @"";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;

        public bool Login(string username, string password)
        {
            try
            {


                script = @"EXEC usp_KiemTraThongTinTaiKhoan 
                            @Username , @Password ";

                //script = @"SELECT * FROM TaiKhoan WHERE Username = 'a' AND Password = 'a'";

                DataTable result = DataProvider.Instance.ExecuteQuery(script, new object[] {username, password});

                return result.Rows.Count > 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);//thông báo lỗi
                throw ex;
            }
        }




    }
}
