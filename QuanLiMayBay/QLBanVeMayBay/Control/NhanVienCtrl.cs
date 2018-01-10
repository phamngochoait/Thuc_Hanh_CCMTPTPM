using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanVeMayBay.Model;
using QLBanVeMayBay.Object;
using System.Data;

namespace QLBanVeMayBay.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }

    }
}
