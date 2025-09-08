using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Models
{
    public class Employee
    {
        private int maNV;

        private string hoTen;

        private string email;

        private string soDienThoai;

        private string diaChi;

        private string ngayVaoLam;

        private float luongCoBan;

        private int trangThai;

        private int maCV;

        private int maTK;

        public Employee() { }

        public Employee(int maNV, string hoTen, string email, string soDienThoai, string diaChi, string ngayVaoLam, float luongCoBan, int trangThai, int maCV, int maTK)
        {
            this.maNV = maNV;

            this.hoTen = hoTen;

            this.email = email;

            this.soDienThoai = soDienThoai;

            this.diaChi = diaChi;

            this.ngayVaoLam = ngayVaoLam;

            this.luongCoBan = luongCoBan;

            this.trangThai = trangThai;

            this.maCV = maCV;

            this.maTK = maTK;
        }

        public Employee(DataRow row)
        {
            this.maNV = (int)row["MaNV"];

            this.hoTen =  row["HoTen"].ToString();

            this.email =  row["Email"].ToString();

            this.soDienThoai =  row["SoDienThoai"].ToString();

            this.diaChi =  row["DiaChi"].ToString();

            this.ngayVaoLam =  row["NgayVaoLam"].ToString();

            this.luongCoBan =  (int)row["LuongCoBan"];

            this.trangThai =  (int)row["TrangThai"];

            this.maCV =  (int)row["MaCV"];

            this.maTK =  (int)row["MaTK"];
        }

        public int MaNV { get => maNV; private set => maNV = value; }

        public string HoTen { get => hoTen; private set => hoTen = value; }

        public string Email { get => email; private set => email = value; }

        public string SoDienThoai { get => soDienThoai; private set => soDienThoai = value; }

        public string DiaChi { get => diaChi; private set => diaChi = value; }

        public string NgayVaoLam { get => ngayVaoLam; private set => ngayVaoLam = value; }

        public float LuongCoBan { get => luongCoBan; private set => luongCoBan = value; }

        public int TrangThai { get => trangThai; private set => trangThai = value; }

        public int MaCV { get => maCV; private set => maCV = value; }

        public int MaTK { get => maTK; private set => maTK = value; }
    }
}
