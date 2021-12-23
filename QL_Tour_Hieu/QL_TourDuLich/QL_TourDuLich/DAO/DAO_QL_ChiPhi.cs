using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_ChiPhi
    {
        public List<ChiPhi> getDanhSachChiPhi()
        {
            List<ChiPhi> dsChiPhi = new List<ChiPhi>();
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.ChiPhis
                            select t;
                foreach (var i in table)
                {
                    ChiPhi ChiPhi = new ChiPhi();
                    ChiPhi.MaChiPhi = i.MaChiPhi;
                    ChiPhi.MaDoan = i.MaDoan;
                    ChiPhi.SoTien = i.SoTien;
                    ChiPhi.MaLoaiChiPhi = i.MaLoaiChiPhi;
                    dsChiPhi.Add(ChiPhi);
                }
                return dsChiPhi;
            }

        }

        public List<LoaiChiPhi> getDSLoaiChiPhi()
        {
            List<LoaiChiPhi> dsLoaiChiPhi = new List<LoaiChiPhi>();
            using (TourDLEntities db = new TourDLEntities())
            {

                var table = from l in db.LoaiChiPhis
                            select l;
                return table.ToList();
            }

        }

        public List<DoanDuLich> getDSDoan()
        {
            List<DoanDuLich> dsDoan = new List<DoanDuLich>();
            using (TourDLEntities db = new TourDLEntities())
            {

                var table = from l in db.DoanDuLiches
                            select l;
                return table.ToList();
            }

        }

        public Boolean suaChiPhi(ChiPhi ChiPhi)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                ChiPhi ChiPhiDb = db.ChiPhis.Find(ChiPhi.MaChiPhi);
                ChiPhiDb.MaDoan = ChiPhi.MaDoan;
                ChiPhiDb.SoTien = ChiPhi.SoTien;
                ChiPhiDb.MaLoaiChiPhi = ChiPhi.MaLoaiChiPhi;
                db.SaveChanges();
            }
            return true;
        }

        public Boolean themChiPhi(ChiPhi ChiPhi)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                db.ChiPhis.Add(ChiPhi);
                db.SaveChanges();
            }
            return true;
        }

        public Boolean xoaChiPhi(int maGia)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                ChiPhi ChiPhi = db.ChiPhis.Find(maGia);
                db.ChiPhis.Remove(ChiPhi);
                db.SaveChanges();

            }
            return true;
        }

        public ChiPhi GetChiPhiById(int id)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                ChiPhi ChiPhi = db.ChiPhis.Find(id);
                return ChiPhi;
            }
        }
    }
}
