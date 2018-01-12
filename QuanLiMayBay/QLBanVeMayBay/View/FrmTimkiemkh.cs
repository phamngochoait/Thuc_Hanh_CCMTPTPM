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
using QLBanVeMayBay.Model;
using System.Data.SqlClient;

namespace QLBanVeMayBay.View
{
    public partial class FrmTimkiemkh : Form
    {
        public FrmTimkiemkh()
        {
            InitializeComponent();
        }
        SqlConnection con2 = new SqlConnection("server=WIN-PC\\SQLEXPRESS;database=BanVeMayBay;User=sa;pwd=123");

        private void FrmTimkiemkh_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tb_KhachHang Where TenKH LIKE '" + textBox1.Text + "%'", con2);
            DataTable data = new DataTable();
            sda.Fill(data);
            dgvvData1.DataSource = data;
        }
    }
}
