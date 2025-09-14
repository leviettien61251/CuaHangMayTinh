using ClosedXML.Excel;
using CuaHangMayTinh.Controllers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Sale
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        readonly Regex regexOnlyNum = new Regex(@"^\d+$");

        private void FormCreateInvoice_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            try
            {
                OrderController.Instance.LoadOrder_Customer(dgvOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form form;
            int MaDH;
            if (txtOrderId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Chưa chọn đơn hàng!!");
                return;
            }
            else
            {
                MaDH = (int)Convert.ToDouble(txtOrderId.Text);
                frmDetailOrder F_detailOrder = new frmDetailOrder(MaDH);
                form = F_detailOrder;
                form.ShowDialog();
                form.BringToFront();
            }


        }

        private void CleatTextBox()
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtCustomerAddress.Clear();
            txtCustomerId.Clear();
            txtEmployeeId.Clear();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            float tamTinh = (float)Convert.ToDouble(dgvOrder.CurrentRow.Cells[8].Value.ToString());
            double tax = tamTinh * 0.1;
            double final = tamTinh + tax;
            txtOrderId.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dgvOrder.CurrentRow.Cells[1].Value.ToString();
            txtCustomerPhone.Text = dgvOrder.CurrentRow.Cells[2].Value.ToString();
            txtCustomerAddress.Text = dgvOrder.CurrentRow.Cells[3].Value.ToString();
            lblSubTotal.Text = dgvOrder.CurrentRow.Cells[8].Value.ToString() + "đ";
            lblTax.Text = tax.ToString() + "đ";
            lblTotalAmount.Text = final.ToString() + "đ";
            txtCustomerId.Text = dgvOrder.CurrentRow.Cells[4].Value.ToString();
            txtEmployeeId.Text = dgvOrder.CurrentRow.Cells[5].Value.ToString();
            dtpOrderDate.Text = dgvOrder.CurrentRow.Cells[6].Value.ToString();
        }

        private void AddOrder_(int maKH, int maNV, string phuongThucTT, string diaChi)
        {

            try
            {
                if (OrderController.Instance.AddOrder(maKH, maNV, phuongThucTT, diaChi))
                {
                    MessageBox.Show("Thêm mới đơn hàng thành công!");
                    CleatTextBox();
                    LoadOrderList();
                }
                else
                {
                    MessageBox.Show("Thêm mới đơn hàng không thành công!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DelOrder_(int maDH, int maNV)
        {

            try
            {
                if (OrderController.Instance.DeleteOrder(maDH, maNV))
                {
                    MessageBox.Show("Xóa đơn hàng " + maDH + " thành công!!");
                    CleatTextBox();
                    LoadOrderList();
                }
                else
                {
                    MessageBox.Show("Xóa đơn hàng " + maDH + " không thành công");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text.IsNullOrEmpty() || txtEmployeeId.Text.IsNullOrEmpty() || txtCustomerAddress.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            else
            {

                string phuongThucTT = txtCustomerId.Text.ToString();
                string diaChi = txtCustomerId.Text.ToString();
                if (regexOnlyNum.IsMatch(txtCustomerId.Text) && regexOnlyNum.IsMatch(txtEmployeeId.Text))
                {

                    int maKH = (int)Convert.ToDouble(txtCustomerId.Text);
                    int maNV = (int)Convert.ToDouble(txtEmployeeId.Text);
                    AddOrder_(maKH, maNV, "COD", diaChi);
                }
                else
                {
                    MessageBox.Show("Mã khách hàng và mã nhân viên chỉ được điền số!!");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text.IsNullOrEmpty() || txtEmployeeId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ mã đơn hàng và mã nhân viên!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtOrderId.Text) && regexOnlyNum.IsMatch(txtEmployeeId.Text))
                {
                    int maDH = (int)Convert.ToDouble(txtOrderId.Text);
                    int maNV = (int)Convert.ToDouble(txtEmployeeId.Text);
                    DelOrder_(maDH, maNV);
                }
                else
                {
                    MessageBox.Show("Mã đơn hàng và mã nhân viên chỉ được điền số!!");
                    return;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelController.Instance.SaveExcel(dgvOrder, "Order List", "Order");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
