using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBanVeMayBay.Control;
using QLBanVeMayBay.Model;

namespace QLBanVeMayBay.View
{
    public partial class FrmTimkiem : Form
    {
       
        //MayBayCtr hhCtr = new MayBayCtr();
        //ConnectToSQL con = new ConnectToSQL();
        //SqlCommand cmd = new SqlCommand();
        //DataTable dtTim;
        //DataView dvTim;
        //SqlDataAdapter adapter;
        public FrmTimkiem()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection("server=WIN-PC\\SQLEXPRESS;database=BanVeMayBay;User=sa;pwd=123");

//SqlConnection con = new SqlConnection("Data Source=.\SQLEXPRESS; ;Initial Catalog = BanVeMayBay ; User = sa; Password=123");
        private void FrmTimkiem_Load(object sender, EventArgs e)
        {
            //DataTable dtDS1 = new System.Data.DataTable();
            //dtDS1 = hhCtr.GetData();
            //dgvvData.DataSource = dtDS1;
            ////binhding();
            ////            //StrCon = @"Data Source=.\SQLEXPRESS; ;Initial Catalog = BanVeMayBay ; User = sa; Password=123";

            //adapter = new SqlDataAdapter("select * from tb_Maybay", con1);
            //dtTim = new DataTable("tb_MayBay");
            //adapter.Fill(dtTim);
            ////dvTim = new DataView()
            //dvTim = new DataView(dtTim);
            //dgvvData.DataSource = dvTim;

        }

        //public void timkiem(string n)
        //{
        //string tk = "Select * from tb_MayBay where TenMB Like '%"+n+"'%";

        //}


        private void button1_Click(object sender, EventArgs e)
        {
            //string le=textBox1.Text;
            //            //dgvvData.DataSource =
            ////dgvvData.DataSource = hhCtr.GetData("select * from Tb_MayBay where TenMB like '%" + textBox1.Text + "%'");
            //dvTim.RowFilter = "TenMB like '" + le + "%'";
            //dgvvData.DataSource = dvTim;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dgvvData.DataSource = hhCtr.GetData("select * from Tb_MayBay where TenMB like '%" + textBox1.Text + "%'");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tb_MayBay Where TenMB LIKE '"+textBox1.Text+"%'", con1);
            DataTable data = new DataTable();
            sda.Fill(data);
            dgvvData.DataSource = data;
        }
    }
}
