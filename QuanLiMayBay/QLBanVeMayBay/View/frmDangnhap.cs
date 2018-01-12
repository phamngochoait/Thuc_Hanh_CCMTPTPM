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

namespace QLBanVeMayBay.View
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WIN-PC\\SQLEXPRESS;database=BanVeMayBay;User=sa;pwd=123");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login Where USERNAME='" + textBox1.Text + "' and PASSWORD = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                frmMain ss = new frmMain();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại Username hoặc Password");
            }

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            this.Close();
        }
    }
}
