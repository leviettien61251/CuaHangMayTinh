using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Controllers
{
    public class RevenueController
    {
        private static RevenueController instance;

        public static RevenueController Instance { get => instance; private set => instance = value; }

        public RevenueController() { }


    }
}
