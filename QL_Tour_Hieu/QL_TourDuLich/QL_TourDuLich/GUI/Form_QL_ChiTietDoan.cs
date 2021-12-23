using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.GUI
{
    public partial class Form_QL_ChiTietDoan : Form
    {
        int selectedIndex;
        public static Form_QL_ChiTietDoan instance;
        public DoanDuLich bus;
        int state;
        public Form_QL_ChiTietDoan(DoanDuLich doan)
        {
            InitializeComponent();
            bus = doan;
            load();
            instance = this;
            state = 0;
            
            
        }
        public Form_QL_ChiTietDoan()
        {
            InitializeComponent();
            state = 1;
            
        }

        private void Form_QL_ChiTietDoan_Load(object sender, EventArgs e)
        {

        }

        private void load()
        {
            TourDuLich t = new TourDuLich();
            t.getDanhsachTour();
            foreach (TourDuLich i in TourDuLich.lstTours)
            {
                cbxMaTour.Items.Add(i.MaTour);
            }
            cbxMaTour.SelectedIndex = 0;
            txtTenTour.Text = bus.TourDuLich.TenTour.ToString();
            cbxMaTour.SelectedIndex = (int)bus.MaTour-1;
            txtDoanhThu.Text = bus.DoanhThu.ToString();
            dtpNgayBatDau.Value = (DateTime)bus.NgayKhoiHanh;
            dtpNgayKetThuc.Value = (DateTime)bus.NgayKetThuc;
            txtMaDoan.Text = bus.MaDoan.ToString();
            dgvChiPhi.DataSource = bus.ChiPhis.ToList();
            dgvKhachHang.DataSource = bus.KhachHangs.ToList();
            dgvNhanVien.DataSource = bus.PhanBoNhanVien_Doan.ToList();
            bus.loadLists();
           
                foreach(LoaiChiPhi j in bus.lstLoaiChiPhi)
                {
                        cbxChiPhi.Items.Add(j.TenLoaiChiPhi);
                }
            
            cbxChiPhi.SelectedIndex = 0;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            DoanDuLich tmp = bus;
            Form_ThemKhach them = new Form_ThemKhach(tmp);
            them.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                DoanDuLich doan = new DoanDuLich();
                doan.TourDuLich.TenTour = txtTenTour.Text;
                doan.MaTour = int.Parse(cbxMaTour.SelectedText);
                doan.DoanhThu = int.Parse(txtDoanhThu.Text);
                doan.NgayKhoiHanh = dtpNgayBatDau.Value;
                doan.NgayKetThuc = dtpNgayKetThuc.Value;
                doan.MaDoan = int.Parse(txtMaDoan.Text);
                doan.ChiPhis = bus.ChiPhis;
                doan.KhachHangs = bus.KhachHangs;
                doan.PhanBoNhanVien_Doan = bus.PhanBoNhanVien_Doan;
                bus.suaDoan(doan);
            }
            else
            {
                DoanDuLich doan = new DoanDuLich();
                doan.TourDuLich.TenTour = txtTenTour.Text.ToString();
                doan.MaTour = int.Parse(cbxMaTour.SelectedText);
                doan.DoanhThu = int.Parse(txtDoanhThu.Text);
                doan.NgayKhoiHanh = dtpNgayBatDau.Value;
                doan.NgayKetThuc = dtpNgayKetThuc.Value;
                doan.MaDoan = int.Parse(txtMaDoan.Text);
                doan.ChiPhis = bus.ChiPhis;
                doan.KhachHangs = bus.KhachHangs;
                doan.PhanBoNhanVien_Doan = bus.PhanBoNhanVien_Doan;
                bus.themDoan(doan);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemChiPhi_Click(object sender, EventArgs e)
        {
            ChiPhi cp = new ChiPhi();
            cp.MaDoan = bus.MaDoan;
            cp.MaLoaiChiPhi = cbxChiPhi.SelectedIndex+1;
            cp.SoTien = int.Parse(txtGiaTri.Text);
            var maCP = (from i in bus.lstChiPhi
                       select i.MaChiPhi).LastOrDefault();
            cp.MaChiPhi = maCP+1;
            bus.ChiPhis.Add(cp);
            dgvChiPhi.DataSource = null;
            dgvChiPhi.DataSource = bus.ChiPhis.ToList();
            
        }

        private void cbxChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvChiPhi.Rows[selectedIndex];
            int maChiPhi = (int)row.Cells[0].Value;
            ChiPhi tmp = new ChiPhi();
            foreach (ChiPhi i in bus.ChiPhis)
            {
                if (i.MaChiPhi == maChiPhi) { tmp = i; break; }
            }
            bus.ChiPhis.Remove(tmp);
            dgvChiPhi.DataSource = null;
            dgvChiPhi.DataSource= bus.ChiPhis.ToList();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[selectedIndex];
            int maNV = (int)row.Cells[0].Value;
            

        }
        public void themNV(NhanVien nv)
        {
            bus.lstNhanVien.Add(nv);
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource= bus.lstNhanVien.ToList();
        }

        private void dgvChiPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }
        public void chonKH(int maKhachHang)
        {
            bus.KhachHangs.Add(bus.getKhachHang(maKhachHang));
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bus.KhachHangs.ToList();
        }
    }
}
