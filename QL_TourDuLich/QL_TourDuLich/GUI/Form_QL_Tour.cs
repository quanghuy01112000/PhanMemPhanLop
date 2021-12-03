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
using QL_TourDuLich.DAO;
using QL_TourDuLich.GUI;

namespace QL_TourDuLich
{
    public partial class Form_QL_Tour : Form
    {
        DAO_QL_Tour DAO_Tour = new DAO_QL_Tour();
        TourDuLich bus = new TourDuLich();
        List<TourDuLich> lstTours = null;
        int SelectedIndex=0;
        public Form_QL_Tour()
        {
            InitializeComponent(); 
        }
        public void AddBinding()//để tự động in dữ liệu từ bảng ra txt
        {
            txtMaTour.DataBindings.Add(new Binding("Text",dgvTour.DataSource,"MaTour"));
            txtTenTour.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "TenTour"));
            txtLoaiHinh.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "TenLoaiTour"));
            txtTrangThai.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "TrangThai"));
            txtThanhTien.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "giaTour"));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void Form_QL_Tour_Load(object sender, EventArgs e)
        {
            dgvTour.AutoGenerateColumns = false;//chặn tự tạo cột
            lstTours = bus.getDanhsachTour();
            dgvTour.DataSource = lstTours;//bus.getDanhsachTour();
            dgvTour.Columns["MaTour"].DataPropertyName = "MaTour";
            dgvTour.Columns["TenTour"].DataPropertyName = "TenTour";
            dgvTour.Columns["TenLoaiTour"].DataPropertyName = "tenLoaiTour";//chổ này khác nè ngó kỹ
            dgvTour.Columns["TrangThai"].DataPropertyName = "TrangThai";
            dgvTour.Columns["Gia"].DataPropertyName = "giaTour";
            dgvTour.AllowUserToOrderColumns = true;
            AddBinding();
        }

        private void btnChiTietTour_Click(object sender, EventArgs e)
        {
            TourDuLich tam = new TourDuLich();
            tam = lstTours.ElementAt(SelectedIndex);
            Form_QL_ChiTietTour CtTour = new Form_QL_ChiTietTour(tam);
            CtTour.ShowDialog();
        }

        private void dgvTour_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndex = dgvTour.CurrentCell.RowIndex;
        }
    }
    }
