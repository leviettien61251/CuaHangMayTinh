using CuaHangMayTinh.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public frmDetailOrder(int MaDH)
        {
            InitializeComponent();
            maDH = MaDH;
        }

        private void frmDetailOrder_Load(object sender, EventArgs e)
        {
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
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
