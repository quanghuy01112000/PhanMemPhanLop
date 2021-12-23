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
    public partial class Form_QL_Doan : Form
    {
        public static Form_QL_Doan instance;
        int selectedIndex;
        DoanDuLich doan = new DoanDuLich();
        public Form_QL_Doan()   
        {
            InitializeComponent();
            load();
            instance = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void load()
        {
            doan.loadLists();
            var table = from t in doan.lstDoanDuLich select new
            {
                TenTour= t.TourDuLich.TenTour,
                MaTour = t.MaTour,
                MaDoan= t.MaDoan,
                NgayKH = t.NgayKhoiHanh,
                NgayKT =t.NgayKetThuc,
                DoanhThu = t.DoanhThu
            } ;
            
            dgvData.DataSource =table.ToList();
            dgvData.Columns[0].HeaderText = "Tên Tour";
            dgvData.Columns[2].HeaderText = "Mã Tour";
            dgvData.Columns[1].HeaderText = "Mã Đoàn";
            dgvData.Columns[3].HeaderText = "Ngày Khởi Hành";
            dgvData.Columns[4].HeaderText = "Ngày Kết Thúc";
            dgvData.Columns[5].HeaderText = "Doanh Thu";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_QL_Doan_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchItemsCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form_QL_ChiTietDoan chiTiet = new Form_QL_ChiTietDoan();
            chiTiet.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvData.Rows[selectedIndex];
            int maDoan = (int)row.Cells[1].Value;
            DoanDuLich test = doan.getItem(maDoan);
            
            Form_QL_ChiTietDoan chiTiet =new Form_QL_ChiTietDoan(doan.getItem(maDoan));
            chiTiet.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
