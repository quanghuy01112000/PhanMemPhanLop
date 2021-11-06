using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    public class danhSachDiaDiem
    {
        public string TenDiaDiem { get; set; }
        public int ThuTu { get; set; }
    }
    partial class TourDuLich
    {
        public string tenLoaiTour { get; set; }
        public double giaTour { get; set; }
        
        public List<danhSachDiaDiem> dsDiaDiem = new List<danhSachDiaDiem>();
        DAO_QL_Tour dao = new DAO_QL_Tour();
        DAO_QL_DiaDiem dd = new DAO_QL_DiaDiem();
        public List<TourDuLich> getDanhsachTour()
        {
            return dao.getDanhSachTour();
        }
        public TourDuLich getTourById(string id)
        {
            return dao.getTourById(id);
        }
    }
}
