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
            var doan = db.DoanDuLiches;  
            return doan.ToList();
        }

        public List<KhachHang> getKhachHangs()
        {
            var kh = db.KhachHangs;
            return kh.ToList();
        }
        public List<ChiPhi> getChiPhis()
        {
            var chiPhis =  db.ChiPhis ;
            return chiPhis.ToList();
        }
        
        

        public List<LoaiChiPhi> GetLoaiChiPhis()
        {    
            var loaiCP =  db.LoaiChiPhis;
            return loaiCP.ToList();
        }

        public bool suaDoan(DoanDuLich tmp)
        {
            DoanDuLich doandb = db.DoanDuLiches.Find(tmp.MaDoan);
            doandb = tmp;
            db.SaveChanges();
            return true;
        }

        public bool themDoan(DoanDuLich tmp)
        {
            db.DoanDuLiches.Add(tmp);
            db.SaveChanges();
            return true;
        }

        public bool xoaDoan(int maDoan)
        {
            DoanDuLich doandb = db.DoanDuLiches.Find(maDoan);
            db.DoanDuLiches.Remove(doandb);
            db.SaveChanges();
            return true;
        }
        public DoanDuLich getItem(int maDoan)
        {
            var d = (from i in db.DoanDuLiches
                    where i.MaDoan == maDoan
                    select i).SingleOrDefault();

            return d;
        }
        public bool themChiPhi(ChiPhi cp)
        {
            db.ChiPhis.Add(cp);
            db.SaveChanges();
            return true;
        }

        public bool xoaChiPhi(int maChiPhi)
        {
            db.ChiPhis.Remove(db.ChiPhis.Find(maChiPhi));
            db.SaveChanges();
            return true;
        }

        public bool themKH(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
            return true;
        }

        public bool xoaKH(int maKH)
        {
            db.KhachHangs.Remove(db.KhachHangs.Find(maKH));
            db.SaveChanges();
            return true;
        }
        public bool themNV(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges ();
            return true;
        }

        public bool xoaNV(int maNV)
        {
            db.NhanViens.Remove(db.NhanViens.Find(maNV));
            db.SaveChanges();
            return true;
        }

        public List<NhanVien> getNhanViens()
        {
            var nv = db.NhanViens;
            return nv.ToList();
        }

        public KhachHang getKhachKhang(int maKH)
        {
            var k = (from i in db.KhachHangs
                    where i.MaKhachHang == maKH
                    select i).SingleOrDefault();
            return k;
        }
    }
}


