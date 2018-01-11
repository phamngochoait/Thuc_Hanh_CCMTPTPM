using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanVeMayBay.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, sdt, matkhau;
        string namsinh;

        public string MaNhanVien
        {
            get { return ma; }
            set { ma = value; }
        }

        public string TenNhanVien
        {
            get { return ten; }
            set { ten = value; }
        }

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string NamSinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        public NhanVienObj() { }
        public NhanVienObj(string ma,string ten,string gioitinh,string namsinh,string diachi,string sdt,string matkhau)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.namsinh = namsinh;
            this.sdt = sdt;
            this.matkhau = matkhau;
        }


        public string DienThoai { get; set; }
    }
}
