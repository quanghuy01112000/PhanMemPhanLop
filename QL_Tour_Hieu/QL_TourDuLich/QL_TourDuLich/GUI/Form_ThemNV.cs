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
    public partial class Form_ThemNV : Form
    {
        public Form_ThemNV()
        {
            InitializeComponent();
        }
        public void load()
        {
            dgvNV.DataSource = Form_ChiTietDoan.bus.lstNhanVien;
        }
        private void Form_ThemNV_Load(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {

        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
