using CuaHangMayTinh.Controllers;
using Microsoft.Data.SqlClient;
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
    public partial class frmDetailOrder : Form
    {
        public frmDetailOrder()
        {
            InitializeComponent();
        }

        private int maDH;

        readonly Regex regexOnlyNum = new Regex(@"^\d+$");

        public frmDetailOrder(int MaDH)
        {
            InitializeComponent();
            maDH = MaDH;
        }

        private void frmDetailOrder_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = maDH.ToString();
            txtOrderId.ReadOnly = true;
            txtDetailOrderId.ReadOnly = true;
            LoadProduct();
            LoadDetailOrder();
        }

        private void LoadProduct()
        {
            try
            {
                ProductController.Instance.LoadProduct(dgvProductList);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LoadDetailOrder()
        {
            try
            {
                OrderController.Instance.LoadOrderDetail(dgvDetailOrder, maDH);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddProductToOrder(int maDH, int maSP, int soLuong)
        {
            try
            {

                if (OrderController.Instance.AddProductToOrderDetail(maDH, maSP, soLuong))
                {
                    MessageBox.Show("Thêm mới sản phẩm vào đơn hàng thành công!!");
                    LoadProduct();
                    LoadDetailOrder();
                }
                else
                {
                    MessageBox.Show("Thêm mới sản phẩm vào đơn hàng không thành công!!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateProductFromOrder(int maCTDH, int maDH, int maSP, int soLuong)
        {
            try
            {

                if (OrderController.Instance.UpdateProductFromDetailOrder(maCTDH, maDH, maSP, soLuong))
                {
                    MessageBox.Show("Lưu sản phẩm vào đơn hàng thành công!!");
                    LoadProduct();
                    LoadDetailOrder();
                }
                else
                {
                    MessageBox.Show("Lưu sản phẩm vào đơn hàng không thành công!!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DelProductFromOrderDetail(int maCTDH, int maDH, int maSP)
        {
            try
            {

                if (OrderController.Instance.DelProductFromDetailOrder(maCTDH, maDH, maSP))
                {
                    MessageBox.Show("Xóa sản phẩm trong đơn hàng thành công!!");
                    LoadProduct();
                    LoadDetailOrder();
                }
                else
                {
                    MessageBox.Show("Xóa mới sản phẩm trong đơn hàng không thành công!!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            if (txtProductId.Text.IsNullOrEmpty() || txtQuantity.Text.IsNullOrEmpty())
            {

                MessageBox.Show("Hãy điền đầy đủ mã sản phẩm hoặc số lượng!!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtOrderId.Text) && regexOnlyNum.IsMatch(txtProductId.Text) && regexOnlyNum.IsMatch(txtQuantity.Text))
                {
                    int maDH = (int)Convert.ToDouble(txtOrderId.Text.ToString());
                    int maSP = (int)Convert.ToDouble(txtProductId.Text.ToString());
                    int soLuong = (int)Convert.ToDouble(txtQuantity.Text.ToString());
                    AddProductToOrder(maDH, maSP, soLuong);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm và ố lượng chỉ được dùng số!!");
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDetailOrderId.Text.IsNullOrEmpty() || txtOrderId.Text.IsNullOrEmpty() || txtProductId.Text.IsNullOrEmpty() || txtQuantity.Text.IsNullOrEmpty())
            {

                MessageBox.Show("Hãy chọn sản phẩm!!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtDetailOrderId.Text) && regexOnlyNum.IsMatch(txtOrderId.Text) && regexOnlyNum.IsMatch(txtProductId.Text) && regexOnlyNum.IsMatch(txtQuantity.Text))
                {
                    int maCTDH = (int)Convert.ToDouble(txtDetailOrderId.Text.ToString());
                    int maDH = (int)Convert.ToDouble(txtOrderId.Text.ToString());
                    int maSP = (int)Convert.ToDouble(txtProductId.Text.ToString());
                    int soLuong = (int)Convert.ToDouble(txtQuantity.Text.ToString());
                    UpdateProductFromOrder(maCTDH, maDH, maSP, soLuong);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm, mã chi tiết đơn hàng và số lượng chỉ được dùng số!!");
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDetailOrderId.Text.IsNullOrEmpty() || txtOrderId.Text.IsNullOrEmpty() || txtProductId.Text.IsNullOrEmpty())
            {

                MessageBox.Show("Hãy chọn sản phẩm!!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtDetailOrderId.Text) && regexOnlyNum.IsMatch(txtOrderId.Text) && regexOnlyNum.IsMatch(txtProductId.Text))
                {
                    int maCTDH = (int)Convert.ToDouble(txtDetailOrderId.Text.ToString());
                    int maDH = (int)Convert.ToDouble(txtOrderId.Text.ToString());
                    int maSP = (int)Convert.ToDouble(txtProductId.Text.ToString());

                    DelProductFromOrderDetail(maCTDH, maDH, maSP);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm và ố lượng chỉ được dùng số!!");
                    return;
                }
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = dgvProductList.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvDetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetailOrderId.Text = dgvDetailOrder.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelController.Instance.SaveExcel(dgvDetailOrder, "Order Detail List", "Order Detail");
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
