using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanVeMayBay.View
{
    public partial class FrmXuatds : Form
    {
        public FrmXuatds()
        {
            InitializeComponent();
        }

        private void FrmXuatds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tb_HoaDon' table. You can move, or remove it, as needed.
            this.tb_HoaDonTableAdapter.Fill(this.dataSet1.tb_HoaDon);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
