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
            txtNgayBatDau.Text = tour.NgayBatDau.ToString();
            txtNgayKetThuc.Text = tour.NgayKetThuc.ToString();

            dgvDiaDiem.AutoGenerateColumns = false;//chặn tự tạo cột
            dgvDiaDiem.DataSource=tour.dsDiaDiem.ToList();
            dgvDiaDiem.Columns["TenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dgvDiaDiem.Columns["ThuTu"].DataPropertyName = "ThuTu";
            cbbTenDiaDiem.DataSource = bus.getDanhSachTenDiaDiem();
            countDiaDiem = tourDL.dsDiaDiem.Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        { 
            //update csdl
            bus.suaChiTietTour(tourDL);
            //đổi trên form
            tourDL.DacDiem = txtDacDiem.Text;
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
    }
}
