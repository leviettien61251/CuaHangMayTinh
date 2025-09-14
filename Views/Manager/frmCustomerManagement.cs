using CuaHangMayTinh.Controllers;
using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CuaHangMayTinh.Views.Manager
{
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        readonly Regex regexOnlyNum = new Regex(@"^\d+$");

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            try
            {
                CustomerController.Instance.LoadCustomer(dgvCustomers);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void ClearTextBox()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
        }

        private void AddCustomer_(string hoTen, string email, string diaChi, string soDienThoai, int diemTichLuy)
        {
            try
            {
                bool result;

                result = CustomerController.Instance.AddCustomer(hoTen, email, soDienThoai, diaChi, diemTichLuy);

                if (result)
                {
                    MessageBox.Show("Thêm mới khách hàng thành công!");
                    ClearTextBox();
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Thêm mới khách hàng không thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UpdateCustomer_(int maKH, string hoTen, string email, string diaChi, string soDienThoai, int diemTichLuy)
        {
            try
            {
                bool result;

                result = CustomerController.Instance.UpdateCustomer(maKH, hoTen, email, soDienThoai, diaChi, diemTichLuy);

                if (result)
                {
                    MessageBox.Show("Sửa mới khách hàng thành công!");
                    ClearTextBox();
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Sửa mới khách hàng không thành công!");
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
            string hoTen = txtCustomerName.Text;
            string email = txtEmail.Text;
            string diaChi = txtAddress.Text;
            string soDienThoai = txtPhone.Text;
            int diemTichLuy = 1000;//default = 0

            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text))
                {
                    if (CheckValidate.Instance.IsEmail(email))
                    {
                        AddCustomer_(hoTen, email, diaChi, soDienThoai, diemTichLuy);
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng Email");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ được điền số");
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int maKH = (int)Convert.ToDouble(txtCustomerId.Text);
            string hoTen = txtCustomerName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string diaChi = txtAddress.Text.ToString();
            string soDienThoai = txtPhone.Text.ToString();
            int diemTichLuy = 1000;//default = 0

            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text))
                {
                    if (CheckValidate.Instance.IsEmail(email))
                    {
                        UpdateCustomer_(maKH, hoTen, email, diaChi, soDienThoai, diemTichLuy);
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng Email");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ được điền số");
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maKH = (int)Convert.ToDouble(txtCustomerId.Text);
            try
            {
                bool result;

                result = CustomerController.Instance.DeleteCustomer(maKH);

                if (result)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    ClearTextBox();
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công!");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchCustomer.Text.ToLower();
            CustomerController.Instance.SearchCustomer(search, dgvCustomers);
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //ExcelController.Instance.SaveExcel(dgvInventory, "titleWb", "Inventory");
                ExcelController.Instance.SaveExcel(dgvCustomers, "Customer List", "Customer");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
