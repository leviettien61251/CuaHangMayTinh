using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangMayTinh.Models
{
    public class Category
    {
        public Category() { }

        public Category(int _maDanhMuc, string _tenDanhMuc, int _danhMucCha, string _moTa)
        {
            this.MaDanhMuc = _maDanhMuc;

            this.TenDanhMuc = _tenDanhMuc;

            this.DanhMucCha = _danhMucCha;

            this.MoTa = _moTa;
        }

        public Category(DataRow row)
        {
            this.MaDanhMuc = (int)row["MaDanhMuc"];

            this.TenDanhMuc = row["TenDanhMuc"].ToString();

            //this.DanhMucCha = (int)row["DanhMucCha"];

            this.MoTa = row["MoTa"].ToString();
        }

        private int _maDanhMuc;

        private string _tenDanhMuc;

        private int _danhMucCha;

        private string _moTa;

        public int MaDanhMuc { get => _maDanhMuc; private set => _maDanhMuc = value; }

        public string TenDanhMuc { get => _tenDanhMuc; private set => _tenDanhMuc = value; }

        public int DanhMucCha { get => _danhMucCha; private set => _danhMucCha = value; }

        public string MoTa { get => _moTa; private set => _moTa = value; }
    }
}
