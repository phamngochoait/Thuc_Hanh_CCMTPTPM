using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanVeMayBay.View
{
    public partial class frmDoimk : Form
    {
        public frmDoimk()
        {
            InitializeComponent();
        }

        private void frmDoimk_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection con = new SqlConnection("server=WIN-PC\\SQLEXPRESS;database=BanVeMayBay;User=sa;pwd=123");

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(*) From Login Where USERNAME='" + txtUser.Text + "' and PASSWORD = '" + txtMkc.Text + "'", con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
           if(txtMkm.Text == txtRe.Text)
           {
            
               SqlDataAdapter cc = new SqlDataAdapter("update Login set PASSWORD='" + txtMkm.Text + "'where USERNAME='"+txtUser+"'and PASSWORD='"+txtMkc.Text+"' " ,con);
               DataTable dt1 = new DataTable();
               cc.Fill(dt1);
               MessageBox.Show("Cập nhật Mật Khẩu mới thành công" ,"message",MessageBoxButtons.OK,MessageBoxIcon.Information);

           }
                else
           {
               errorProvider1.SetError(txtMkm, "Không trùng khớp");
               errorProvider1.SetError(txtRe,"Không trùng khớp");

           }

            }
            else
            {
           errorProvider1.SetError(txtUser,"Sai tên Username");
           errorProvider1.SetError(txtMkc, "Sai  Pass");

            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain ss = new frmMain();
            ss.Show();
        }
    }
}
