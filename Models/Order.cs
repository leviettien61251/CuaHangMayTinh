using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Models
{
    public class Order
    {
        private int maDH;
        private int maKH;
        private int maNV;
        private string ngayDatHang;
        private float tongTien;
        private int trangThai;
        private string phuongThucThanhToan;
        private string diaChiGiaoHang;
        private string ngayXuatHD;
        private float thueVAT;
        private float tongThanhToan;

        public Order(int maDH, int maKH, int maNV, string ngayDatHang, float tongTien, int trangThai, string phuongThucThanhToan, string diaChiGiaoHang, string ngayXuatHD, float thueVAT, float tongThanhToan)
        {
            this.maDH = maDH;
            this.maKH = maKH;
            this.maNV = maNV;
            this.ngayDatHang = ngayDatHang;
            this.tongTien = tongTien;
            this.trangThai = trangThai;
            this.phuongThucThanhToan = phuongThucThanhToan;
            this.diaChiGiaoHang = diaChiGiaoHang;
            this.ngayXuatHD = ngayXuatHD;
            this.thueVAT = thueVAT;
            this.tongThanhToan = tongThanhToan;
        }

        public Order(DataRow row)
        {
            this.maDH = (int)row["MaDH"];
            this.maKH = (int)row["MaKH"];
            this.maNV = (int)row["MaNV"];
            this.ngayDatHang = row["NgayDatHang"].ToString();
            this.tongTien = (float)row["TongTien"];
            this.trangThai = (int)row["TrangThai"];
            this.phuongThucThanhToan = row["PhuongThucThanhToan"].ToString();
            this.diaChiGiaoHang = row["DiaChiGiaoHang"].ToString();
            this.ngayXuatHD = row["NgayXuatHD"].ToString();
            this.thueVAT = (float)row["ThueVAT"];
            this.tongThanhToan = (float)row["TongThanhToan"];
        }

        public int MaDH { get => maDH; private set => maDH = value; }
        public int MaKH { get => maKH; private set => maKH = value; }
        public int MaNV { get => maNV; private set => maNV = value; }
        public string NgayDatHang { get => ngayDatHang; private set => ngayDatHang = value; }
        public float TongTien { get => tongTien; private set => tongTien = value; }
        public int TrangThai { get => trangThai; private set => trangThai = value; }
        public string PhuongThucThanhToan { get => phuongThucThanhToan; private set => phuongThucThanhToan = value; }
        public string DiaChiGiaoHang { get => diaChiGiaoHang; private set => diaChiGiaoHang = value; }
        public string NgayXuatHD { get => ngayXuatHD; private set => ngayXuatHD = value; }
        public float ThueVAT { get => thueVAT; private set => thueVAT = value; }
        public float TongThanhToan1 { get => tongThanhToan; private set => tongThanhToan = value; }
    }
}
