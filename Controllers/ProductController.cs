using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Controllers
{
    public class ProductController
    {


        private ProductController instance;

        public ProductController Instance
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

        string script = @"";
    }
}
