using CuaHangMayTinh.Views;
using System;
using System.Windows.Forms;

namespace ComputerStoreManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                case "FormTest":
                    FormTest F_Test = new FormTest();
                    form = F_Test;
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        private void quảnLýToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                case "SanPham":
                    FormTestSanPham F_Test = new FormTestSanPham();
                    form = F_Test;
                    //F_Test.Show();
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }
    }
}