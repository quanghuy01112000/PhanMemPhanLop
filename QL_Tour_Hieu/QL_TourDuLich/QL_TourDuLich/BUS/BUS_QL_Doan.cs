using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;
namespace QL_TourDuLich.BUS
{

    partial class DoanDuLich
    {
        public List<KhachHang> lstKhachHang;
        public List<NhanVien> lstNhanVien;
        public List<LoaiChiPhi> lstLoaiChiPhi;
        public List<DoanDuLich> lstDoanDuLich ;
        public List<ChiPhi > lstChiPhi ;

        //public List<DoanDuLich> lstDoan = new List<DoanDuLich>();
        //public List<NhanVien > lstNV = new List<NhanVien>() ;
        //public List<ChiPhi> lstCP = new List<ChiPhi>();
        //public TourDuLich tour = new TourDuLich();
        //public List<KhachHang > lstKH = new List<KhachHang>() ;
        //public void copy()
        //{
        //    tour.tenLoaiTour = TourDuLich.tenLoaiTour ;
        //    tour.TenTour = TourDuLich .TenTour ;
        //    foreach(DoanDuLich i  in lstDoanDuLich)
        //    {
        //        DoanDuLich j = new DoanDuLich();
        //        j.MaDoan = i.MaDoan;
        //        j.MaTour = i.MaTour;
        //        j.NgayKetThuc = i.NgayKetThuc;
        //        j.NgayKhoiHanh = i.NgayKhoiHanh;
        //        j.NoiDungTour = i.NoiDungTour;
        //        j.PhanBoNhanVien_Doan = i.PhanBoNhanVien_Doan;
        //        j.DoanhThu = i.DoanhThu;
        //        j.TourDuLich = new TourDuLich();
        //        j.TourDuLich.TenTour = i.TourDuLich.TenTour;
        //        j.KhachHangs = new List<KhachHang>();
        //        foreach (KhachHang k in i.KhachHangs)
        //        {
        //            KhachHang l = new KhachHang();
        //            l.MaKhachHang = k.MaKhachHang;
        //            l.soCMND = k.soCMND;
        //            l.SDT = k.SDT;
        //            l.GioiTinh = k.GioiTinh;
        //            l.QuocTich = k.QuocTich;
        //            l.HoTen = k.HoTen;
        //            j.KhachHangs.Add(l);
        //        }
        //        j.ChiPhis = new List<ChiPhi>();
        //        foreach (ChiPhi x in i.ChiPhis)
        //        {
        //            ChiPhi c = new ChiPhi();
        //            c.MaLoaiChiPhi = x.MaLoaiChiPhi;
        //            c.MaDoan = x.MaDoan;
        //            c.MaChiPhi = x.MaChiPhi;
        //            c.LoaiChiPhi = x.LoaiChiPhi;
        //            c.SoTien = x.SoTien;
        //            c.DoanDuLich = x.DoanDuLich;
        //            j.ChiPhis.Add(c);
        //        }

        //        lstDoan.Add(j);
        //    }
        //}
        
        DAO_QL_Doan dao =new DAO_QL_Doan();
        public bool themDoan(DoanDuLich tmp)
        {
            dao.themDoan(tmp);
            return true;
        }
        public bool suaDoan(DoanDuLich tmp)
        {
            dao.suaDoan(tmp);
            return true;
        }
        public bool xoaDoan(int maDoan)
        {
            dao.xoaDoan(maDoan);
            return true;
        }
        public List<DoanDuLich> timKiem(String textTim)
        {
            var table = from t in lstDoanDuLich
                        where t.MaTour.ToString().Contains(textTim) || t.MaDoan.ToString().Contains(textTim)
                        ||t.DoanhThu.ToString().CompareTo(textTim) == 0
                        select t;
            return table.ToList();
        }
        public bool loadLists()
        {
            lstDoanDuLich = dao.getThongTinDoan();
            lstKhachHang = dao.getKhachHangs();
            lstNhanVien = dao.getNhanViens();
            lstChiPhi = dao.getChiPhis();
            lstLoaiChiPhi = dao.GetLoaiChiPhis();
            
            
            return true;
        }

        internal void getTour1(int? maTour)
        {
            throw new NotImplementedException();
        }

        public DoanDuLich getItem( int maDoan)
        {
            return dao.getItem(maDoan);
        }

        public bool themKH(KhachHang kh)
        {
            dao.themKH(kh);
            return true;
        }

        public bool xoaKH(int maKH)
        {
            dao.xoaKH(maKH);
            return true;
        }

        public bool themChiPhi(ChiPhi cp)
        {
            dao.themChiPhi(cp);
            return true;
        }

        public bool xoaChiPhi(int maChiPhi)
        {
            dao.xoaChiPhi(maChiPhi);
            return true;
        }

        public bool themNV(NhanVien nv)
        {
            dao.themNV(nv);
            return true;
        }

        public bool xoaNV(int maNV)
        {
            dao.xoaChiPhi(maNV);
            return true;
        }
        public KhachHang getKhachHang(int maKhachHang)
        {
            return dao.getKhachKhang(maKhachHang);
        }

        public TourDuLich getTour(int maTour)
        {
            return dao.getTour(maTour);
        }
        public void getTour1(int maTour)
        {
            TourDuLich = getTour(maTour);
        }
    }
}
