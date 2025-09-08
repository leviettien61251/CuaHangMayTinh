using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Models
{
    public class Customer
    {
        private int maKH;

        private string hoTen;

        private string email;

        private string soDienThoai;

        private string diaChi;

        private string ngayDangKy;

        private int diemTichTuy;

        private int maTK;


        public Customer() { }

        public Customer(int maKH, string hoTen, string email, string soDienThoai, string diaChi, string ngayDangKy, int diemTichTuy, int maTK)
        {
            this.maKH = maKH;

            this.hoTen = hoTen;

            this.email = email;

            this.soDienThoai = soDienThoai;

            this.diaChi = diaChi;

            this.ngayDangKy = ngayDangKy;

            this.diemTichTuy = diemTichTuy;

            this.maTK = maTK;

        }

        public Customer(DataRow row)
        {
            this.maKH = (int)row["MaKH"];

            this.hoTen = row["HoTen"].ToString();

            this.email = row["Email"].ToString();

            this.soDienThoai = row["SoDienThoai"].ToString();

            this.diaChi = row["DiaChi"].ToString();

            this.ngayDangKy = row["NgayDangKy"].ToString();

            this.diemTichTuy = (int)row["DiemTichLuy"];

            this.maTK = (int)row["MaTK"];
        }

        public int MaKH { get => maKH; private set => maKH = value; }

        public string HoTen { get => hoTen; private set => hoTen = value; }

        public string Email { get => email; private set => email = value; }

        public string SoDienThoai { get => soDienThoai; private set => soDienThoai = value; }

        public string DiaChi { get => diaChi; private set => diaChi = value; }

        public string NgayDangKy { get => ngayDangKy; private set => ngayDangKy = value; }

        public int DiemTichTuy { get => diemTichTuy; private set => diemTichTuy = value; }

        public int MaTK { get => maTK; private set => maTK = value; }

    }
}
