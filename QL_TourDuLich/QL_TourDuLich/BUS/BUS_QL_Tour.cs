using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    partial class TourDuLich
    {
        public string tenLoaiTour { get; set; }
        public double giaTour { get; set; }
        DAO_QL_Tour dao = new DAO_QL_Tour();
        public List<TourDuLich> getDanhsachTour()
        {
            return dao.getDanhSachTour();
        }
    }
}
