using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_Tour
    {
        public List<TourDuLich> getDanhSachTour()
        {
            List<TourDuLich> dsTour = new List<TourDuLich>();
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.TourDuLiches
                            select t;
                foreach(var i in table)
                {
                    TourDuLich tour = new TourDuLich();
                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.tenLoaiTour = i.LoaiHinhDuLich.TenLoaiHinh;
                    tour.GiaTours = i.GiaTours;
                    tour.TrangThai = i.TrangThai;
                    tour.ThamQuans = i.ThamQuans;
                    dsTour.Add(tour);
                }
                return dsTour;
            }

        }

    }
}
