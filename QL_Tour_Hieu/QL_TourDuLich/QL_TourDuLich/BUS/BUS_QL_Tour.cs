using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    public class ThongTinDiaDiem
    {
        public string TenDiaDiem { get; set; }
        public int ThuTu { get; set; }
    }

    public class ThongTinDoanTour
    {
        public int maDoan { get; set; }
        public String tenDoan { get; set; }
        public DateTime ngayBd { get; set; }
        public DateTime ngayKt { get; set; }
    }
    partial class TourDuLich
    {
        public static List<TourDuLich> lstTours = null;
        public static List<string> lstTrangThai = new List<string>(new string[] { "kết thúc", "đang diễn ra", "đã hủy", "chưa đăng ký" });
        public string tenLoaiTour { get; set; }
        public double giaTour { get; set; }
        
        public List<ThongTinDiaDiem> dsDiaDiem = new List<ThongTinDiaDiem>();
        public List<ThongTinDoanTour> dsDoanTour = new List<ThongTinDoanTour>();
        DAO_QL_Tour dao = new DAO_QL_Tour();
        DAO_QL_LoaiHinh dd = new DAO_QL_LoaiHinh();
        public void getDanhsachTour()
        {
            //lstTours = dao.getDanhSachTour();
            lstTours = dao.getDanhSachTourKhongJoin();
            lstTours = lstTours.OrderBy(t => t.MaTour).ToList();
        }
        public int getMaTourLonNhat()
        {
            return TourDuLich.lstTours.Last().MaTour;
        }
        public List<String> getDSTenLoaiHinh()
        {
            return dao.getDSTenLoaiHinh();
        }
        public Boolean suaTour(TourDuLich tourDL)
        {
            return dao.suaTour(tourDL);
        }
        public Boolean themTour(TourDuLich tourDL)
        {
            TourDuLich.lstTours.Add(tourDL);
            return dao.themTour(tourDL);
        }
        public int getMaLoaiHinh(String tenLoaiHinh)
        {
            return dao.getMaLoaiHinh(tenLoaiHinh);
        }
        public Boolean xoaTour(TourDuLich tourDL)
        {
            //xóa trong lstTour
            TourDuLich.lstTours.Remove(tourDL);
            return dao.xoaTour(tourDL.MaTour);
        }
        public bool anTour(int Ma)
        {
            return dao.anTour(Ma);
        }
        public Boolean suaChiTietTour(TourDuLich tourDL)
        {
            return dao.suaChiTietTour(tourDL);
        }
        public List<TourDuLich> timKiem(String textTim)
        {
            var table = from t in TourDuLich.lstTours
                        where t.MaTour.ToString().Contains(textTim) || t.TenTour.ToLower().Contains(textTim)
                        || t.tenLoaiTour.ToLower().Contains(textTim) || t.TrangThai.ToLower().Contains(textTim)
                        || t.giaTour.ToString().Contains(textTim)
                        select t;
            return table.ToList();  
        }
        public List<TourDuLich> locTour(String loaiTour, String trangThai)
        {
            var table = from t in TourDuLich.lstTours
                        where t.tenLoaiTour.ToLower().Contains(loaiTour) || t.TrangThai.ToLower().Contains(trangThai)
                        select t;
            return table.ToList();
        }

        public List<String> getDanhSachTenDiaDiem()
        {
            return dao.getDanhSachTenDiaDiem();
        }
        public int getMaDiaDiem(String tenDiaDiem)
        {
            return dao.getMaDiaDiem(tenDiaDiem);
        }
        public Boolean themDiaDiem(int MaTour, int MaDD, int ThuTu)
        {
            return dao.themDiaDiem(MaTour, MaDD, ThuTu);
        }
        public Boolean xoaDiaDiem(int MaTour, int MaDD, int ThuTu)
        {
            return dao.xoaDiaDiem(MaTour, MaDD, ThuTu);
        }
        public List<GiaTour> getGiabyMaTour(int Ma)
        {
            return dao.getGiabyMaTour(Ma);
        }
        public bool isGiaTourHienTai(DateTime BatDau,DateTime KetThuc)
        {
            DateTime today = DateTime.Now;
            if (BatDau <= today && KetThuc >= today)
                return true;
                return false;
        }
        public TourDuLich timKiemTourById(int id)
        {
            return dao.getTourById(id);
        }
    }
}
