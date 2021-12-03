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
        TourDuLich bus = new TourDuLich();
        public Form_QL_ChiTietTour(TourDuLich tour)
        {
            InitializeComponent();
            txtMaTour.Text = tour.MaTour;
            txtTenTour.Text = tour.TenTour;
            txtTenLoaiHinh.Text = tour.tenLoaiTour;
            txtDacDiem.Text = tour.DacDiem;
            txtTrangThai.Text = tour.TrangThai;
            txtGia.Text = tour.giaTour.ToString();
            dgvDiaDiem.AutoGenerateColumns = false;//chặn tự tạo cột
            dgvDiaDiem.DataSource=tour.dsDiaDiem.ToList();
            dgvDiaDiem.Columns["TenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dgvDiaDiem.Columns["ThuTu"].DataPropertyName = "ThuTu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
