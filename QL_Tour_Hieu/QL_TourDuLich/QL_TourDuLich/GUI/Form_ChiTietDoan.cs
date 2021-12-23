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
    public partial class Form_ChiTietDoan : Form
    {
        int indexKH=0;
        int indexCP=0;
        int indexNV=0;
        TourDuLich t = new TourDuLich();
        
        public static Form_ChiTietDoan instance;
        public static DoanDuLich bus =new DoanDuLich();
        int state;
        public Form_ChiTietDoan(DoanDuLich doan)
        {
            InitializeComponent();
            bus = doan;
            state = 0;
            load();
            instance = this;
        }
        public Form_ChiTietDoan()
        {
            InitializeComponent();
            state = 1;
            load();
            
            instance = this;
        }

        private void Form_QL_ChiTietDoan_Load(object sender, EventArgs e)
        {

        }

        private void load()
        {
            t.getDanhsachTour();
            foreach (TourDuLich i in TourDuLich.lstTours)
            {
                cbxMaTour.Items.Add(i.MaTour);
            }
            foreach (LoaiChiPhi j in Form_Doan.doan.lstLoaiChiPhi)
            {
                cbxChiPhi.Items.Add(j.TenLoaiChiPhi);
            }

            cbxChiPhi.SelectedIndex = 0;
            cbxMaTour.SelectedIndex = 0;

            if (state == 0)
            {
                bus.getTour1((int)bus.MaTour);
                txtTenTour.Text = bus.TourDuLich.TenTour.ToString();
                
                txtDoanhThu.Text = bus.DoanhThu.ToString();
                dtpNgayBatDau.Value = (DateTime)bus.NgayKhoiHanh;
                dtpNgayKetThuc.Value = (DateTime)bus.NgayKetThuc;
                txtMaDoan.Text = bus.MaDoan.ToString();
                dgvChiPhi.DataSource = bus.ChiPhis.ToList();
                dgvKhachHang.DataSource = bus.KhachHangs.ToList();
                dgvNhanVien.DataSource = bus.PhanBoNhanVien_Doan.ToList();
                dgvNhanVien.DataSource = Form_Doan.doan.lstNhanVien;

            }
            else
            {
                dtpNgayBatDau.Value =DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                var d = (from i in Form_Doan.doan.lstDoanDuLich
                         select i.MaDoan).LastOrDefault();
                txtMaDoan.Text = (d+1).ToString();
            }




            cbxMaTour.Items.Add(7);







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
                Form_Doan.instance.tmp = doan;
                Form_Doan.instance.suaDoan();
            }
            else
            {
                DoanDuLich doan = new DoanDuLich();
                doan.MaDoan = int.Parse(txtMaDoan.Text);
                doan.MaTour = cbxMaTour.SelectedIndex + 1;
                foreach (TourDuLich i in TourDuLich.lstTours)
                {
                    if(i.MaTour == doan.MaTour) doan.TourDuLich = i;
                }
                doan.DoanhThu = int.Parse(txtDoanhThu.Text);
                doan.NgayKhoiHanh = dtpNgayBatDau.Value;
                doan.NgayKetThuc = dtpNgayKetThuc.Value;
                doan.MaDoan = int.Parse(txtMaDoan.Text);
                doan.ChiPhis = bus.ChiPhis;
                doan.KhachHangs = bus.KhachHangs;
                doan.PhanBoNhanVien_Doan = bus.PhanBoNhanVien_Doan;
                Form_Doan.instance.tmp = doan;
                Form_Doan.instance.themDoan();
            }
            this.Close();
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
            if (state == 0)
            {
                
                cp.MaDoan = bus.MaDoan;
                cp.MaLoaiChiPhi = cbxChiPhi.SelectedIndex + 1;
                cp.SoTien = int.Parse(txtGiaTri.Text);
                var maCP = (from i in bus.lstChiPhi
                            select i.MaChiPhi).LastOrDefault();
                cp.MaChiPhi = maCP + 1;
                bus.ChiPhis.Add(cp);
                dgvChiPhi.DataSource = null;
                dgvChiPhi.DataSource = bus.ChiPhis.ToList();
            }
            else {
                cp.MaDoan = int.Parse(txtMaDoan.Text);
                cp.MaLoaiChiPhi = cbxChiPhi.SelectedIndex + 1;
                cp.SoTien = int.Parse(txtGiaTri.Text);
                var maCP = (from i in Form_Doan.doan.lstChiPhi
                            select i.MaChiPhi).LastOrDefault();
                cp.MaChiPhi = maCP + 1;
                bus.ChiPhis.Add(cp);
                dgvChiPhi.DataSource = null;
                dgvChiPhi.DataSource = bus.ChiPhis.ToList();
            }
        }

        private void cbxChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenTour.Text = TourDuLich.lstTours[(int)cbxMaTour.SelectedIndex+1].TenTour;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvChiPhi.Rows[indexCP];
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
            Form_ThemNV nv = new Form_ThemNV();
            nv.Show();
            

        }
        public void chonNV(NhanVien nv)
        {
            bus.lstNhanVien.Add(nv);
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource= bus.lstNhanVien.ToList();
        }

        private void dgvChiPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexCP = e.RowIndex;
        }
        public void chonKH(int maKhachHang)
        {
            bus.KhachHangs.Add(bus.getKhachHang(maKhachHang));
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bus.KhachHangs.ToList();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.Rows[indexKH];
            int maKH = (int)row.Cells[0].Value;
            xoaKH(maKH);
        }
        private void xoaKH(int maKH)
        {
            bus.KhachHangs.Remove(bus.getKhachHang(maKH));
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bus.KhachHangs;
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexKH = e.RowIndex;
        }

        private void cbxMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexNV=e.RowIndex;
        }
    }
}
