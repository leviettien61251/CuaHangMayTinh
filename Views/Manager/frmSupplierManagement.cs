using CuaHangMayTinh.Controllers;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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

        readonly Regex regexOnlyNum = new Regex(@"^\d+$");

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
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text))
                {
                    if (CheckValidate.Instance.IsEmail(email))
                    {
                        AddSupplier_(tenNCC, email, diaChi, soDienThoai);
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng Email");
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
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtPhone.Text))
                {
                    if (CheckValidate.Instance.IsEmail(email))
                    {
                        UpdateSupplier_(maNCC, tenNCC, email, diaChi, soDienThoai);
                    }
                    else
                    {
                        MessageBox.Show("Sai định dạng Email");
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

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //ExcelController.Instance.SaveExcel(dgvInventory, "titleWb", "Inventory");
                ExcelController.Instance.SaveExcel(dgvSuppliers, "Suppliers List", "Suppliers");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
