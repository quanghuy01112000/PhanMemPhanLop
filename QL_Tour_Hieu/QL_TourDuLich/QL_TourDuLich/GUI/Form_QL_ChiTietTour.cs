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
    public partial class Form_QL_ChiTietTour : Form
    {
        TourDuLich tourDL;
        TourDuLich bus = new TourDuLich();
        int countDiaDiem=0;
        public Form_QL_ChiTietTour(TourDuLich tour)
        {
            InitializeComponent();
            tourDL = tour;
            txtMaTour.Text = tour.MaTour.ToString();
            txtTenTour.Text = tour.TenTour;
            txtTenLoaiHinh.Text = tour.tenLoaiTour;
            txtDacDiem.Text = tour.DacDiem;
            txtTrangThai.Text = tour.TrangThai;
            txtGia.Text = tour.giaTour.ToString();
            dtpNgayBatDau.Text = tour.NgayBatDau.ToString();
            dtpNgayKetThuc.Text = tour.NgayKetThuc.ToString();

            dgvDiaDiem.AutoGenerateColumns = false;//chặn tự tạo cột
            dgvDiaDiem.DataSource=tour.dsDiaDiem.ToList();
            dgvDiaDiem.Columns["TenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dgvDiaDiem.Columns["ThuTu"].DataPropertyName = "ThuTu";
            cbbTenDiaDiem.DataSource = bus.getDanhSachTenDiaDiem();
            countDiaDiem = tourDL.dsDiaDiem.Count();

            dgvGiaTour.AutoGenerateColumns = false;
            dgvGiaTour.DataSource = bus.getGiabyMaTour(tour.MaTour);
            dgvGiaTour.Columns["NgayBatDauGia"].DataPropertyName = "ThoiGianBatDau";
            dgvGiaTour.Columns[0].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvGiaTour.Columns["NgayKetThucGia"].DataPropertyName = "ThoiGianKetThuc";
            dgvGiaTour.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvGiaTour.Columns["GiaTien"].DataPropertyName = "ThanhTien";
            markGiaTourHienTai();
        }
        public void markGiaTourHienTai()
        {
            int index=0;
            foreach (DataGridViewRow row in dgvGiaTour.Rows){
                if (bus.isGiaTourHienTai(row.Cells[0].Value, row.Cells[1].Value))
                    index = row.Index;
            }
            dgvGiaTour.Rows[0].DefaultCellStyle.BackColor = Color.Red;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        { 
            //đổi trên lstTour
            tourDL.NgayBatDau = dtpNgayBatDau.Value;
            tourDL.NgayKetThuc = dtpNgayKetThuc.Value;
            tourDL.DacDiem = txtDacDiem.Text;
            //update csdl
            bus.suaChiTietTour(tourDL);
            MessageBox.Show("lưu thành công", "thông báo", MessageBoxButtons.OK);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int Ma = bus.getMaDiaDiem(cbbTenDiaDiem.Text);
            countDiaDiem++;
            //update csdl
            bus.themDiaDiem(tourDL.MaTour,Ma,countDiaDiem);
            //sua form
            ThongTinDiaDiem tt = new ThongTinDiaDiem();
            tt.TenDiaDiem = cbbTenDiaDiem.Text;
            tt.ThuTu = countDiaDiem;
            tourDL.dsDiaDiem.Add(tt);
            dgvDiaDiem.DataSource = null;
            dgvDiaDiem.DataSource = tourDL.dsDiaDiem.ToList();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Ma = bus.getMaDiaDiem(tourDL.dsDiaDiem.Last().TenDiaDiem);
            tourDL.dsDiaDiem.RemoveAt(countDiaDiem-1);
            //update csdl
            bus.xoaDiaDiem(tourDL.MaTour,Ma,countDiaDiem);
            countDiaDiem--;
            //sua form
            dgvDiaDiem.DataSource = null;
            dgvDiaDiem.DataSource = tourDL.dsDiaDiem.ToList();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
