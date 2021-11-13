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
using QL_TourDuLich.Common;


namespace QL_TourDuLich
{
    public partial class Form_QL_Tour : Form
    {
        DAO_QL_Tour DAO_Tour = new DAO_QL_Tour();
        TourDuLich bus = new TourDuLich();
        List<TourDuLich> lstTours = null;
        int SelectedIndex = 0;
        public Form_QL_Tour()
        {
            InitializeComponent();
        }
        public void AddBinding()//để tự động in dữ liệu từ bảng ra txt
        {
            txtMaTour.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "MaTour"));
            txtTenTour.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "TenTour"));
            txtLoaiHinh.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "TenLoaiTour"));
            txtTrangThai.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "TrangThai", true));
            txtThanhTien.DataBindings.Add(new Binding("Text", dgvTour.DataSource, "giaTour", true));
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
            suaTour();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            themTour();

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

        private void themTour()
        {
            TourDuLich db = new TourDuLich(txtMaTour.Text, txtTenTour.Text,
                                        txtTrangThai.Text, Int32.Parse(txtThanhTien.Text) * 1.0, txtLoaiHinh.Text);
            lstTours.Add(db);
            bus.ThemTour(db);
        }

        private void suaTour()
        {
            TourDuLich db = new TourDuLich();
            int index = dgvTour.CurrentCell.RowIndex;
            db.MaTour = txtMaTour.Text;
            db.TenTour = txtTenTour.Text;
            db.TrangThai = txtTrangThai.Text;
            db.tenLoaiHinh = txtLoaiHinh.Text;
            db.giaTour = Int32.Parse(txtThanhTien.Text) * 1.0;
            bus.suaTour(db, index);

            Console.WriteLine(db.TrangThai);

        }

        private void xoaTour()
        {
            int index = dgvTour.CurrentCell.RowIndex;
            TourDuLich tourCanXoa = lstTours[index];
            //bus.xoaTour(index); // cho nay sai ne

            lstTours.RemoveAt(index);
            //dgvTour
            dgvTour.DataSource = null;
            dgvTour.DataSource = lstTours;
           

        }

        private void TxtMaTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            xoaTour();
            dgvTour.Update();
            dgvTour.Refresh();

            Console.WriteLine(lstTours.Count);
        }
    }
}
