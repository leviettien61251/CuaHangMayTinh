using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangMayTinh.Models;
using Microsoft.Data.SqlClient;

namespace CuaHangMayTinh.Views
{
    public partial class LoginForm : Form
    {
        private AccountModel _accountModel;
        public LoginForm()
        {
            InitializeComponent();
            _accountModel = new AccountModel();
        }
        string connectionString = @"Data Source=TIENLV;Initial Catalog=CuaHangMayTinh;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ) 
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                _accountModel.DangNhap(username, password);
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
            }  
        }
    }
}
