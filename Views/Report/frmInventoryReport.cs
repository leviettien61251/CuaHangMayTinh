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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Report
{
    public partial class frmInventoryReport : Form
    {
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private int maDM;
        private string titleWb, titleWs;

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuaHangMayTinhDataSet.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.cuaHangMayTinhDataSet.DanhMuc);
            loadComboboxCategory();
            LoadData();

        }

        private void LoadData()
        {

            int total = int.Parse(ProductController.Instance.GetTotalProduct().ToString());
            int outStock = int.Parse(ProductController.Instance.GetOutOfStockProduct().ToString());
            int lowStock = int.Parse(ProductController.Instance.GetLowStockProduct().ToString());
            lblTotalProducts.Text = total.ToString();
            lblOutOfStock.Text = outStock.ToString();
            lblLowStock.Text = lowStock.ToString();
            ProductController.Instance.LoadProduct(dataGridViewProduct);
        }

        private void loadComboboxCategory()
        {
            List<Category> listCategories = new List<Category>();

            listCategories = CategoryController.Instance.GetCategory();

            cbCategory.DataSource = listCategories;

            //cbCategory.DisplayMember = "Name";

            //CategoryController.Instance.FillCategoryComboBox(script, comboBoxLoaiSP);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }

            Category selected = cb.SelectedItem as Category;

            if (selected != null)
            {
                maDM = selected.MaDanhMuc;
                titleWb = selected.TenDanhMuc;
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

            int minStock;
            int maxStock;

            if (txtMinStock.Text.IsNullOrEmpty() || txtMaxStock.Text.IsNullOrEmpty())
            {
                //MessageBox.Show("Hãy điền giới hạn số lượng tồn!!");
                //return;
                if (maDM == 16)
                {
                    try
                    {
                        ProductController.Instance.LoadProduct(dataGridViewProduct);
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        ProductController.Instance.LoadProductByIDCategory(dataGridViewProduct, maDM);
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }

            }
            else
            {
                minStock = (int)Convert.ToDouble(txtMinStock.Text.ToString());
                maxStock = (int)Convert.ToDouble(txtMaxStock.Text.ToString());
                if (maDM == 16)
                {
                    try
                    {
                        ProductController.Instance.LoadProductOnlyStock(dataGridViewProduct, minStock, maxStock);
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        ProductController.Instance.LoadProductByIDCategoryAndStock(dataGridViewProduct, maDM, minStock, maxStock);
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.Instance.LoadProduct(dataGridViewProduct);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;

            if (txtMinStock.Text.IsNullOrEmpty() || txtMaxStock.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Hãy điền giới hạn số lượng tồn!!");
                return;
            }
            else
            {
                minStock = (int)Convert.ToDouble(txtMinStock.Text.ToString());
                maxStock = (int)Convert.ToDouble(txtMaxStock.Text.ToString());
                try
                {
                    ProductController.Instance.LoadProductByIDCategoryAndStock(dataGridViewProduct, maDM, minStock, maxStock);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                //ExcelController.Instance.SaveExcel(dgvInventory, "titleWb", "Inventory");
                ExcelController.Instance.SaveExcel(dataGridViewProduct, titleWb, "Inventory");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
