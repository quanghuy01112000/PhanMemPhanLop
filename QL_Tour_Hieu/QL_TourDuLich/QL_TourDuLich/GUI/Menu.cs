using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TourDuLich.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {

            Form_QL_Tour Tour = new Form_QL_Tour();
            Tour.ShowDialog();
        }

        private void btnGiaTour_Click(object sender, EventArgs e)
        {
            Form_QL_GiaTour GTour = new Form_QL_GiaTour();
            GTour.ShowDialog();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            Form_QL_KhachHang KH = new Form_QL_KhachHang();
            KH.ShowDialog();
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            Form_QL_Khac Khac = new Form_QL_Khac();
            Khac.ShowDialog();  
        }
    }
}
