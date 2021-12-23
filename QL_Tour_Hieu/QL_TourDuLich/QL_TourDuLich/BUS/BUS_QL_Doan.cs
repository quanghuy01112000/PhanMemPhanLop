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
        public bool loadLists()
        {
            lstKhachHang = dao.getKhachHangs();
            lstNhanVien = dao.getNhanViens();
            lstChiPhi = dao.getChiPhis();
            lstLoaiChiPhi = dao.GetLoaiChiPhis();
            lstDoanDuLich = dao.getThongTinDoan();
            
            return true;
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
    }
}
