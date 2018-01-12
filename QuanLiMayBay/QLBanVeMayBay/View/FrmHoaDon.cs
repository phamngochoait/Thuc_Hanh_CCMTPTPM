using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanVeMayBay.Control;
using QLBanVeMayBay.Object;

namespace QLBanVeMayBay.View
{
    public partial class FrmHoaDon : Form
    {
        HoaDonCtrl hdCtr = new HoaDonCtrl();
        ChiTietCtrl ctCtr = new ChiTietCtrl();
        MayBayCtr hhctr = new MayBayCtr();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;


    }
}
