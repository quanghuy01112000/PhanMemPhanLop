using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;
using QL_TourDuLich.GUI;


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
        private string getMa()
        {
            String malh = "";
            foreach (LoaiHinhDuLich l in lhinh())
            {
                if (l.TenLoaiHinh.Equals(tenLoaiHinh))
                    return l.MaLoaiHinh;
            }

            return malh;
        }


        public void ThemTour(TourDuLich tour)
        {
            tour.MaTour = getMa();
            List<TourDuLich> lstTour = getDanhsachTour();
            lstTour.Add(tour);
            //update DAO here

        }

        public void suaTour (TourDuLich tour, int index)
        {
            tour.MaTour = getMa();
            List<TourDuLich> lstTour = getDanhsachTour();
            lstTour[index].MaTour = tour.MaTour;
            lstTour[index].TenTour = tour.TenTour;
            lstTour[index].TrangThai = tour.TrangThai;
            lstTour[index].tenLoaiHinh = tour.getMa();
            lstTour[index].giaTour = tour.giaTour;

            //update DAO here

        }

        public void xoaTour(int index)
        {
            List<TourDuLich> lstTour = getDanhsachTour();
            lstTour.RemoveAt(index);
            // goij DAO

        }

        public List<LoaiHinhDuLich> lhinh()
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                return db.LoaiHinhDuLiches.ToList();
            }
        }

        

    }
}
