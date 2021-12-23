using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    class DAO_QL_KhachHang
    {
        public List<KhachHang> getDanhSachKhachHang()
        {
            List<KhachHang> dsKhachHang = new List<KhachHang>();
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.KhachHangs
                            select t;
                foreach(var i in table)
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.MaKhachHang = i.MaKhachHang;
                    khachHang.HoTen = i.HoTen;
                    khachHang.soCMND = i.soCMND;
                    khachHang.DiaChi = i.DiaChi;
                    khachHang.GioiTinh = i.GioiTinh;
                    khachHang.SDT = i.SDT;
                    khachHang.QuocTich = i.QuocTich;
                    dsKhachHang.Add(khachHang);
                }
                return dsKhachHang;
            }    
            
        }

        public Boolean suaKhachHang(KhachHang khachHang)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                KhachHang khachHangDb = db.KhachHangs.Find(khachHang.MaKhachHang);
                khachHangDb.HoTen = khachHang.HoTen;
                khachHangDb.soCMND = khachHang.soCMND;
                khachHangDb.DiaChi = khachHang.DiaChi;
                khachHangDb.GioiTinh = khachHang.GioiTinh;
                khachHangDb.SDT = khachHang.SDT;
                khachHangDb.QuocTich = khachHang.QuocTich;
                db.SaveChanges();
            }
            return true;
        }

        public Boolean themKhachHang(KhachHang khachHang)
        {
            using(TourDLEntities db = new TourDLEntities())
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
            }
            return true;
        }

        public Boolean xoaKhachHang(int maKhachHang)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                KhachHang khachHang = db.KhachHangs.Find(maKhachHang);
                if(khachHang.DoanDuLiches.Count() > 0)
                {
                    return false;
                }
                else
                {
                    db.KhachHangs.Remove(khachHang);
                    db.SaveChanges();
                }
            }
            return true;
        }

        public KhachHang timKhachHangById(int maKhachHang)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                KhachHang khachHang = db.KhachHangs.Find(maKhachHang);
                return khachHang;
            }
            
        }
    }
}
