using QL_TourDuLich.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TourDuLich
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_QL_Tour());
            //Application.Run(new Form_QL_Khac());
            //Application.Run(new Form_QL_KhachHang());
            //Application.Run(new Form_QL_GiaTour());
            Application.Run(new GUI.Menu());
        }
    }
}
