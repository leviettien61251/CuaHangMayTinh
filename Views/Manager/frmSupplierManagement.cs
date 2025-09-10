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

namespace CuaHangMayTinh.Views.Manager
{
    public partial class frmSupplierManagement : Form
    {
        public frmSupplierManagement()
        {
            InitializeComponent();
        }

        private void frmSupplierManagement_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            try
            {
                SupplierController.Instance.LoadSupplier(dgvSuppliers);
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

        private void ClearTextBox()
        {
            txtSupplierId.Clear();
            txtSupplierName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierId.Text = dgvSuppliers.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvSuppliers.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvSuppliers.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvSuppliers.CurrentRow.Cells[4].Value.ToString();
        }

        private void AddSupplier_(string tenNCC, string email, string diaChi, string soDienThoai)
        {
            try
            {
                bool result;

                result = SupplierController.Instance.AddSupplier(tenNCC, email, soDienThoai, diaChi);

                if (result)
                {
                    MessageBox.Show("Thêm mới nhà cung cấp thành công!");
                    ClearTextBox();
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Thêm mới nhà cung cấp không thành công!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UpdateSupplier_(int maNCC, string tenNCC, string email, string diaChi, string soDienThoai)
        {
            try
            {
                bool result;

                result = SupplierController.Instance.UpdateSupplier(maNCC, tenNCC, email, soDienThoai, diaChi);

                if (result)
                {
                    MessageBox.Show("Sửa mới nhà cung cấp thành công!");
                    ClearTextBox();
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Sửa mới nhà cung cấp không thành công!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string tenNCC = txtSupplierName.Text;
            string email = txtEmail.Text;
            string diaChi = txtAddress.Text;
            string soDienThoai = txtPhone.Text;
            Regex regexOnlyNum = new Regex(@"^\d+$");
            Regex regexNoWhitespace = new Regex("^[^0-9\\s]+$");
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text))
                {
                    if (regexNoWhitespace.IsMatch(txtEmail.Text))
                    {
                        AddSupplier_(tenNCC, email, diaChi, soDienThoai);
                    }
                    else
                    {
                        MessageBox.Show("Email không chứa khoảng trắng");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ được điền số");
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int maNCC = (int)Convert.ToDouble(txtSupplierId.Text);
            string tenNCC = txtSupplierName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string diaChi = txtAddress.Text.ToString();
            string soDienThoai = txtPhone.Text.ToString();
            Regex regexOnlyNum = new Regex(@"^\d+$");
            Regex regexNoWhitespace = new Regex("^[^0-9\\s]+$");
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text))
                {
                    if (regexNoWhitespace.IsMatch(txtEmail.Text))
                    {
                        UpdateSupplier_(maNCC, tenNCC, email, diaChi, soDienThoai);
                    }
                    else
                    {
                        MessageBox.Show("Email không chứa khoảng trắng");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ được điền số");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maNCC = (int)Convert.ToDouble(txtSupplierId.Text);
            try
            {
                bool result;

                result = SupplierController.Instance.DeleteSupplier(maNCC);

                if (result)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!");
                    ClearTextBox();
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp không thành công!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchSupplier.Text.ToLower();
            SupplierController.Instance.SearchSupplier(search, dgvSuppliers);
        }
    }
}
