using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    partial class NhanVien
    {
        public static List<NhanVien> listNhanVien = null;
        DAO_QL_NhanVien daoNhanVien = new DAO_QL_NhanVien();
        public void getDSNhanVien()
        {
            listNhanVien = daoNhanVien.getDanhSachNhanVien();
            listNhanVien = listNhanVien.OrderBy(t => t.MaNhanVien).ToList();
        }
        public Boolean suaNhanVien(NhanVien nhanVien)
        {
            return daoNhanVien.suaNhanVien(nhanVien);
        }
        public Boolean themNhanVien(NhanVien nhanVien)
        {
            listNhanVien.Add(nhanVien);
            return daoNhanVien.themNhanVien(nhanVien);
        }
        public Boolean xoaNhanVien(NhanVien nhanVien)
        {
            if(daoNhanVien.xoaNhanVien(nhanVien.MaNhanVien))
            {
                listNhanVien.Remove(nhanVien);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<NhanVien> timKiemNhanVien(String textTim)
        {
            var table = from t in listNhanVien
                        where t.MaNhanVien.ToString().Contains(textTim) || t.TenNhanVien.ToLower().Contains(textTim)
                        select t;
            return table.ToList();
        }
        public int getMaNhanVienMax()
        {
            return listNhanVien.Last().MaNhanVien;
        }
    }
}
