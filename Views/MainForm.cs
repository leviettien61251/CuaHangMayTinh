using System;
using System.Windows.Forms;

namespace ComputerStoreManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Thiết lập làm MDI container
        }

       

        #region Event Handlers cho Hệ thống menu
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Đăng nhập");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Đăng xuất");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Event Handlers cho Quản lý menu
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmProductManagement(), "Quản lý Sản phẩm");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmCustomerManagement(), "Quản lý Khách hàng");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmEmployeeManagement(), "Quản lý Nhân viên");
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmSupplierManagement(), "Quản lý Nhà cung cấp");
        }
        #endregion

        #region Event Handlers cho Bán hàng menu
        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmCreateInvoice(), "Tạo hóa đơn");
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmInvoiceHistory(), "Lịch sử hóa đơn");
        }
        #endregion

        #region Event Handlers cho Thống kê menu
        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmRevenueReport(), "Thống kê doanh thu");
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmInventoryReport(), "Thống kê tồn kho");
        }

        private void sảnPhẩmBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiForm(new frmBestSellersReport(), "Sản phẩm bán chạy");
        }
        #endregion

        #region Event Handlers cho Trợ giúp menu
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hướng dẫn sử dụng hệ thống");
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm quản lý bán máy tính\nVersion 1.0");
        }
        #endregion

        #region Phương thức hỗ trợ
        /// <summary>
        /// Hiển thị form dưới dạng MDI child
        /// </summary>
        private void ShowMdiForm(Form childForm, string title)
        {
            try
            {
                // Kiểm tra nếu form đã mở
                foreach (Form form in this.MdiChildren)
                {
                    if (form.GetType() == childForm.GetType())
                    {
                        form.BringToFront();
                        form.WindowState = FormWindowState.Normal;
                        lblStatus.Text = $"Đang mở: {title}";
                        return;
                    }
                }

                // Thiết lập form con
                childForm.MdiParent = this;
                childForm.Text = title;
                childForm.FormClosed += (s, args) =>
                {
                    lblStatus.Text = "Trạng thái: Sẵn sàng";
                };

                lblStatus.Text = $"Đang mở: {title}";
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Lỗi khi mở form";
            }
        }

        /// <summary>
        /// Hiển thị form dạng dialog (modal)
        /// </summary>
        private void ShowDialogForm(Form dialogForm, string title)
        {
            try
            {
                dialogForm.Text = title;
                dialogForm.StartPosition = FormStartPosition.CenterScreen;
                lblStatus.Text = $"Đang mở: {title}";
                dialogForm.ShowDialog();
                lblStatus.Text = "Trạng thái: Sẵn sàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Lỗi khi mở form";
            }
        }
        #endregion

        #region Menu Window Arrangement
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
        #endregion
    }
}