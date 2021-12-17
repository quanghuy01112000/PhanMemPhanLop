using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_GiaTour
    {
        public List<GiaTour> getDanhSachGiaTour()
        {
            List<GiaTour> dsGiaTour = new List<GiaTour>();
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.GiaTours
                            select t;
                foreach (var i in table)
                {
                    GiaTour giaTour = new GiaTour();
                    giaTour.MaGia = i.MaGia;
                    giaTour.MaTour = i.MaTour;
                    giaTour.ThanhTien = i.ThanhTien;
                    giaTour.ThoiGianBatDau = i.ThoiGianBatDau;
                    giaTour.ThoiGianKetThuc = i.ThoiGianKetThuc;
                    dsGiaTour.Add(giaTour);
                }
                return dsGiaTour;
            }

        }

        public List<TourDuLich> getDSTenTour()
        {
            List<TourDuLich> dsTenTour = new List<TourDuLich>();
            using (TourDLEntities db = new TourDLEntities())
            {

                var table = from l in db.TourDuLiches
                            select l;
                return table.ToList();
            }
            
        }


        public Boolean suaGiaTour(GiaTour giaTour)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                GiaTour giaTourDb = db.GiaTours.Find(giaTour.MaGia);
                giaTourDb.MaTour = giaTour.MaTour;
                giaTourDb.ThanhTien = giaTour.ThanhTien;
                giaTourDb.ThoiGianBatDau = giaTour.ThoiGianBatDau;
                giaTourDb.ThoiGianKetThuc = giaTour.ThoiGianKetThuc;
                db.SaveChanges();
            }
            return true;
        }

        public Boolean themGiaTour(GiaTour giaTour)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                db.GiaTours.Add(giaTour);
                db.SaveChanges();
            }
            return true;
        }

        public Boolean xoaGiaTour(int maGia)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                GiaTour giaTour = db.GiaTours.Find(maGia);
                
                    db.GiaTours.Remove(giaTour);
                    db.SaveChanges();
                
            }
            return true;
        }
    }
}
