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
                DateTime today = DateTime.Now;
                var table = from t in db.TourDuLiches
                            join g in db.GiaTours on t.MaTour equals g.MaTour
                            where g.ThoiGianBatDau < today
                            where g.ThoiGianKetThuc > today
                            select new { t.MaTour, t.TenTour, t.LoaiHinhDuLich, g.ThanhTien, t.TrangThai, t.ThamQuans, t.DacDiem };

                foreach (var i in table)
                {
                    TourDuLich tour = new TourDuLich();
                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.tenLoaiTour = i.LoaiHinhDuLich.TenLoaiHinh;
                    tour.giaTour = (double)i.ThanhTien;
                    tour.TrangThai = i.TrangThai;
                    tour.DacDiem = i.DacDiem;
                    var tbDiaDiem = from d in db.DiaDiems
                                    join tq in db.ThamQuans on d.MaDiaDiem equals tq.MaDiaDiem
                                    where tq.MaTour==i.MaTour
                                    select new { d.TenDiaDiem, tq.ThuTu };
                    foreach (var j in tbDiaDiem)
                    {
                        var dd = new danhSachDiaDiem();
                        dd.TenDiaDiem = j.TenDiaDiem;
                        dd.ThuTu = j.ThuTu;
                        tour.dsDiaDiem.Add(dd);
                    }
                    dsTour.Add(tour);
                }
                return dsTour;
            }

        }
    }
}
