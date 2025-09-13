using ComputerStoreManagement;
using CuaHangMayTinh.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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

namespace CuaHangMayTinh.Views
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

        }
        public LoginForm(string username, string password)
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private bool checkLogin(string username, string password)
        {
            return AccountController.Instance.Login(username, password);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                var username = textBoxUsername.Text;//lấy username từ textbox
                var password = textBoxPassword.Text;//lấy password từ textbox

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!");
                    return;
                }
                else
                {
                    if (checkLogin(username, password))
                    {
                        MainForm F_main = new MainForm();
                        //FormTest F_main = new FormTest();
                        //MessageBox.Show("Đăng nhập thành công!");
                        this.Hide(); //ẩn form đăng nhập
                        F_main.ShowDialog();
                        this.Show();
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                        return;
                    }
                }

            }
            catch (SqlException ex)
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
            if (MessageBox.Show("Xác nhận thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
