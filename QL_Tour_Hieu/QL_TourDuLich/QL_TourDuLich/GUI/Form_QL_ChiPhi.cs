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
    public partial class Form_QL_ChiPhi : Form
    {
        DAO_QL_ChiPhi daoChiPhi = new DAO_QL_ChiPhi();
        ChiPhi busChiPhi = new ChiPhi();
        List<ChiPhi> listSearchChiPhi = new List<ChiPhi>();
        List<DoanDuLich> listDoan = new List<DoanDuLich>();
        List<LoaiChiPhi> listLoaiChiPhi = new List<LoaiChiPhi>();
        int SelectedIndex = 0;
        static int maChiPhiMax = 0;


        public Form_QL_ChiPhi()
        {
            InitializeComponent();
        }

        private void Form_QL_ChiPhi_Load(object sender, EventArgs e)
        {
            //load bảng tour
            dgvChiPhi.AutoGenerateColumns = false;//chặn tự tạo cột
            busChiPhi.getDSChiPhi();
            dgvChiPhi.DataSource = ChiPhi.listChiPhi;//bus.getDanhsachTour();
            dgvChiPhi.Columns["MaChiPhi"].DataPropertyName = "MaChiPhi";
            dgvChiPhi.Columns["MaDoan"].DataPropertyName = "MaDoan";
            dgvChiPhi.Columns["GiaTien"].DataPropertyName = "SoTien";
            dgvChiPhi.Columns["LoaiChiPhi"].DataPropertyName = "MaLoaiChiPhi";
            dgvChiPhi.AllowUserToOrderColumns = true;
            //load combobox

            foreach (var i in busChiPhi.GetDoanDuLich())
            {
                comboBoxMaDoan.Items.Add(i.MaDoan);
            }

            foreach (var i in busChiPhi.GetLoaiChiPhi())
            {
                comboBoxLoaiChiPhi.Items.Add(i.MaLoaiChiPhi);
            }
            //
            maChiPhiMax = busChiPhi.getMaChiPhiMax();
        }

        private void dgvGiaTour_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIndex = dgvChiPhi.CurrentCell.RowIndex;
            //comboBoxMaTour.Text = SelectedIndex.ToString();
            ChiPhi tmp = null;
            try
            {
                tmp = dgvChiPhi.CurrentRow.DataBoundItem as ChiPhi;
                txtMaChiPhi.Text = tmp.MaChiPhi.ToString();
                comboBoxMaDoan.Text = tmp.MaDoan.ToString();
                txtSoTien.Text = tmp.SoTien.ToString();
                comboBoxLoaiChiPhi.Text = tmp.MaLoaiChiPhi.ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Nhập vào sai!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }
            maChiPhiMax = busChiPhi.getMaChiPhiMax();
            ChiPhi chiPhi = new ChiPhi();
            maChiPhiMax++;
            chiPhi.MaChiPhi = maChiPhiMax;
            chiPhi.MaDoan = Int32.Parse(comboBoxMaDoan.Text);
            double tien = double.Parse(txtSoTien.Text);
            chiPhi.SoTien = tien;
            chiPhi.MaLoaiChiPhi = Int32.Parse(comboBoxLoaiChiPhi.Text);

            busChiPhi.themChiPhi(chiPhi);
            dgvChiPhi.DataSource = null;
            dgvChiPhi.DataSource = ChiPhi.listChiPhi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Nhập vào sai!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }
            ChiPhi chiPhi = dgvChiPhi.CurrentRow.DataBoundItem as ChiPhi;
            chiPhi.MaDoan = Int32.Parse(comboBoxMaDoan.Text);
            double tien = double.Parse(txtSoTien.Text);
            chiPhi.SoTien = tien;
            chiPhi.MaLoaiChiPhi = Int32.Parse(comboBoxLoaiChiPhi.Text);
            dgvChiPhi.Update();
            dgvChiPhi.Refresh();
            busChiPhi.suaChiPhi(chiPhi);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaChiPhi.Text = "";
            comboBoxMaDoan.Text = "";
            txtSoTien.Text = "";
            comboBoxLoaiChiPhi.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var messageXoa = MessageBox.Show("Bạn có muốn xoá chi phí không?", "Bạn đang xoá chi phí", MessageBoxButtons.YesNo);
            if (messageXoa == DialogResult.Yes)
            {
                ChiPhi chiPhi = dgvChiPhi.CurrentRow.DataBoundItem as ChiPhi;
                if (busChiPhi.xoaChiPhi(chiPhi))
                {
                    maChiPhiMax--;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    dgvChiPhi.DataSource = null;
                    dgvChiPhi.DataSource = ChiPhi.listChiPhi;
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

        private void txtTimKiemGiaTour_TextChanged(object sender, EventArgs e)
        {
            String textSearch = txtTimKiemGiaTour.Text.ToLower();
            listSearchChiPhi = busChiPhi.timKiemChiPhi(textSearch);
            if (txtTimKiemGiaTour.Text == "")
            {
                dgvChiPhi.DataSource = ChiPhi.listChiPhi;
            }
            else
            {
                dgvChiPhi.DataSource = listSearchChiPhi;
            }
        }

        
    }
}
