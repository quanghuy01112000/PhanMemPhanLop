using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    partial class BUS_QL_LoaiHinh
    {
        public static List<LoaiHinhDuLich> listLoaiHinh = null;
        DAO_QL_LoaiHinh daoLoaiHinh = new DAO_QL_LoaiHinh();
        public void getDSLoaiHinh()
        {
            listLoaiHinh = daoLoaiHinh.getDanhSachLoaiHinh();
            listLoaiHinh = listLoaiHinh.OrderBy(t => t.MaLoaiHinh).ToList();
        }
        public Boolean suaLoaiHinh(LoaiHinhDuLich loaiHinhDuLich)
        {
            return daoLoaiHinh.suaLoaiHinh(loaiHinhDuLich);
        }
        public Boolean themLoaiHinh(LoaiHinhDuLich loaiHinhDuLich)
        {
            listLoaiHinh.Add(loaiHinhDuLich);
            return daoLoaiHinh.themLoaiHinh(loaiHinhDuLich);
        }
        public Boolean xoaLoaiHinh(LoaiHinhDuLich loaiHinhDuLich)
        {
            if (daoLoaiHinh.xoaLoaiHinh(loaiHinhDuLich.MaLoaiHinh))
            {
                listLoaiHinh.Remove(loaiHinhDuLich);
                return true;
            }
            else
            {
                return false;

            }
        }
        public List<LoaiHinhDuLich> timKiemLoaiHinh(String textTim)
        {
            var table = from t in listLoaiHinh
                        where t.MaLoaiHinh.ToString().Contains(textTim) || t.TenLoaiHinh.ToLower().Contains(textTim)
                        select t;
            return table.ToList();
        }
        public int getMaLoaiHinhMax()
        {
            return listLoaiHinh.Last().MaLoaiHinh;
        }
    }
}
