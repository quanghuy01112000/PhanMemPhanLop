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
    public partial class Form_QL_Khac : Form
    {
        DAO_QL_LoaiHinh daoLoaiHinh = new DAO_QL_LoaiHinh();
        BUS_QL_LoaiHinh busLoaiHinh = new BUS_QL_LoaiHinh();
        List<LoaiHinhDuLich> listSearchLoaiHinh = new List<LoaiHinhDuLich>();
        int SelectedIndexLoaiHinh = 0;
        static int maLoaiHinhMax = 0;

        DAO_QL_DiaDiem daoDiaDiem = new DAO_QL_DiaDiem();
        BUS_QL_DiaDiem busDiaDiem = new BUS_QL_DiaDiem();
        List<DiaDiem> listSearchDiaDiem = new List<DiaDiem>();
        int SelectedIndexDiaDiem = 0;
        static int maDiaDiemMax = 0;

        DAO_QL_LoaiChiPhi daoLoaiChiPhu = new DAO_QL_LoaiChiPhi();
        BUS_QL_LoaiChiPhi busLoaiChiPhi = new BUS_QL_LoaiChiPhi();
        List<LoaiChiPhi> listSearchLoaiChiPhi = new List<LoaiChiPhi>();
        int SelectedIndexLoaiChiPhi = 0;
        static int maLoaiChiPhiMax = 0;

        DAO_QL_NhanVien daoNhanVien = new DAO_QL_NhanVien();
        BUS_QL_NhanVien busNhanVien = new BUS_QL_NhanVien();
        List<NhanVien> listSearchNhanVien = new List<NhanVien>();
        int SelectedIndexNhanVien = 0;
        static int maNhanVienMax = 0;
        public Form_QL_Khac()
        {
            InitializeComponent();
        }

        private void Form_QL_Khac_Load(object sender, EventArgs e)
        {
            dgv_LoaiHinh.AutoGenerateColumns = false;
            busLoaiHinh.getDSLoaiHinh();
            dgv_LoaiHinh.DataSource = BUS_QL_LoaiHinh.listLoaiHinh;
            dgv_LoaiHinh.Columns["MaLoaiHinh"].DataPropertyName = "MaLoaiHinh";
            dgv_LoaiHinh.Columns["TenLoaiHinh"].DataPropertyName = "TenLoaiHinh";
            dgv_LoaiHinh.AllowUserToOrderColumns = true;
            maLoaiHinhMax = busLoaiHinh.getMaLoaiHinhMax();

            dgvDiaDiem.AutoGenerateColumns = false;
            busDiaDiem.getDSDiaDiem();
            dgvDiaDiem.DataSource = BUS_QL_DiaDiem.listDiaDiem;
            dgvDiaDiem.Columns["MaDiadiem"].DataPropertyName = "MaDiaDiem";
            dgvDiaDiem.Columns["TenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dgvDiaDiem.AllowUserToOrderColumns = true;
            maDiaDiemMax = busDiaDiem.getMaDiaDiemMax();

            dgvLoaiChiPhi.AutoGenerateColumns = false;
            busLoaiChiPhi.getDSLoaiChiPhi();
            dgvLoaiChiPhi.DataSource = BUS_QL_LoaiChiPhi.listLoaiChiPhi;
            dgvLoaiChiPhi.Columns["MaLoaiChiPhi"].DataPropertyName = "MaLoaiChiPhi";
            dgvLoaiChiPhi.Columns["TenLoaiChiPhi"].DataPropertyName = "TenLoaiChiPhi";
            dgvLoaiChiPhi.AllowUserToOrderColumns = true;
            maLoaiChiPhiMax = busLoaiChiPhi.getMaChiPhiMax();

            dgvNhanVien.AutoGenerateColumns = false;
            busNhanVien.getDSNhanVien();
            dgvNhanVien.DataSource = BUS_QL_NhanVien.listNhanVien;
            dgvNhanVien.Columns["MaNhanVien"].DataPropertyName = "MaNhanVien";
            dgvNhanVien.Columns["TenNhanVien"].DataPropertyName = "TenNhanVien";
            dgvNhanVien.AllowUserToOrderColumns = true;
            maNhanVienMax = busNhanVien.getMaNhanVienMax();
        }

        private void dgv_LoaiHinh_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndexLoaiHinh = dgv_LoaiHinh.CurrentCell.RowIndex;
            LoaiHinhDuLich tmp = null;
            try
            {
                tmp = dgv_LoaiHinh.CurrentRow.DataBoundItem as LoaiHinhDuLich;
                textBox_MaLoaiHinh.Text = tmp.MaLoaiHinh.ToString();
                textBox_TenLoaiHinh.Text = tmp.TenLoaiHinh.ToString();
            } catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void btn_DatLai_LoaiHinh_Click(object sender, EventArgs e)
        {
            textBox_MaLoaiHinh.Text = "";
            textBox_TenLoaiHinh.Text = "";
        }

        private void btn_Them_LoaiHinh_Click(object sender, EventArgs e)
        {
            maLoaiHinhMax = busLoaiHinh.getMaLoaiHinhMax();
            LoaiHinhDuLich loaiHinh = new LoaiHinhDuLich();
            maLoaiHinhMax++;
            loaiHinh.MaLoaiHinh = maLoaiHinhMax;
            loaiHinh.TenLoaiHinh = textBox_TenLoaiHinh.Text;
            busLoaiHinh.themLoaiHinh(loaiHinh);
            dgv_LoaiHinh.DataSource = null;
            dgv_LoaiHinh.DataSource = BUS_QL_LoaiHinh.listLoaiHinh;
        }

        private void btn_Sua_LoaiHinh_Click(object sender, EventArgs e)
        {
            LoaiHinhDuLich loaiHinh = dgv_LoaiHinh.CurrentRow.DataBoundItem as LoaiHinhDuLich;
            loaiHinh.TenLoaiHinh = textBox_TenLoaiHinh.Text;
            dgv_LoaiHinh.Update();
            dgv_LoaiHinh.Refresh();
            busLoaiHinh.suaLoaiHinh(loaiHinh);
        }

        private void btn_Xoa_LoaiHinh_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá loại hình không?", "Bạn đang xoá loại hình", MessageBoxButtons.YesNo);
            if(messageXoa == DialogResult.Yes)
            {
                LoaiHinhDuLich loaiHinh = dgv_LoaiHinh.CurrentRow.DataBoundItem as LoaiHinhDuLich;
                if (busLoaiHinh.xoaLoaiHinh(loaiHinh))
                {
                    maLoaiHinhMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgv_LoaiHinh.DataSource = null;
                    dgv_LoaiHinh.DataSource = BUS_QL_LoaiHinh.listLoaiHinh;
                } 
                else
                {
                    MessageBox.Show("Không thể xoá!","Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Hủy xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void textBox_TimKiemLoaiHinh_TextChanged(object sender, EventArgs e)
        {
            String textSearch = textBox_TimKiemLoaiHinh.Text.ToLower();
            listSearchLoaiHinh = busLoaiHinh.timKiemLoaiHinh(textSearch);
            if(textBox_TimKiemLoaiHinh.Text == "")
            {
                dgv_LoaiHinh.DataSource = BUS_QL_LoaiHinh.listLoaiHinh;
            } else
            {
                dgv_LoaiHinh.DataSource = listSearchLoaiHinh;
            }
        }

        private void dgvDiaDiem_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndexDiaDiem = dgvDiaDiem.CurrentCell.RowIndex;
            DiaDiem tmp = null;
            try
            {
                tmp = dgvDiaDiem.CurrentRow.DataBoundItem as DiaDiem;
                textBox_MaDiaDiem.Text = tmp.MaDiaDiem.ToString();
                textBoxTenDiaDiem.Text = tmp.TenDiaDiem.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnDatLai_DiaDiem_Click(object sender, EventArgs e)
        {
            textBox_MaDiaDiem.Text = "";
            textBoxTenDiaDiem.Text = "";
        }

        private void button_Them_DiaDiem_Click(object sender, EventArgs e)
        {
            maDiaDiemMax = busDiaDiem.getMaDiaDiemMax();
            DiaDiem diaDiem = new DiaDiem();
            maDiaDiemMax++;
            diaDiem.MaDiaDiem = maDiaDiemMax;
            diaDiem.TenDiaDiem = textBoxTenDiaDiem.Text;
            busDiaDiem.themDiaDiem(diaDiem);
            dgvDiaDiem.DataSource = null;
            dgvDiaDiem.DataSource = BUS_QL_DiaDiem.listDiaDiem;
        }

        private void button_Sua_DiaDiem_Click(object sender, EventArgs e)
        {
            DiaDiem diaDiem = dgvDiaDiem.CurrentRow.DataBoundItem as DiaDiem;
            diaDiem.TenDiaDiem = textBoxTenDiaDiem.Text;
            dgvDiaDiem.Update();
            dgvDiaDiem.Refresh();
            busDiaDiem.suaDiaDiem(diaDiem);
        }

        private void button_Xoa_DiaDiem_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá địa điểm không?", "Bạn đang xoá địa điểm", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                DiaDiem diaDiem = dgvDiaDiem.CurrentRow.DataBoundItem as DiaDiem;
                if (busDiaDiem.xoaDiaDiem(diaDiem))
                {
                    maDiaDiemMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvDiaDiem.DataSource = null;
                    dgvDiaDiem.DataSource = BUS_QL_DiaDiem.listDiaDiem;
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

        private void textBoxSearchDiaDiem_TextChanged(object sender, EventArgs e)
        {
            String textSearch = textBoxSearchDiaDiem.Text.ToLower();
            listSearchDiaDiem = busDiaDiem.timKiemDiaDiem(textSearch);
            if (textBoxSearchDiaDiem.Text == "")
            {
                dgvDiaDiem.DataSource = BUS_QL_DiaDiem.listDiaDiem;
            }
            else
            {
                dgvDiaDiem.DataSource = listSearchDiaDiem;
            }
        }

        private void dgvLoaiChiPhi_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndexLoaiChiPhi = dgvLoaiChiPhi.CurrentCell.RowIndex;
            LoaiChiPhi tmp = null;
            try
            {
                tmp = dgvLoaiChiPhi.CurrentRow.DataBoundItem as LoaiChiPhi;
                textBoxMaLoaiChiPhi.Text = tmp.MaLoaiChiPhi.ToString();
                textBoxTenLoaiChiPhi.Text = tmp.TenLoaiChiPhi.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button_DatLai_LoaiChiPhi_Click(object sender, EventArgs e)
        {
            textBoxMaLoaiChiPhi.Text = "";
            textBoxTenLoaiChiPhi.Text = "";
        }

        private void button_Them_LoaiChiPhi_Click(object sender, EventArgs e)
        {
            maLoaiChiPhiMax = busLoaiChiPhi.getMaChiPhiMax();
            LoaiChiPhi loaiChiPhi = new LoaiChiPhi();
            maLoaiChiPhiMax++;
            loaiChiPhi.MaLoaiChiPhi = maLoaiChiPhiMax;
            loaiChiPhi.TenLoaiChiPhi = textBoxTenLoaiChiPhi.Text;
            busLoaiChiPhi.themLoaiChiPhi(loaiChiPhi);
            dgvLoaiChiPhi.DataSource = null;
            dgvLoaiChiPhi.DataSource = BUS_QL_LoaiChiPhi.listLoaiChiPhi;
        }

        private void button_Sua_LoaiChiPhi_Click(object sender, EventArgs e)
        {
            LoaiChiPhi loaiChiPhi = dgvLoaiChiPhi.CurrentRow.DataBoundItem as LoaiChiPhi;
            loaiChiPhi.TenLoaiChiPhi = textBoxTenLoaiChiPhi.Text;
            dgvLoaiChiPhi.Update();
            dgvLoaiChiPhi.Refresh();
            busLoaiChiPhi.suaLoaiChiPhi(loaiChiPhi);
        }

        private void button_Xoa_LoaiChiPhi_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá loại chi phí không?", "Bạn đang xoá loại chi phí", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                LoaiChiPhi loaiChiPhi = dgvLoaiChiPhi.CurrentRow.DataBoundItem as LoaiChiPhi;
                if (busLoaiChiPhi.xoaLoaiChiPhi(loaiChiPhi))
                {
                    maLoaiChiPhiMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvLoaiChiPhi.DataSource = null;
                    dgvLoaiChiPhi.DataSource = BUS_QL_LoaiChiPhi.listLoaiChiPhi;
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

        private void textBoxSearchLoaiChiPhi_TextChanged(object sender, EventArgs e)
        {
            String textSearch = textBoxSearchLoaiChiPhi.Text.ToLower();
            listSearchLoaiChiPhi = busLoaiChiPhi.timKiemLoaiChiPhi(textSearch);
            if (textBoxSearchLoaiChiPhi.Text == "")
            {
                dgvLoaiChiPhi.DataSource = BUS_QL_LoaiChiPhi.listLoaiChiPhi;
            }
            else
            {
                dgvLoaiChiPhi.DataSource = listSearchLoaiChiPhi;
            }
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndexNhanVien = dgvNhanVien.CurrentCell.RowIndex;
            NhanVien tmp = null;
            try
            {
                tmp = dgvNhanVien.CurrentRow.DataBoundItem as NhanVien;
                textBoxMaNhanVien.Text = tmp.MaNhanVien.ToString();
                textBoxTenNhanVien.Text = tmp.TenNhanVien.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button_DatLai_NhanVien_Click(object sender, EventArgs e)
        {
            textBoxMaNhanVien.Text = "";
            textBoxTenNhanVien.Text = "";
        }

        private void button_Them_NhanVien_Click(object sender, EventArgs e)
        {
            maNhanVienMax = busNhanVien.getMaNhanVienMax();
            NhanVien nhanVien = new NhanVien();
            maNhanVienMax++;
            nhanVien.MaNhanVien =  maNhanVienMax;
            nhanVien.TenNhanVien = textBoxTenNhanVien.Text;
            busNhanVien.themNhanVien(nhanVien);
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = BUS_QL_NhanVien.listNhanVien;
        }

        private void button_Sua_NhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = dgvNhanVien.CurrentRow.DataBoundItem as NhanVien;
            nhanVien.TenNhanVien = textBoxTenNhanVien.Text;
            dgvNhanVien.Update();
            dgvNhanVien.Refresh();
            busNhanVien.suaNhanVien(nhanVien);
        }

        private void button_Xoa_NhanVien_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá nhân viên không?", "Bạn đang xoá nhân viên", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                NhanVien nhanVien = dgvNhanVien.CurrentRow.DataBoundItem as NhanVien;
                if (busNhanVien.xoaNhanVien(nhanVien))
                {
                    maNhanVienMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvNhanVien.DataSource = null;
                    dgvNhanVien.DataSource = BUS_QL_NhanVien.listNhanVien;
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

        private void textBoxSearchNhanVien_TextChanged(object sender, EventArgs e)
        {
            String textSearch = textBoxSearchNhanVien.Text.ToLower();
            listSearchNhanVien = busNhanVien.timKiemNhanVien(textSearch);
            if (textBoxSearchNhanVien.Text == "")
            {
                dgvNhanVien.DataSource = BUS_QL_NhanVien.listNhanVien;
            }
            else
            {
                dgvNhanVien.DataSource = listSearchNhanVien;
            }
        }

        private void khacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QL_Khac formKhac = new Form_QL_Khac();
            formKhac.ShowDialog();
            this.Close();
        }

        private void tourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QL_Tour formQLTour = new Form_QL_Tour();
            formQLTour.ShowDialog();
            this.Close();
        }
    }
}
