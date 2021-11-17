﻿using System;
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
                var table = from t in db.TourDuLiches//var cho tự ép kiểu
                            join g in db.GiaTours on t.MaTour equals g.MaTour into emty
                            from gia in emty.DefaultIfEmpty()
                            where t.HienThi == true
                            where gia==null || (gia.ThoiGianBatDau < today && gia.ThoiGianKetThuc > today)
                            select new {gia = (gia == null) ? 0 : gia.ThanhTien,t.MaTour, t.TenTour, t.LoaiHinhDuLich, t.TrangThai, t.ThamQuans, t.DacDiem,t.NgayBatDau,t.NgayKetThuc};

                foreach (var i in table)
                {
                    TourDuLich tour = new TourDuLich();
                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.tenLoaiTour = i.LoaiHinhDuLich.TenLoaiHinh;
                    tour.giaTour = (double)i.gia;
                    tour.TrangThai = i.TrangThai;
                    tour.DacDiem = i.DacDiem;
                    tour.NgayBatDau = i.NgayBatDau;
                    tour.NgayKetThuc = i.NgayKetThuc;
                    var tbDiaDiem = from d in db.DiaDiems
                                    join tq in db.ThamQuans on d.MaDiaDiem equals tq.MaDiaDiem
                                    where tq.MaTour==i.MaTour
                                    orderby tq.ThuTu ascending
                                    select new { d.TenDiaDiem, tq.ThuTu };
                    foreach (var j in tbDiaDiem)
                    {
                        var dd = new ThongTinDiaDiem();
                        dd.TenDiaDiem = j.TenDiaDiem;
                        dd.ThuTu = j.ThuTu;
                        tour.dsDiaDiem.Add(dd);
                    }
                    dsTour.Add(tour);
                }
                return dsTour;
            }

        }
        public List<String> getDSTenLoaiHinh()
        {
            List<String> dsLoaiTour = new List<String>();
            using (TourDLEntities db = new TourDLEntities())
            {

                var table = from l in db.LoaiHinhDuLiches
                            select new { l.TenLoaiHinh };
                foreach (var i in table)
                {
                    dsLoaiTour.Add(i.TenLoaiHinh);
                }
            }
            return dsLoaiTour;
        }
        public Boolean suaTour(TourDuLich tourDL)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                TourDuLich tourdb = db.TourDuLiches.Find(tourDL.MaTour);
                tourdb.MaLoaiHinh = tourDL.MaLoaiHinh;
                tourdb.TenTour = tourDL.TenTour;
                tourdb.TrangThai = tourDL.TrangThai;
                db.SaveChanges();
            }
            return true;
        }
        public Boolean themTour(TourDuLich tourDL)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                db.TourDuLiches.Add(tourDL);
                db.SaveChanges();
            }
            return true;
        }
        public int getMaLoaiHinh(String tenLoaiHinh)
        {
            int kq;
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.LoaiHinhDuLiches
                            where t.TenLoaiHinh == tenLoaiHinh
                            select new { t.MaLoaiHinh };
                kq = table.First().MaLoaiHinh;
            }
            return kq;
        }
        public int getMaDiaDiem(String tenDiaDiem)
        {
            int kq;
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from t in db.DiaDiems
                            where t.TenDiaDiem == tenDiaDiem
                            select new { t.MaDiaDiem };
                kq = table.First().MaDiaDiem;
            }
            return kq;
        }
        public Boolean xoaTour(int Ma)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                TourDuLich tour = db.TourDuLiches.Find(Ma);
                db.TourDuLiches.Remove(tour);
                db.SaveChanges();
            }
            return true;
        }
        public bool anTour(int Ma)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                TourDuLich tour = db.TourDuLiches.Find(Ma);
                tour.HienThi = false;
                db.SaveChanges();
            }
            return true;
        }
        public Boolean suaChiTietTour(TourDuLich tourDL)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                TourDuLich tourdb = db.TourDuLiches.Find(tourDL.MaTour);
                tourdb.DacDiem = tourDL.DacDiem;
                db.SaveChanges();
            }
            return true;
        }
        public List<String> getDanhSachTenDiaDiem()
        {
            List<String> dsTenDiaDiem = new List<String>();
            using (TourDLEntities db = new TourDLEntities())
            {

                var table = from l in db.DiaDiems
                            select new { l.TenDiaDiem};
                foreach (var i in table)
                {
                    dsTenDiaDiem.Add(i.TenDiaDiem);
                }
            }
            return dsTenDiaDiem;
        }
        public Boolean themDiaDiem(int MaTour,int MaDD,int ThuTu)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                ThamQuan tq = new ThamQuan();
                tq.MaTour = MaTour;
                tq.MaDiaDiem = MaDD;
                tq.ThuTu = ThuTu;
                db.ThamQuans.Add(tq);
                db.SaveChanges();
            }
            return true;
        }
        public Boolean xoaDiaDiem(int MaTour, int MaDD, int ThuTu)
        {
            using (TourDLEntities db = new TourDLEntities())
            {
                var table = from tq in db.ThamQuans
                               where tq.MaTour == MaTour && tq.MaDiaDiem == MaDD && tq.ThuTu == ThuTu
                               select tq;
                ThamQuan t = table.First();
                db.ThamQuans.Remove(t);
                db.SaveChanges();
            }
            return true;
        }
    }
}
