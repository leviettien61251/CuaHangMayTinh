using ClosedXML.Excel;
using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Data.SqlClient;
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

        int _maDanhMuc, _maNCC;


        #region Method
        private void LoadData()
        {
            LoadProduct();
            LoadCategory();
            loadComboboxCategory();
            loadComboboxSupplier();
        }


        private void LoadProduct()
        {
            ProductController.Instance.LoadProduct(dataGridViewProduct);
        }

        private void LoadCategory()
        {
            CategoryController.Instance.LoadCategory(dataGridViewCategory);
        }

        private void loadComboboxCategory()
        {
            List<Category> listCategories = new List<Category>();

            listCategories = CategoryController.Instance.GetCategory();

            comboBoxCategory.DataSource = listCategories;

            comboBoxCategory.DisplayMember = "Name";

            //CategoryController.Instance.FillCategoryComboBox(script, comboBoxLoaiSP); old
        }

        private void loadComboboxSupplier()
        {
            List<Supplier> listSupplier = new List<Supplier>();

            listSupplier = SupplierController.Instance.GetSupplier();

            comboBoxMaNCC.DataSource = listSupplier;

            comboBoxMaNCC.DisplayMember = "Name";

        }

        private void loadComboboxCategoryByID()
        {
            List<Category> listCategories = new List<Category>();

            listCategories = CategoryController.Instance.GetCategory();

            comboBoxCategory.DataSource = listCategories;

            comboBoxCategory.DisplayMember = "Name";

            //CategoryController.Instance.FillCategoryComboBox(script, comboBoxLoaiSP); 
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuaHangMayTinhDataSet1.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.cuaHangMayTinhDataSet1.NhaCungCap);
            // TODO: This line of code loads data into the 'cuaHangMayTinhDataSet.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter.Fill(this.cuaHangMayTinhDataSet.DanhMuc);

            LoadData();
        }

        #endregion

        #region Events

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string TenSP = textBoxTenSP.Text;

            int MaDanhMuc = _maDanhMuc;

            int MaNCC = _maNCC;

            string MoTa = "";

            int BaoHanh = 36;

            float GiaNhap = (float)double.Parse(textBoxGiaNhap.Text);

            float GiaBan = (float)double.Parse(textBoxGiaBan.Text);

            int SoLuongTon = (int)double.Parse(textBoxSoLuong.Text);

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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int MaSP = (int)double.Parse(textBoxMaSP.Text);

            string TenSP = textBoxTenSP.Text;

            int MaDanhMuc = _maDanhMuc;

            int MaNCC = _maNCC;

            string MoTa = "";

            int BaoHanh = 36;

            float GiaNhap = (float)double.Parse(textBoxGiaNhap.Text);

            float GiaBan = (float)double.Parse(textBoxGiaBan.Text);

            int SoLuongTon = (int)double.Parse(textBoxSoLuong.Text);

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

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string maSP = textBoxMaSP.Text;
            ProductController.Instance.RemoveProduct(maSP);
            LoadProduct();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ExcelController.Instance.SaveExcel(dataGridViewProduct, "Product Report", "Product");
            //if (dataGridViewProduct.Rows.Count > 0)
            //{
            //    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            //    {
            //        if (sfd.ShowDialog() == DialogResult.OK)
            //        {
            //            try
            //            {
            //                using (XLWorkbook wb = new XLWorkbook())
            //                {
            //                    var ws = wb.Worksheets.Add("NhanVien");

            //                    //ws.Cell(1, 1).Value = "ABCDEF";
            //                    var range = ws.Range(1, 1, 1, dataGridViewProduct.Columns.Count);
            //                    range.Merge(); 
            //                    range.Value = "Báo cáo sản phẩm"; 
            //                    range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; 
            //                    range.Style.Font.Bold = true; 
            //                    range.Style.Font.FontSize = 16;

            //                    // ghi header
            //                    for (int i = 0; i < dataGridViewProduct.Columns.Count; i++)
            //                    {

            //                        ws.Cell(2, i + 1).Value = dataGridViewProduct.Columns[i].HeaderText;
            //                    }
            //                    // ghi du lieu
            //                    for (int i = 0; i < dataGridViewProduct.Rows.Count; i++)
            //                    {
            //                        for (int j = 0; j < dataGridViewProduct.Columns.Count; j++)
            //                        {
            //                            ws.Cell(i + 3, j + 1).Value = dataGridViewProduct.Rows[i].Cells[j].Value.ToString();
            //                        }
            //                    }
            //                    ws.Columns().AdjustToContents();
            //                    wb.SaveAs(sfd.FileName);
            //                    MessageBox.Show("Export to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
        }

        private void ClearTextBox()
        {
            textBoxMaSP.Clear();
            textBoxTenSP.Clear();
            //textBoxNCC.Clear();
            textBoxGiaBan.Clear();
            textBoxGiaNhap.Clear();
            textBoxSoLuong.Clear();
        }

        private void comboBoxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                labelCheckIDCategory.Text = "ID: ko lấy đượcssss";
                return;
            }

            Category selected = cb.SelectedItem as Category;

            if (selected != null)
            {
                _maDanhMuc = selected.MaDanhMuc;
                labelCheckIDCategory.Text = "ID: " + _maDanhMuc.ToString();
            }
            else
            {
                labelCheckIDCategory.Text = "ID: ko lấy được";
            }

        }



        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loadComboboxCategory();
            textBoxMaSP.Text = dataGridViewProduct.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSP.Text = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            comboBoxCategory.Text = dataGridViewProduct.CurrentRow.Cells[2].Value.ToString();
            comboBoxMaNCC.Text = dataGridViewProduct.CurrentRow.Cells[4].Value.ToString();
            textBoxGiaNhap.Text = dataGridViewProduct.CurrentRow.Cells[8].Value.ToString();
            textBoxGiaBan.Text = dataGridViewProduct.CurrentRow.Cells[9].Value.ToString();
            textBoxSoLuong.Text = dataGridViewProduct.CurrentRow.Cells[10].Value.ToString();
        }



        #endregion



        private void comboBoxMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                labelCheckIDNCC.Text = "ID: ko lấy đượcssss";
                return;
            }

            Supplier selected = cb.SelectedItem as Supplier;

            if (selected != null)
            {
                _maNCC = selected.MaNCC;
                labelCheckIDNCC.Text = "ID: " + _maNCC.ToString();
            }
            else
            {
                labelCheckIDNCC.Text = "ID: ko lấy được";
            }
        }
    }
}
