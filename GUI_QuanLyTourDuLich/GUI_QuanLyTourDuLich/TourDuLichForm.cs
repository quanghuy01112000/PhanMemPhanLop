using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyTourDuLich
{
    public partial class TourDuLichForm : Form
    {
        public TourDuLichForm()
        {
            InitializeComponent();
            loadListView();
        }

        private void TourDuLichForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlLoaiTour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBLoaiTour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvTour.View = View.Details;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void loadListView()
        {
            lvTour.FullRowSelect = true;
            lvTour.GridLines = true;


            lvTour.Columns.Add("Mã Tour").Width=70;
            lvTour.Columns.Add("Tên Tour").Width=140;
            lvTour.Columns.Add("Loại hình").Width=120;
            lvTour.Columns.Add("Địa điểm").Width=150;
            lvTour.Columns.Add("Thành tiền").Width=110;
            lvTour.Columns.Add("Trạng thái").Width =100;


            ListViewItem item1 = new ListViewItem();
            item1.Text = "MATO001";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Hà Nội 3 ngày 2 đêm" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Du lịch tham quan" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Ba đình, Hà nội" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "10.000.000" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đã kết thúc" });

            ListViewItem item2 = new ListViewItem();
            item2.Text = "MATO002";
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Vịnh Hạ Long 2 ngày 1 đêm" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Du lịch tham quan" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Vịnh Hạ Long" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "20.000.000" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đang diễn ra" });

            ListViewItem item3 = new ListViewItem();
            item3.Text = "MATO003";
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Món ăn xứ Huế" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Du lịch ẩm thực" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Huế mộng mơ" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "7.000.000" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Đang lên kế hoạch" });

            lvTour.Items.Add(item1);
            lvTour.Items.Add(item2);
            lvTour.Items.Add(item3);
        }

    

        private void lvTour_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lvTour_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietTourForm chiTietTour = new ChiTietTourForm();
            chiTietTour.ShowDialog();
        }
    }
}
