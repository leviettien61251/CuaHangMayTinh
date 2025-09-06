using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Models
{
    public class Product
    {
        public Product() { }

        public Product(
            string maSP,
            string tenSP,
            int maDanhMuc,
            int maNCC,
            string moTa,
            int baoHanh,
            float giaNhap,
            float giaBan,
            int soLuongTon,
            int trangThai,
            string ngayTao)
        {
            this._maSP = maSP;

            this._tenSP = tenSP;

            this._maDanhMuc = maDanhMuc;

            this._maNCC = maNCC;

            this._moTa = moTa;

            this._baoHanh = baoHanh;

            this._giaNhap = giaNhap;

            this._giaBan = giaBan;

            this._soLuongTon = soLuongTon;

            this._trangThai = trangThai;

            this._ngayTao = ngayTao;
        }

        public Product(DataRow row)
        {
            this._maSP = row["MaSP"].ToString();

            this._tenSP = row["TenSP"].ToString();

            this._maDanhMuc = (int)row["MaDanhMuc"];

            this._maNCC = (int)row["maNCC"];

            this._moTa = row["moTa"].ToString();

            this._baoHanh = (int)row["baoHanh"];

            this._giaNhap = (float)Convert.ToDouble(row["giaNhap"].ToString());

            this._giaBan = (float)Convert.ToDouble(row["giaBan"].ToString());

            this._soLuongTon = (int)row["soLuongTon"];

            this._trangThai = (int)row["trangThai"];

            this._ngayTao = row["ngayTao"].ToString();
        }

        private string _maSP;

        private string _tenSP;

        private int _maDanhMuc;

        private int _maNCC;

        private string _moTa;

        private int _baoHanh;

        private float _giaNhap;

        private float _giaBan;

        private int _soLuongTon;

        private int _trangThai;

        private string _ngayTao;

        public string MaSP { get => _maSP; private set => _maSP = value; }

        public string TenSP { get => _tenSP; private set => _tenSP = value; }

        public int MaDanhMuc { get => _maDanhMuc; private set => _maDanhMuc = value; }

        public int MaNCC { get => _maNCC; private set => _maNCC = value; }

        public string MoTa { get => _moTa; private set => _moTa = value; }

        public int BaoHanh { get => _baoHanh; private set => _baoHanh = value; }

        public float GiaNhap { get => _giaNhap; private set => _giaNhap = value; }

        public float GiaBan { get => _giaBan; private set => _giaBan = value; }

        public int SoLuongTon { get => _soLuongTon; private set => _soLuongTon = value; }

        public int TrangThai { get => _trangThai; private set => _trangThai = value; }

        public string NgayTao { get => _ngayTao; private set => _ngayTao = value; }
    }
}
