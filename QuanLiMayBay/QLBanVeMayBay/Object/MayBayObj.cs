using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanVeMayBay.Object
{
	class MayBayObj
    {
		string ma, ten, diemdi, diemden;

        public string DiemDi
        {
            get { return diemdi; }
            set { diemdi = value; }
        }
	   
        public string DiemDen
        {
            get { return diemden; }
            set { diemden = value; }
        }
        int dongia, soluong;
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public string TenMayBay
        {
            get { return ten; }
            set { ten = value; }
        }

        public string MaMayBay
        {
            get { return ma; }
            set { ma = value; }
        }

    }

}
