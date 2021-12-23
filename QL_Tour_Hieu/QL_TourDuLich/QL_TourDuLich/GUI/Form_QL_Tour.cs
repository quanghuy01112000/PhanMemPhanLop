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
        List<TourDuLich> lstSearch = new List<TourDuLich>();
        static int MaTourLonNhat = 0;
        //List<String> lstTenLoai = null;
        int SelectedIndex=0;
        public Form_QL_Tour()
        {
            InitializeComponent(); 
        }

        private void Form_QL_Tour_Load(object sender, EventArgs e)
        {
            //load bảng tour
            dgvTour.AutoGenerateColumns = false;//chặn tự tạo cột
            bus.getDanhsachTour();
            dgvTour.DataSource = TourDuLich.lstTours;//bus.getDanhsachTour();
            dgvTour.Columns["MaTour"].DataPropertyName = "MaTour";
            dgvTour.Columns["TenTour"].DataPropertyName = "TenTour";
            dgvTour.Columns["TenLoaiTour"].DataPropertyName = "tenLoaiTour";
            dgvTour.Columns["TrangThai"].DataPropertyName = "TrangThai";
            dgvTour.Columns["Gia"].DataPropertyName = "giaTour";
            dgvTour.AllowUserToOrderColumns = true;
            //load combobox
            cbbLoaiHinh.DataSource = bus.getDSTenLoaiHinh();
            cbLocLoaiTour.DataSource = bus.getDSTenLoaiHinh();
            cbbTrangThai.DataSource = TourDuLich.lstTrangThai;
            cbLocTrangThai.DataSource = TourDuLich.lstTrangThai;
            //
            MaTourLonNhat = bus.getMaTourLonNhat();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTour.DataSource = TourDuLich.lstTours;
        }

        private void btnChiTietTour_Click(object sender, EventArgs e)
        {
            TourDuLich tour = dgvTour.CurrentRow.DataBoundItem as TourDuLich;
            Form_QL_ChiTietTour CtTour = new Form_QL_ChiTietTour(tour);
            CtTour.ShowDialog();
        }

        private void dgvTour_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndex = dgvTour.CurrentCell.RowIndex;
            TourDuLich tam=null;
            //khi xóa phần tử cuối lỗi IndexOutOfRangeException ko bít sửa sao nên bắt try catch 
            try
            {
                tam = dgvTour.CurrentRow.DataBoundItem as TourDuLich;
                txtMaTour.Text = tam.MaTour.ToString();
                txtTenTour.Text = tam.TenTour;
                cbbLoaiHinh.Text = tam.tenLoaiTour;
                cbbTrangThai.Text = tam.TrangThai;
                txtDacDiem.Text = tam.DacDiem;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenTour.Text == "" || txtDacDiem.Text == "")
            {
                MessageBox.Show("Nhập vào sai!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }
            TourDuLich tour = dgvTour.CurrentRow.DataBoundItem as TourDuLich;
            tour.TenTour = txtTenTour.Text;
            tour.tenLoaiTour = cbbLoaiHinh.Text;
            tour.TrangThai = cbbTrangThai.Text;
            tour.MaLoaiHinh = bus.getMaLoaiHinh(cbbLoaiHinh.Text);
            tour.DacDiem = txtDacDiem.Text;
            dgvTour.Update();
            dgvTour.Refresh();
            //update csdl
            bus.suaTour(tour);
        }
        //ok nè
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenTour.Text == "" || txtDacDiem.Text == "")
            {
                MessageBox.Show("Nhập vào sai!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }
            TourDuLich tour = new TourDuLich();
            MaTourLonNhat++;
            tour.MaTour = MaTourLonNhat;
            tour.TenTour = txtTenTour.Text;
            tour.tenLoaiTour = cbbLoaiHinh.Text;
            tour.DacDiem = txtDacDiem.Text;
            tour.MaLoaiHinh = bus.getMaLoaiHinh(cbbLoaiHinh.Text);
            tour.HienThi = true;
            tour.giaTour = 2000;
            tour.TrangThai = cbbTrangThai.Text;
            //them trong csdl + lstTour
            bus.themTour(tour);
            dgvTour.DataSource = null;
            dgvTour.DataSource = TourDuLich.lstTours;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaTour.Text = "";
            txtTenTour.Text = "";
            txtDacDiem.Text = "";
            cbbLoaiHinh.Text = "";
            cbbTrangThai.Text = "";
        }
        //xóa phần tử cuối bị lỗi 
        private void btnXoa_Click(object sender, EventArgs e)
        { 
            var rs=MessageBox.Show("Bạn có muốn xóa tour không", "Bạn đang xoá tour", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                MaTourLonNhat--;
                TourDuLich tour = dgvTour.CurrentRow.DataBoundItem as TourDuLich;
                //xoa trong csdl + lstTour
                bus.xoaTour(tour);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                dgvTour.DataSource = null;
                dgvTour.DataSource = TourDuLich.lstTours;

            }
            else
            {
                MessageBox.Show("Hủy xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }


        private void txtTimKimTour_TextChanged(object sender, EventArgs e)
        { 
            String textTim = txtTimKimTour.Text.ToLower();
            lstSearch = bus.timKiem(textTim);
            if (txtTimKimTour.Text == "")
            {
                dgvTour.DataSource = TourDuLich.lstTours;
            }
            else
            {
                dgvTour.DataSource = lstSearch;
            }
        }
        //cái này để kiểm tra 1 số thứ 
        private void btnLoc_Click(object sender, EventArgs e)
        {
            String loaiTour = cbLocLoaiTour.Text.ToLower();
            String trangThai = cbLocTrangThai.Text.ToLower();
            lstSearch = bus.locTour(loaiTour,trangThai);
            dgvTour.DataSource = lstSearch;
        }
        private void txtTenTour_TextChanged(object sender, EventArgs e)
        {
            if (txtTenTour.Text.Equals(""))
            {
                toolTipNull.Active = true;
                txtTenTour.BackColor = Color.Red;
                txtTenTour.ForeColor = Color.White;
            }
            else
            {
                toolTipNull.Active = false;
                txtTenTour.BackColor = Color.White;
                txtTenTour.ForeColor = Color.Black;
            }
        }

        
    }
}
