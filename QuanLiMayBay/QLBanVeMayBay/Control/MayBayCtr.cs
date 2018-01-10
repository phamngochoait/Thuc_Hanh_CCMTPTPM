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
	   
        public bool UpdSL(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = hhMod.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][3].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][3].ToString()) - int.Parse(dt.Rows[i][3].ToString());
                        if (!hhMod.UpdSL(dthh.Rows[j][0].ToString(), SLmoi))
                            return false;
                        break;
                    }
                }

            }
            return true;
        }

    }

}
