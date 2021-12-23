using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_DiaDiem
    {
        public List<DiaDiem> getDanhSachDiaDiem()
        {
            List<DiaDiem> dsDiaDiem = new List<DiaDiem>();
            using(TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.DiaDiems
                            select t;
                foreach(var i in table)
                {
                    DiaDiem diaDiem = new DiaDiem();
                    diaDiem.MaDiaDiem = i.MaDiaDiem;
                    diaDiem.TenDiaDiem = i.TenDiaDiem;
                    dsDiaDiem.Add(diaDiem);
                }
                return dsDiaDiem;
            }
        }
        public Boolean suaDiaDiem(DiaDiem diaDiem)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                DiaDiem diaDiemDb = db.DiaDiems.Find(diaDiem.MaDiaDiem);
                diaDiemDb.TenDiaDiem = diaDiem.TenDiaDiem;
                db.SaveChanges();
            }
            return true;
        }
        public Boolean themDiaDiem(DiaDiem diaDiem)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                db.DiaDiems.Add(diaDiem);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean xoaDiaDiem(int maDiaDiem)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                DiaDiem diaDiem = db.DiaDiems.Find(maDiaDiem);
                if(diaDiem.ThamQuans.Count() > 0)
                {
                    return false;
                }
                else
                {
                    db.DiaDiems.Remove(diaDiem);
                    db.SaveChanges();
                }
            }
            return true;
        }
        public DiaDiem GetDiaDiemById(int id)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                DiaDiem diaDiem = db.DiaDiems.Find(id);
                return diaDiem;
            }
        }
    }
}
