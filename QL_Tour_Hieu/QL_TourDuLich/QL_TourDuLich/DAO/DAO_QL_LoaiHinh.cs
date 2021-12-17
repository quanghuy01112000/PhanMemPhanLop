using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_LoaiHinh
    {
        public List<LoaiHinhDuLich> getDanhSachLoaiHinh()
        {
            List<LoaiHinhDuLich> dsLoaiHinh = new List<LoaiHinhDuLich>();
            using (TourDLEntities db = new TourDLEntities()) {
                var table = from t in db.LoaiHinhDuLiches
                            select t;
                foreach(var i in table)
                {
                    LoaiHinhDuLich loaiHinh = new LoaiHinhDuLich();
                    loaiHinh.MaLoaiHinh = i.MaLoaiHinh;
                    loaiHinh.TenLoaiHinh = i.TenLoaiHinh;
                    dsLoaiHinh.Add(loaiHinh);
                }
                return dsLoaiHinh;
            }
        }
        public Boolean suaLoaiHinh(LoaiHinhDuLich loaiHinh)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                LoaiHinhDuLich loaiHinhDb = db.LoaiHinhDuLiches.Find(loaiHinh.MaLoaiHinh);
                loaiHinhDb.TenLoaiHinh = loaiHinh.TenLoaiHinh;
                db.SaveChanges();
            }
            return true;
        }
        public Boolean themLoaiHinh(LoaiHinhDuLich loaiHinh)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                db.LoaiHinhDuLiches.Add(loaiHinh);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean xoaLoaiHinh(int maLoaiHinh)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                LoaiHinhDuLich loaiHinh = db.LoaiHinhDuLiches.Find(maLoaiHinh);
                if (loaiHinh.TourDuLiches.Count() > 0)
                {
                    return false;
                }
                else
                {
                    db.LoaiHinhDuLiches.Remove(loaiHinh);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}
