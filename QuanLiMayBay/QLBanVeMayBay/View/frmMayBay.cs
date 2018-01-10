using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanVeMayBay.Object;
using QLBanVeMayBay.Control;

namespace QLBanVeMayBay.View
{
    public partial class frmMayBay : Form
    {
        MayBayCtr hhCtr = new MayBayCtr();
        private int flagLuu = 0;
        public frmMayBay()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = hhCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDS.DataSource, "MaMB");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dtgvDS.DataSource, "TenMB");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dtgvDS.DataSource, "DonGia");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dtgvDS.DataSource, "SoLuong");
            //cmbDiemdi.DataBindings.Clear();
            //cmbDiemdi.DataBindings.Add("Text", dtgvDS.DataSource, "DiemDi");
            //cmbDiemden.DataBindings.Clear();
            //cmbDiemden.DataBindings.Add("Text", dtgvDS.DataSource, "DiemDen");
        }
        private void clearData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDonGia.Text = "";
            txtSL.Text = "";
            //loadCMBDiemdi();
            //loadCMBDiemden();
         

        }
     

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtDonGia.Enabled = e;
            txtSL.Enabled = e;
            //cmbDiemdi.Enabled = e;

            //cmbDiemden.Enabled = e;

            //btnNhapHang.Enabled = !e;
        }
        //private void loadCMBDiemdi()
        //{
        //    cmbDiemdi.Items.Clear();
        //    cmbDiemdi.Items.Add("Sài Gòn");
        //    cmbDiemdi.Items.Add("Hà Nội");
        //    cmbDiemdi.Items.Add("Huế");
        //    cmbDiemdi.Items.Add("Đà Nẵng");
        //    cmbDiemdi.Items.Add("Hải Phòng");
        //    cmbDiemdi.Items.Add("Cam Ranh");
        //    cmbDiemdi.Items.Add("Yên Bái");
        //    cmbDiemdi.Items.Add("Cà Mau");
        //}
        //private void loadCMBDiemden()
        //{
        //    cmbDiemden.Items.Clear();
        //    cmbDiemden.Items.Add("Sài Gòn");
        //    cmbDiemden.Items.Add("Hà Nội");
        //    cmbDiemden.Items.Add("Huế");
        //    cmbDiemden.Items.Add("Đà Nẵng");
        //    cmbDiemden.Items.Add("Hải Phòng");
        //    cmbDiemden.Items.Add("Cam Ranh");
        //    cmbDiemden.Items.Add("Yên Bái");
        //    cmbDiemden.Items.Add("Cà Mau");
        //}


        private void addData(MayBayObj hh)
        {
            hh.MaMayBay = txtMa.Text.Trim();
            hh.DonGia = int.Parse(txtDonGia.Text.Trim());
            hh.SoLuong = int.Parse(txtSL.Text.Trim());
            hh.TenMayBay = txtTen.Text.Trim();
            hh.DiemDi = cmbDiemdi.Text.Trim();
            //hh.DiemDen = cmbDiemden.Text.Trim();



        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmMayBay_Load(sender, e);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MayBayObj hhObj = new MayBayObj();

            addData(hhObj);
            
            if (flagLuu == 0)
            {
                if (hhCtr.AddData(hhObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flagLuu == 1)
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nhập hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmMayBay_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmMayBay_Load(sender, e);
            else
                return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMayBay_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = hhCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            //flagLuu = 2;
            //btnNhapHang.Enabled = false;
            //btnThem.Enabled = false;
            //btnXoa.Enabled = false;
            //btnSua.Enabled = false;
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            //txtSL.Enabled = true;
        }
    }
}
