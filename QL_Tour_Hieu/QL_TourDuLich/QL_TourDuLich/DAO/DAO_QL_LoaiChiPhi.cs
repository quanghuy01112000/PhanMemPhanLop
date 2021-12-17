using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_LoaiChiPhi
    {
        public List<LoaiChiPhi> getDanhSachLoaiChiPhi()
        {
            List<LoaiChiPhi> dsLoaiChiPhi = new List<LoaiChiPhi>();
            using(TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.LoaiChiPhis
                            select t;
                foreach(var i in table)
                {
                    LoaiChiPhi loaiChiPhi = new LoaiChiPhi();
                    loaiChiPhi.MaLoaiChiPhi = i.MaLoaiChiPhi;
                    loaiChiPhi.TenLoaiChiPhi = i.TenLoaiChiPhi;
                    dsLoaiChiPhi.Add(loaiChiPhi);
                }
                return dsLoaiChiPhi;
            }
        }
        public Boolean suaLoaiChiPhi(LoaiChiPhi loaiChiPhi)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                LoaiChiPhi loaiChiPhiDb = db.LoaiChiPhis.Find(loaiChiPhi.MaLoaiChiPhi);
                loaiChiPhiDb.TenLoaiChiPhi = loaiChiPhi.TenLoaiChiPhi;
                db.SaveChanges();
            }
            return true;
        }
        public Boolean themLoaiChiPhi(LoaiChiPhi loaiChiPhi)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                db.LoaiChiPhis.Add(loaiChiPhi);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean xoaLoaiChiPhi(int maLoaiChiPhi)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                LoaiChiPhi loaiChiPhi = db.LoaiChiPhis.Find(maLoaiChiPhi);
                if(loaiChiPhi.ChiPhis.Count() > 0)
                {
                    return false;
                }
                else
                {
                    db.LoaiChiPhis.Remove(loaiChiPhi);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }

}
