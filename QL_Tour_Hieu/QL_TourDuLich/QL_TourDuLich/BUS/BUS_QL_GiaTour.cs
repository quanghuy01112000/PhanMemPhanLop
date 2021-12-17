using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    class BUS_QL_GiaTour
    {
        public static List<GiaTour> listGiaTour = null;
        public static List<TourDuLich> listTour = null;
        DAO_QL_GiaTour daoGiaTour = new DAO_QL_GiaTour();
        public void getDSGiaTour()
        {
            listGiaTour = daoGiaTour.getDanhSachGiaTour();
            listGiaTour = listGiaTour.OrderBy(t => t.MaGia).ToList();
        }
        public Boolean suaGiaTour(GiaTour giaTour)
        {
            return daoGiaTour.suaGiaTour(giaTour);
        }
        public Boolean themGiaTour(GiaTour giaTour)
        {
            listGiaTour.Add(giaTour);
            return daoGiaTour.themGiaTour(giaTour);
        }
        public Boolean xoaGiaTour(GiaTour giaTour)
        {
            if (daoGiaTour.xoaGiaTour(giaTour.MaGia))
            {
                listGiaTour.Remove(giaTour);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getMaGiaTourMax()
        {
            return listGiaTour.Last().MaGia;
        }
        public List<GiaTour> timKiemGiaTour(String textTim)
        {
            var table = from t in listGiaTour
                        where t.MaGia.ToString().Contains(textTim) || t.MaTour.ToString().Contains(textTim)
                        || t.ThanhTien.ToString().Contains(textTim) || t.ThoiGianBatDau.ToString().Contains(textTim)
                        || t.ThoiGianKetThuc.ToString().Contains(textTim)
                        select t;
            return table.ToList();
        }

        public List<TourDuLich> GetTours()
        {
            return daoGiaTour.getDSTenTour();
        }
    }
}
