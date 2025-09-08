using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Models
{
    public class Supplier
    {
        private int maNCC;

        private string tenNCC;

        private string diaChi;

        private string soDienThoai;

        private string email;

        private int maTK;

        public Supplier()
        {
        }

        public Supplier(int maNCC, string tenNCC, string diaChi, string soDienThoai, string email, int maTK)
        {
            this.MaNCC = maNCC;

            this.TenNCC = tenNCC;

            this.DiaChi = diaChi;

            this.SoDienThoai = soDienThoai;

            this.Email = email;

            this.MaTK = maTK;
        }

        public Supplier(DataRow row)
        {
            this.MaNCC = (int)row["MaNCC"];

            this.TenNCC = row["TenNCC"].ToString();

            this.DiaChi = row["DiaChi"].ToString();

            this.SoDienThoai = row["SoDienThoai"].ToString();

            this.Email = row["Email"].ToString();

            this.MaTK = (int)row["MaTK"];
        }

        public int MaNCC { get => maNCC; private set => maNCC = value; }

        public string TenNCC { get => tenNCC; private set => tenNCC = value; }

        public string DiaChi { get => diaChi; private set => diaChi = value; }

        public string SoDienThoai { get => soDienThoai; private set => soDienThoai = value; }

        public string Email { get => email; private set => email = value; }

        public int MaTK { get => maTK; private set => maTK = value; }
    }
}
