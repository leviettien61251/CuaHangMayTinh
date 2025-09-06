using CuaHangMayTinh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CuaHangMayTinh.Views
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string script = @"EXEC usp_KiemTraThongTinTaiKhoan @Username , @Password 
                            ";
            //string script = @"SELECT * FROM TaiKhoan
            // 
            dataGridViewTest.DataSource = DataProvider.Instance.ExecuteQuery(script, new object[]{"a", "a"});
            //dataGridViewTest.DataSource = DataProvider.Instance.ExecuteQuery(script);

        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
