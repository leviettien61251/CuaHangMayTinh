using CuaHangMayTinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class ProductController
    {

        private static ProductController instance;

        public static ProductController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductController();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ProductController() {}

        

        public List<Product> GetProduct()
        {
            string script = @"EXEC usp_GetSanPham";

            List<Product> list = new List<Product>();

            DataTable dt = DataProvider.Instance.ExecuteQuery(script);

            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list; 
        }

        public void LoadProduct(DataGridView dataGridViewName)
        {
            string script = @"EXEC usp_GetSanPham";
            dataGridViewName.DataSource = DataProvider.Instance.ExecuteQuery(script);
        }

        public void AddProduct()
        {

        }
        
    }
}
