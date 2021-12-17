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
        List<String> LstDiaDiem;
        public Form_QL_ChiTietTour(TourDuLich tour)
        {
            InitializeComponent();
            tourDL = tour;//hứng tour lại để sửa 
            txtMaTour.Text = tour.MaTour.ToString();
            txtTenTour.Text = tour.TenTour;
            txtTenLoaiHinh.Text = tour.tenLoaiTour;
            txtDacDiem.Text = tour.DacDiem;
            txtTrangThai.Text = tour.TrangThai;
            txtGia.Text = tour.giaTour.ToString();
            dtpNgayBatDau.Text = tour.NgayBatDau.ToString();
            dtpNgayKetThuc.Text = tour.NgayKetThuc.ToString();

            dgvDiaDiem.AutoGenerateColumns = false;//chặn tự tạo cột
            dgvDiaDiem.DataSource=tour.dsDiaDiem.ToList();
            dgvDiaDiem.Columns["TenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dgvDiaDiem.Columns["ThuTu"].DataPropertyName = "ThuTu";
            LstDiaDiem = bus.getDanhSachTenDiaDiem();
            //bỏ những tên địa điểm ở combobox đã có trong bảng
            foreach (var i in tour.dsDiaDiem)
            {
                if (LstDiaDiem.Contains(i.TenDiaDiem))
                    LstDiaDiem.Remove(i.TenDiaDiem);
            }
            cbbTenDiaDiem.DataSource = LstDiaDiem;
            countDiaDiem = tourDL.dsDiaDiem.Count();

            dgvGiaTour.AutoGenerateColumns = false;
            dgvGiaTour.DataSource = bus.getGiabyMaTour(tour.MaTour);
            dgvGiaTour.Columns["NgayBatDauGia"].DataPropertyName = "ThoiGianBatDau";
            dgvGiaTour.Columns[0].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvGiaTour.Columns["NgayKetThucGia"].DataPropertyName = "ThoiGianKetThuc";
            dgvGiaTour.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvGiaTour.Columns["GiaTien"].DataPropertyName = "ThanhTien";

            dgvDoan.AutoGenerateColumns = false;
            dgvDoan.DataSource = tour.dsDoanTour;
            dgvDoan.Columns["NgayBatDau"].DataPropertyName = "ngayBd";
            dgvDoan.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDoan.Columns["NgayKetThuc"].DataPropertyName = "ngayKt";
            dgvDoan.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDoan.Columns["MaDoan"].DataPropertyName = "maDoan";
            dgvDoan.Columns["TenDoan"].DataPropertyName = "tenDoan";
        }
        private void dgvGiaTour_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGiaTour.Rows)
            {
                DateTime ngayBatDau = (DateTime) row.Cells[0].Value;
                DateTime ngayKetThuc = (DateTime)row.Cells[1].Value;
                if (bus.isGiaTourHienTai(ngayBatDau, ngayKetThuc))
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        { 
            //đổi trên lstTour
            tourDL.NgayBatDau = dtpNgayBatDau.Value;
            tourDL.NgayKetThuc = dtpNgayKetThuc.Value;
            tourDL.DacDiem = txtDacDiem.Text;
            //update csdl
            bus.suaChiTietTour(tourDL);
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
            //xóa tên địa điểm đã add khỏi combobox
            LstDiaDiem.Remove(tt.TenDiaDiem);
            cbbTenDiaDiem.DataSource = null;
            cbbTenDiaDiem.DataSource = LstDiaDiem;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ten = tourDL.dsDiaDiem.Last().TenDiaDiem;
            int Ma = bus.getMaDiaDiem(ten);
            tourDL.dsDiaDiem.RemoveAt(countDiaDiem-1);
            //update csdl
            bus.xoaDiaDiem(tourDL.MaTour,Ma,countDiaDiem);
            countDiaDiem--;
            //sua form
            dgvDiaDiem.DataSource = null;
            dgvDiaDiem.DataSource = tourDL.dsDiaDiem.ToList();
            //thêm tên địa điểm đã xóa vào combobox
            LstDiaDiem.Add(ten);
            cbbTenDiaDiem.DataSource = null;
            cbbTenDiaDiem.DataSource = LstDiaDiem;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnThemGia_Click(object sender, EventArgs e)
        {
            //new Form giá tour
            //xong truyền mã tour qua để tìm kiếm và chỉnh sửa 
            Form_QL_GiaTour GTour = new Form_QL_GiaTour();
            GTour.ShowDialog();
        }

        private void cbbTenDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
