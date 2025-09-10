using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
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

namespace CuaHangMayTinh.Views
{
    public partial class FormTestSanPham : Form
    {
        public FormTestSanPham()
        {
            InitializeComponent();
        }

        int idSupplier, idCategory;
        readonly Regex regexOnlyNum = new Regex("^[0-9]*$");

        private void FormTestSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuaHangMayTinhDataSet2.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.cuaHangMayTinhDataSet2.DanhMuc);
            LoadProduct();
        }

        private void LoadProduct()
        {
            loadComboboxCategory();
            loadComboboxSupplier();
            ProductController.Instance.LoadProduct(dgvProducts);
        }

        private void loadComboboxCategory()
        {
            List<Category> listCategories = new List<Category>();

            listCategories = CategoryController.Instance.GetCategory();

            cbCategory.DataSource = listCategories;

            cbCategory.DisplayMember = "Name";

            //CategoryController.Instance.FillCategoryComboBox(script, comboBoxLoaiSP); old
        }

        private void loadComboboxSupplier()
        {
            List<Supplier> listSupplier = new List<Supplier>();

            listSupplier = SupplierController.Instance.GetSupplier();

            cbSupplier.DataSource = listSupplier;

            cbSupplier.DisplayMember = "Name";

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loadComboboxCategory();
            txtProductId.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();

            txtProductName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();

            cbCategory.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();

            cbSupplier.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();

            txtImportPrice.Text = dgvProducts.CurrentRow.Cells[8].Value.ToString();

            txtSalePrice.Text = dgvProducts.CurrentRow.Cells[9].Value.ToString();

            txtStockQuantity.Text = dgvProducts.CurrentRow.Cells[10].Value.ToString();
        }

        private void comboBoxMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }

            Supplier selected = cb.SelectedItem as Supplier;

            if (selected != null)
            {
                idSupplier = selected.MaNCC;
                labelNCC.Text = idSupplier.ToString();
            }
        }

        private void comboBoxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;

            if (selected != null)
            {
                idCategory = selected.MaDanhMuc;
                labelCHeckID.Text = "ID: " + idCategory.ToString();
            }


        }

        private void ClearTextBox()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            //textBoxNCC.Clear();
            txtImportPrice.Clear();
            txtSalePrice.Clear();
            txtStockQuantity.Clear();
        }

        private void AddProduct_(string TenSP, int MaDanhMuc, int MaNCC, string MoTa, int BaoHanh, float GiaNhap, float GiaBan, int SoLuongTon)
        {
            try
            {

                bool result = ProductController.Instance.AddProduct(TenSP, MaDanhMuc, MaNCC, MoTa, BaoHanh, GiaNhap, GiaBan, SoLuongTon);

                if (result)
                {
                    MessageBox.Show("Thêm mới sản phẩm thành công!");
                    ClearTextBox();
                    LoadProduct();
                }
                else
                {
                    MessageBox.Show("Thêm mới sản phẩm không thành công!");
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void UpdateProduct_(int MaSP, string TenSP, int MaDanhMuc, int MaNCC, string MoTa, int BaoHanh, float GiaNhap, float GiaBan, int SoLuongTon)
        {
            try
            {
                bool result = ProductController.Instance.UpdateProduct(MaSP, TenSP, MaDanhMuc, MaNCC, MoTa, BaoHanh, GiaNhap, GiaBan, SoLuongTon);

                if (result)
                {
                    MessageBox.Show("Lưu sản phẩm thành công!");
                    ClearTextBox();
                    LoadProduct();
                }
                else
                {
                    MessageBox.Show("Lưu sản phẩm không thành công!");
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string TenSP = txtProductName.Text;

            int MaDanhMuc = idCategory;

            int MaNCC = idSupplier;

            string MoTa = "";

            int BaoHanh = 36;

            if (txtImportPrice.Text.IsNullOrEmpty() || txtSalePrice.Text.IsNullOrEmpty() || txtStockQuantity.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtImportPrice.Text) || regexOnlyNum.IsMatch(txtSalePrice.Text) || regexOnlyNum.IsMatch(txtStockQuantity.Text))
                {
                    float GiaNhap = (float)double.Parse(txtImportPrice.Text);

                    float GiaBan = (float)double.Parse(txtSalePrice.Text);

                    int SoLuongTon = (int)double.Parse(txtStockQuantity.Text);
                    AddProduct_(TenSP, MaDanhMuc, MaNCC, MoTa, BaoHanh, GiaNhap, GiaBan, SoLuongTon);
                }
                else
                {
                    MessageBox.Show("Giá bán, giá nhập, số lượng tồn chỉ được điền số");
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int MaSP = (int)double.Parse(txtProductId.Text);

            string TenSP = txtProductName.Text;

            int MaDanhMuc = idCategory;

            int MaNCC = idSupplier;

            string MoTa = " ";

            int BaoHanh = 36;

            

            if (txtImportPrice.Text.IsNullOrEmpty() || txtSalePrice.Text.IsNullOrEmpty() || txtStockQuantity.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (regexOnlyNum.IsMatch(txtImportPrice.Text) && regexOnlyNum.IsMatch(txtSalePrice.Text) && regexOnlyNum.IsMatch(txtStockQuantity.Text))
                {
                    float GiaNhap = (float)double.Parse(txtImportPrice.Text);

                    float GiaBan = (float)double.Parse(txtSalePrice.Text);

                    int SoLuongTon = (int)double.Parse(txtStockQuantity.Text);
                    UpdateProduct_(MaSP, TenSP, MaDanhMuc, MaNCC, MoTa, BaoHanh, GiaNhap, GiaBan, SoLuongTon);
                }
                else
                {
                    MessageBox.Show("Giá bán, giá nhập, số lượng tồn chỉ được điền số");
                }
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchProduct.Text.ToString();
            ProductController.Instance.SearchProduct(search, dgvProducts);
            LoadProduct();
        }


    }
}
