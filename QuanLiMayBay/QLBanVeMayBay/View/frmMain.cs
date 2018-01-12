using QLBanVeMayBay.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanVeMayBay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimk f = new frmDoimk();
            f.ShowDialog();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void máyBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMayBay f = new frmMayBay();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            f.ShowDialog();
        }

        private void tổngHợpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXuatds f = new FrmXuatds();
            f.ShowDialog();
        }

        private void theoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimkiemkh f = new FrmTimkiemkh();
            f.ShowDialog();
        }

        private void theoChuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimkiem f = new FrmTimkiem();
            f.ShowDialog();
        }

        private void thôngTinNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGioithieu f = new frmGioithieu();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien ss = new frmNhanVien();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMayBay  ss = new frmMayBay();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKhachHang ss = new frmKhachHang();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHoaDon ss = new FrmHoaDon();
            ss.Show();
        }

        private void trởVềĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangnhap ss1 = new frmDangnhap();
            ss1.Show();
        }
    }
}
