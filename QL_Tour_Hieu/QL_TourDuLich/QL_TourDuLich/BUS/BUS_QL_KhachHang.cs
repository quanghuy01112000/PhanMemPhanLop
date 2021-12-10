using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    class BUS_QL_KhachHang
    {
        public static List<KhachHang> listKhachHang = null;
        public static List<string> lstGioiTinh = new List<string>(new string[] { "Nam", "Nữ", "Khác" });
        DAO_QL_KhachHang daoKhachHang = new DAO_QL_KhachHang();
        public void getDSKhachHang()
        {
            listKhachHang = daoKhachHang.getDanhSachKhachHang();
            listKhachHang = listKhachHang.OrderBy(t => t.MaKhachHang).ToList();
        }
        public Boolean suaKhachHang(KhachHang khachHang)
        {
            return daoKhachHang.suaKhachHang(khachHang);
        }
        public Boolean themKhachHang(KhachHang khachHang)
        {
            listKhachHang.Add(khachHang);
            return daoKhachHang.themKhachHang(khachHang);
        }
        public Boolean xoaKhachHang(KhachHang khachHang)
        {
            if (daoKhachHang.xoaKhachHang(khachHang.MaKhachHang))
            {
                listKhachHang.Remove(khachHang);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getMaKhachHangMax()
        {
            return listKhachHang.Last().MaKhachHang;
        }
        public List<KhachHang> timKiemKhachHang(String textTim)
        {
            var table = from t in listKhachHang
                        where t.MaKhachHang.ToString().Contains(textTim) || t.HoTen.ToLower().Contains(textTim)
                        || t.DiaChi.ToLower().Contains(textTim) || t.GioiTinh.ToLower().Contains(textTim)
                        || t.soCMND.ToString().Contains(textTim) || t.SDT.ToString().Contains(textTim)
                        || t.QuocTich.ToLower().Contains(textTim)
                        select t;
            return table.ToList();
        }
    }
}
