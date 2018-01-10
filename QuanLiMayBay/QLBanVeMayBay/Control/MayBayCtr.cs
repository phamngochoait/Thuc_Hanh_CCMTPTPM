using QLBanVeMayBay.Model;
using QLBanVeMayBay.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanVeMayBay.Control
{
	class MayBayCtr
    {
        MayBayMod hhMod = new MayBayMod();
        public DataTable GetData()
        {
            return hhMod.GetData();
        }
	   public DataTable GetData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
	   public bool AddData(MayBayObj hhObj)
        {
            return hhMod.AddData(hhObj);
        }
	   public bool UpdData(MayBayObj hhObj)
        {
            return hhMod.UpdData(hhObj);
        }

    }

}
