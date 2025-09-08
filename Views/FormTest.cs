using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
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


        #region Method
        public void LoadData()
        {
            LoadProduct();
            LoadCategory();
            loadComboboxCategory();
        }

        public void LoadProduct()
        {
            ProductController.Instance.LoadProduct(dataGridViewProduct);
        }

        public void LoadCategory()
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

        private void FormTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        #region Events

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void comboBoxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _maDanhMuc;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                labelCheckIDCategory.Text = "ID: ko lấy đượcssss";
                return;
            }



            Category selected = cb.SelectedItem as Category;
            //selected.MaDanhMuc

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
    }
}
