using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.BUS;

namespace QL_TourDuLich.DAO
{
    internal class DAO_QL_Doan
    {
        TourDLEntities db = new TourDLEntities();
        public List<DoanDuLich> getThongTinDoan()
        {
            //using (TourDLEntities db = new TourDLEntities())
            //{

            var doan = db.DoanDuLiches;

            //List<DoanDuLich> tmp = new List<DoanDuLich>();
            //foreach (DoanDuLich i in doan)
            //{
            //    DoanDuLich j = new DoanDuLich();
            //    j.MaDoan = i.MaDoan;
            //    j.MaTour = i.MaTour;
            //    j.NgayKetThuc = i.NgayKetThuc;
            //    j.NgayKhoiHanh = i.NgayKhoiHanh;
            //    j.NoiDungTour = i.NoiDungTour;
            //    j.PhanBoNhanVien_Doan = i.PhanBoNhanVien_Doan;
            //    j.DoanhThu = i.DoanhThu;
            //    j.TourDuLich = new TourDuLich();
            //    j.TourDuLich = i.TourDuLich;
            //    //j.TourDuLich.TenTour = i.TourDuLich.TenTour;
            //    j.KhachHangs = new List<KhachHang>();
            //    foreach (KhachHang k in i.KhachHangs)
            //    {
            //        KhachHang l = new KhachHang();
            //        l.MaKhachHang = k.MaKhachHang;
            //        l.soCMND = k.soCMND;
            //        l.SDT = k.SDT;
            //        l.GioiTinh = k.GioiTinh;
            //        l.QuocTich = k.QuocTich;
            //        l.HoTen = k.HoTen;
            //        j.KhachHangs.Add(l);
            //    }
            //    j.ChiPhis = new List<ChiPhi>();
            //    foreach (ChiPhi x in i.ChiPhis)
            //    {
            //        ChiPhi c = new ChiPhi();
            //        c.MaLoaiChiPhi = x.MaLoaiChiPhi;
            //        c.MaDoan = x.MaDoan;
            //        c.MaChiPhi = x.MaChiPhi;
            //        c.LoaiChiPhi = x.LoaiChiPhi;
            //        c.SoTien = x.SoTien;
            //        c.DoanDuLich = x.DoanDuLich;
            //        j.ChiPhis.Add(c);
            //    }

            //    tmp.Add(j);
            //}

            //return tmp;

            return doan.ToList();
        }
    

        public TourDuLich getTour(int maTour)
        {
            //using (TourDLEntities db = new TourDLEntities())
            //{
                var tour = (from i in db.TourDuLiches
                           where i.MaTour == maTour
                           select i).FirstOrDefault();
                return tour;
            
        }
        public List<KhachHang> getKhachHangs()
        {
            //using (TourDLEntities db = new TourDLEntities())
            //{
                var kh = db.KhachHangs;
                return kh.ToList();
            
        }
        public List<ChiPhi> getChiPhis()
        {
           // using (TourDLEntities db = new TourDLEntities())
            {
                var chiPhis = db.ChiPhis;
                return chiPhis.ToList();
            }
        }



        public List<LoaiChiPhi> GetLoaiChiPhis()
        {
           // using (TourDLEntities db = new TourDLEntities())
            {
                var loaiCP = db.LoaiChiPhis;
                return loaiCP.ToList();
            }
        }

        public bool suaDoan(DoanDuLich tmp)
        {
          //  using (TourDLEntities db = new TourDLEntities())
            {
                DoanDuLich doandb = db.DoanDuLiches.Find(tmp.MaDoan);
                doandb = tmp;
                db.SaveChanges();
                return true;
            }
        }

        public bool themDoan(DoanDuLich tmp)
        {
            //  using (TourDLEntities db = new TourDLEntities())
            {
                    db.DoanDuLiches.Add(tmp);
                    db.SaveChanges();
                    return true;
                
                
            }
        }

        public bool xoaDoan(int maDoan)
        {
           // using (TourDLEntities db = new TourDLEntities())
            {
                DoanDuLich doandb = db.DoanDuLiches.Find(maDoan);
                db.DoanDuLiches.Remove(doandb);
                db.SaveChanges();
                return true;
            }
        }
        public DoanDuLich getItem(int maDoan)
        {
          //  using (TourDLEntities db = new TourDLEntities())
            {
                var d = (from i in db.DoanDuLiches
                         where i.MaDoan == maDoan
                         select i).SingleOrDefault();

                return d;
            }
        }
        public bool themChiPhi(ChiPhi cp)
        {
          //  using (TourDLEntities db = new TourDLEntities())
            {
                db.ChiPhis.Add(cp);
                db.SaveChanges();
                return true;
            }
        }

        public bool xoaChiPhi(int maChiPhi)
        {
         //   using (TourDLEntities db = new TourDLEntities())
            {
                db.ChiPhis.Remove(db.ChiPhis.Find(maChiPhi));
                db.SaveChanges();
                return true;
            }
        }

        public bool themKH(KhachHang kh)
        {
           // using (TourDLEntities db = new TourDLEntities())
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return true;
            }
        }

        public bool xoaKH(int maKH)
        {
         //   using (TourDLEntities db = new TourDLEntities())
            {
                db.KhachHangs.Remove(db.KhachHangs.Find(maKH));
                db.SaveChanges();
                return true;
            }
        }
        public bool themNV(NhanVien nv)
        {
           // using (TourDLEntities db = new TourDLEntities())
            {
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return true;
            }
        }

        public bool xoaNV(int maNV)
        {
          //  using (TourDLEntities db = new TourDLEntities())
            {
                db.NhanViens.Remove(db.NhanViens.Find(maNV));
                db.SaveChanges();
                return true;
            }
        }

        public List<NhanVien> getNhanViens()
        {
          //  using (TourDLEntities db = new TourDLEntities())
            {
                var nv = db.NhanViens;
                return nv.ToList();
            }
        }

        public KhachHang getKhachKhang(int maKH)
        {
          //  using (TourDLEntities db = new TourDLEntities())
            {
                var k = (from i in db.KhachHangs
                         where i.MaKhachHang == maKH
                         select i).SingleOrDefault();
                return k;
            }
        }
        
    }
}


