using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    partial class LoaiChiPhi
    {
        public static List<LoaiChiPhi> listLoaiChiPhi = null;
        DAO_QL_LoaiChiPhi daoLoaiChiPhi = new DAO_QL_LoaiChiPhi();
        public void getDSLoaiChiPhi()
        {
            listLoaiChiPhi = daoLoaiChiPhi.getDanhSachLoaiChiPhi();
            listLoaiChiPhi = listLoaiChiPhi.OrderBy(t => t.MaLoaiChiPhi).ToList();
        }
        public Boolean suaLoaiChiPhi(LoaiChiPhi loaiChiPhi)
        {
            return daoLoaiChiPhi.suaLoaiChiPhi(loaiChiPhi);
        }
        public Boolean themLoaiChiPhi(LoaiChiPhi loaiChiPhi)
        {
            listLoaiChiPhi.Add(loaiChiPhi);
            return daoLoaiChiPhi.themLoaiChiPhi(loaiChiPhi);
        }
        public Boolean xoaLoaiChiPhi(LoaiChiPhi loaiChiPhi)
        {
            if(daoLoaiChiPhi.xoaLoaiChiPhi(loaiChiPhi.MaLoaiChiPhi))
            {
                listLoaiChiPhi.Remove(loaiChiPhi);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<LoaiChiPhi> timKiemLoaiChiPhi(String textTim)
        {
            var table = from t in listLoaiChiPhi
                        where t.MaLoaiChiPhi.ToString().Contains(textTim) || t.TenLoaiChiPhi.ToLower().Contains(textTim)
                        select t;
            return table.ToList();
        }
        public int getMaChiPhiMax()
        {
            return listLoaiChiPhi.Last().MaLoaiChiPhi;
        }
    }
}
