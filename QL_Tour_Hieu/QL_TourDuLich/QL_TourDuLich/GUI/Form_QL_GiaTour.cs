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

namespace QL_TourDuLich.GUI
{
    public partial class Form_QL_GiaTour : Form
    {
        DAO_QL_GiaTour daoGiaTour = new DAO_QL_GiaTour();
        BUS_QL_GiaTour busGiaTour = new BUS_QL_GiaTour();
        List<GiaTour> listSearchGiaTour = new List<GiaTour>();
        int SelectedIndex = 0;
        static int maGiaTourMax = 0;

        public Form_QL_GiaTour()
        {
            InitializeComponent();
        }


        private void Form_QL_GiaTour_Load(object sender, EventArgs e)
        {
            //load bảng tour
            dgvGiaTour.AutoGenerateColumns = false;//chặn tự tạo cột
            busGiaTour.getDSGiaTour();
            dgvGiaTour.DataSource = BUS_QL_GiaTour.listGiaTour;//bus.getDanhsachTour();
            dgvGiaTour.Columns["MaGia"].DataPropertyName = "MaGia";
            dgvGiaTour.Columns["MaTour"].DataPropertyName = "MaTour";
            dgvGiaTour.Columns["ThanhTien"].DataPropertyName = "ThanhTien";
            dgvGiaTour.Columns["NgayBatDau"].DataPropertyName = "ThoiGianBatDau";
            dgvGiaTour.Columns["NgayKetThuc"].DataPropertyName = "ThoiGianKetThuc";
            dgvGiaTour.AllowUserToOrderColumns = true;
            //load combobox

            //
            maGiaTourMax = busGiaTour.getMaGiaTourMax();
        }
        private void dgvGiaTour_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndex = dgvGiaTour.CurrentCell.RowIndex;
            GiaTour tmp = null;
            try
            {
                tmp = dgvGiaTour.CurrentRow.DataBoundItem as GiaTour;
                txtMaGia.Text = tmp.MaGia.ToString();
                txtMaTour.Text = tmp.MaTour.ToString();
                txtThanhTien.Text = tmp.ThanhTien.ToString();
                dateTimePickerStart.Text = tmp.ThoiGianBatDau.ToString();
                dateTimePickerEnd.Text = tmp.ThoiGianKetThuc.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaGia.Text = "";
            txtMaTour.Text = "";
            txtThanhTien.Text = "";
            dateTimePickerStart.Text = "";
            dateTimePickerEnd.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            maGiaTourMax = busGiaTour.getMaGiaTourMax();
            GiaTour giaTour = new GiaTour();
            maGiaTourMax++;
            giaTour.MaGia = maGiaTourMax;
            giaTour.MaTour = 1;
            double tien = double.Parse(txtThanhTien.Text);
            giaTour.ThanhTien = tien;
            DateTime start = DateTime.Now;
            giaTour.ThoiGianBatDau = start;
            DateTime end = DateTime.Now;
            giaTour.ThoiGianKetThuc = end;
            busGiaTour.themGiaTour(giaTour);
            dgvGiaTour.DataSource = null;
            dgvGiaTour.DataSource = BUS_QL_GiaTour.listGiaTour;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaTour giaTour = dgvGiaTour.CurrentRow.DataBoundItem as GiaTour;
            giaTour.MaTour = 1;
            double tien = double.Parse(txtThanhTien.Text);
            giaTour.ThanhTien = tien;
            DateTime start = DateTime.Now;
            giaTour.ThoiGianBatDau = start;
            DateTime end = DateTime.Now;
            giaTour.ThoiGianKetThuc = end;
            dgvGiaTour.Update();
            dgvGiaTour.Refresh();
            busGiaTour.suaGiaTour(giaTour);
        }
        private void txtTimKiemGiaTour_TextChanged(object sender, EventArgs e)
        {
            String textSearch = txtTimKiemGiaTour.Text.ToLower();
            listSearchGiaTour = busGiaTour.timKiemGiaTour(textSearch);
            if (txtTimKiemGiaTour.Text == "")
            {
                dgvGiaTour.DataSource = BUS_QL_GiaTour.listGiaTour;
            }
            else
            {
                dgvGiaTour.DataSource = listSearchGiaTour;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá giá tour không?", "Bạn đang xoá giá tour", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                GiaTour giaTour = dgvGiaTour.CurrentRow.DataBoundItem as GiaTour;
                if (busGiaTour.xoaGiaTour(giaTour))
                {
                    maGiaTourMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvGiaTour.DataSource = null;
                    dgvGiaTour.DataSource = BUS_QL_GiaTour.listGiaTour;
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


        

        
    }
}
