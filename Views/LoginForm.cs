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
        string scritp = @"";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);//kết nối với database
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                var username = textBoxUsername.Text;//lấy username từ textbox
                var password = textBoxPassword.Text;//lấy password từ textbox

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!");//thông báo lỗi
                    return;
                }
                else
                {
                    _accountModel.DangNhap(username, password);
                    MessageBox.Show("Đăng nhập thành công!"); //thông báo thành công
                    this.Hide(); //ẩn form đăng nhập
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
              
        }

        private void labelQuenMK_Click(object sender, EventArgs e)
        {
            //khi ấn vào sẽ chuyển sang FormDoiMk
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            //khi ấn vào sẽ chuyển sang FormRegister
        }

        private void buttonShowHidePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
