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
    public partial class Form_ThemKhach : Form
    {
        DoanDuLich bus;
        public Form_ThemKhach instance;
        int selectedIndex=0;
        public Form_ThemKhach(DoanDuLich doan)
        {
            InitializeComponent();
            bus = doan;
            load();
            
            instance = this;
        }

        private void Form_ThemKhach_Load(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.Rows[selectedIndex];
            int maKhachHang = (int)row.Cells[0].Value;
            Form_ChiTietDoan.instance.chonKH(maKhachHang);
            this.Close();
        }

        private void load()
        {
            List<KhachHang> data = new List<KhachHang>();
            int c;
            foreach(KhachHang i in Form_Doan.doan.lstKhachHang)
            {
                c = 0;
                foreach(KhachHang j in bus.KhachHangs)
                {
                    if (i.MaKhachHang == j.MaKhachHang) 
                    c++;
                }
                if(c==0) data.Add(i);
            }

            
            dgvKhachHang.DataSource =data;
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
