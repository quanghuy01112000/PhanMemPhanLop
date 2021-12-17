using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TourDuLich.DAO;
using QL_TourDuLich.BUS;
using QL_TourDuLich.GUI;

namespace QL_TourDuLich.GUI
{
    public partial class Form_QL_KhachHang : Form
    {
        DAO_QL_KhachHang daoKhachHang = new DAO_QL_KhachHang();
        KhachHang busKhachHang = new KhachHang();
        List<KhachHang> listSearchKhachHang = new List<KhachHang>();
        int SelectedIndex = 0;
        static int maKhachHangMax = 0;

        public Form_QL_KhachHang()
        {
            InitializeComponent();
        }

        private void Form_QL_KhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.AutoGenerateColumns = false;
            busKhachHang.getDSKhachHang();
            dgvKH.DataSource = KhachHang.listKhachHang;
            dgvKH.Columns["MaKH"].DataPropertyName = "MaKhachHang";
            dgvKH.Columns["HoTen"].DataPropertyName = "HoTen";
            dgvKH.Columns["SoCMND"].DataPropertyName = "soCMND";
            dgvKH.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dgvKH.Columns["sdt"].DataPropertyName = "SDT";
            dgvKH.Columns["QuocTich"].DataPropertyName = "QuocTich";
            dgvKH.Columns["GioiTinh"].DataPropertyName = "GioiTinh";

            comboBoxGioiTinh.DataSource = KhachHang.lstGioiTinh;

            dgvKH.AllowUserToOrderColumns = true;

            maKhachHangMax = busKhachHang.getMaKhachHangMax();
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndex = dgvKH.CurrentCell.RowIndex;
            KhachHang tmp = null;
            try
            {
                tmp = dgvKH.CurrentRow.DataBoundItem as KhachHang;
                txtMaKhachHang.Text = tmp.MaKhachHang.ToString();
                txtTenKhachHang.Text = tmp.HoTen.ToString();
                textCMND.Text = tmp.soCMND.ToString();
                txtDiaChi.Text = tmp.DiaChi.ToString();
                textSDT.Text = tmp.SDT.ToString();
                textQuocTich.Text = tmp.QuocTich.ToString();
                comboBoxGioiTinh.Text = tmp.GioiTinh.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void txtTimKiemKhachHang_TextChanged(object sender, EventArgs e)
        {
            String textSearch = txtTimKiemKhachHang.Text.ToLower();
            listSearchKhachHang = busKhachHang.timKiemKhachHang(textSearch);
            if(txtTimKiemKhachHang.Text == "")
            {
                dgvKH.DataSource = KhachHang.listKhachHang;
            }
            else
            {
                dgvKH.DataSource = listSearchKhachHang;
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            textCMND.Text = "";
            txtDiaChi.Text = "";
            textSDT.Text = "";
            textQuocTich.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            maKhachHangMax = busKhachHang.getMaKhachHangMax();
            KhachHang khachHang = new KhachHang();
            maKhachHangMax++;
            khachHang.MaKhachHang = maKhachHangMax;
            khachHang.HoTen = txtTenKhachHang.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.soCMND = textCMND.Text;
            khachHang.GioiTinh = comboBoxGioiTinh.Text;
            khachHang.QuocTich = textQuocTich.Text;
            khachHang.SDT = textSDT.Text;
            busKhachHang.themKhachHang(khachHang);
            dgvKH.DataSource = null;
            dgvKH.DataSource = KhachHang.listKhachHang;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = dgvKH.CurrentRow.DataBoundItem as KhachHang;
            khachHang.HoTen = txtTenKhachHang.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.soCMND = textCMND.Text;
            khachHang.GioiTinh = comboBoxGioiTinh.Text;
            khachHang.QuocTich = textQuocTich.Text;
            khachHang.SDT = textSDT.Text;
            dgvKH.Update();
            dgvKH.Refresh();
            busKhachHang.suaKhachHang(khachHang);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá khách hàng không?", "Bạn đang xoá khách hàng", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                KhachHang khachHang = dgvKH.CurrentRow.DataBoundItem as KhachHang;
                if (busKhachHang.xoaKhachHang(khachHang))
                {
                    maKhachHangMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvKH.DataSource = null;
                    dgvKH.DataSource = KhachHang.listKhachHang;
                }
                else
                {
                    MessageBox.Show("Không thể xoá!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Hủy xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKimTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
