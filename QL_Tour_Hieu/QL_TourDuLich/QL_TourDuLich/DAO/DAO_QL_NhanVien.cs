using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_NhanVien
    {
        public List<NhanVien> getDanhSachNhanVien()
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            using(TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.NhanViens
                            select t;
                foreach(var i in table)
                {
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNhanVien = i.MaNhanVien;
                    nhanVien.TenNhanVien = i.TenNhanVien;
                    dsNhanVien.Add(nhanVien);
                }
                return dsNhanVien;
            }
        }
        public Boolean suaNhanVien(NhanVien nhanVien)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                NhanVien nhanVienDb = db.NhanViens.Find(nhanVien.MaNhanVien);
                nhanVienDb.TenNhanVien = nhanVien.TenNhanVien;
                db.SaveChanges();
            }
            return true;
        }
        public Boolean themNhanVien(NhanVien nhanVien)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean xoaNhanVien(int maNhanVien)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                NhanVien nhanVien = db.NhanViens.Find(maNhanVien);
                if(nhanVien.PhanBoNhanVien_Doan.Count() > 0)
                {
                    return false;
                }
                else
                {
                    db.NhanViens.Remove(nhanVien);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}
