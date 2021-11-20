﻿using System;
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
    partial class TourDuLich
    {
        public static List<TourDuLich> lstTours = null;
        public string tenLoaiTour { get; set; }
        public double giaTour { get; set; }
        
        public List<ThongTinDiaDiem> dsDiaDiem = new List<ThongTinDiaDiem>();
        DAO_QL_Tour dao = new DAO_QL_Tour();
        DAO_QL_LoaiHinh dd = new DAO_QL_LoaiHinh();
        public void getDanhsachTour()
        {
            lstTours = dao.getDanhSachTour();
            lstTours = lstTours.OrderBy(t => t.MaTour).ToList();
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
            return dao.themTour(tourDL);
        }
        public int getMaLoaiHinh(String tenLoaiHinh)
        {
            return dao.getMaLoaiHinh(tenLoaiHinh);
        }
        public Boolean xoaTour(int Ma)
        {
            return dao.xoaTour(Ma);
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
        public bool isGiaTourHienTai(Object BatDau,Object KetThuc)
        {
            DateTime today = DateTime.Now;
            DateTime ThoiGianBatDau = (DateTime)BatDau;
            DateTime ThoiGianKetThuc = (DateTime)KetThuc;
            if (ThoiGianBatDau <= today && ThoiGianKetThuc >= today)
                return true;
                return false;
        }

    }
}
