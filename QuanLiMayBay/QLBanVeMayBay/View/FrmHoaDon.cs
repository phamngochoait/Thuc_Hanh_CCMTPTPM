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
	public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            bingding();
            txtNgayLap.Enabled = false;


        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource, "MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
        }
	  private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSHH.DataSource = dt;

            }
            catch
            {
                dtgvDSHH.DataSource = null;
            }
        }

        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            txtNhanVien.Enabled = e;
            cmbKhachHang.Enabled = e;
            btnAdd.Enabled = !e;
            btnDel.Enabled = !e;
            btnPrint.Enabled = !e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btncham.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbHH.Enabled = e;
            txtSL.Enabled = e;
        }

        private void LoadcmbKhachHang()
        {
            KhachHangCtr khctr = new KhachHangCtr();
            cmbKhachHang.DataSource = khctr.GetData();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.SelectedIndex = 0;
        }

        private void LoadcmbHH()
        {
            MayBayCtr hhctr = new MayBayCtr();
            cmbHH.DataSource = hhctr.GetData();
            cmbHH.DisplayMember = "TenMB";
            cmbHH.ValueMember = "MaMB";

        }

        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = txtNhanVien.Text.Trim();
            hdObj.KhachHang = cmbKhachHang.SelectedValue.ToString();
        }
        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString()) + SL;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }
        private void clearData()
        {
            txtMa.Text = "";
            txtNhanVien.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadcmbKhachHang();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Dis_Enl(true);
            clearData();
            LoadcmbHH();
            LoadcmbKhachHang();
            dtDSCT.Rows.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("HangHoa");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");
        }
        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;

        }
	
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmHoaDon_Load(sender, e);
        }
        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhctr.GetData("Where MaMB = '" + cmbHH.SelectedValue.ToString() + "' and SoLuong>= " + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HoaDonObj hdObj = new HoaDonObj();
            addData(hdObj);
            if (hdCtr.AddData(hdObj))
            {
                //DataTable dt = new System.Data.DataTable();
                if (ctCtr.AddData(dtDSCT) && hhctr.UpdSL(dtDSCT))
                //if (ctCtr.AddData(dt))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FrmHoaDon_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                FrmHoaDon_Load(sender, e);
            else
                return;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang đc nâng cấp");

        }


    }
}
