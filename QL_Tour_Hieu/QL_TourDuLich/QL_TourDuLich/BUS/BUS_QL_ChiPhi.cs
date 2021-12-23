using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    partial class ChiPhi
    {
        public static List<ChiPhi> listChiPhi = null;
        public static List<LoaiChiPhi> listLoaiChiPhi = null;
        public static List<DoanDuLich> listDoan = null;
        DAO_QL_ChiPhi daoChiPhi = new DAO_QL_ChiPhi();
        public void getDSChiPhi()
        {
            listChiPhi = daoChiPhi.getDanhSachChiPhi();
            listChiPhi = listChiPhi.OrderBy(t => t.MaChiPhi).ToList();
        }
        public Boolean suaChiPhi(ChiPhi ChiPhi)
        {
            return daoChiPhi.suaChiPhi(ChiPhi);
        }
        public Boolean themChiPhi(ChiPhi ChiPhi)
        {
            listChiPhi.Add(ChiPhi);
            return daoChiPhi.themChiPhi(ChiPhi);
        }
        public Boolean xoaChiPhi(ChiPhi ChiPhi)
        {
            if (daoChiPhi.xoaChiPhi(ChiPhi.MaChiPhi))
            {
                listChiPhi.Remove(ChiPhi);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getMaChiPhiMax()
        {
            return listChiPhi.Last().MaChiPhi;
        }
        public List<ChiPhi> timKiemChiPhi(String textTim)
        {
            var table = from t in listChiPhi
                        where t.MaChiPhi.ToString().Contains(textTim) || t.MaDoan.ToString().Contains(textTim)
                        || t.SoTien.ToString().Contains(textTim) || t.MaLoaiChiPhi.ToString().Contains(textTim)
                        select t;
            return table.ToList();
        }

        public List<LoaiChiPhi> GetLoaiChiPhi()
        {
            return daoChiPhi.getDSLoaiChiPhi();
        }

        public List<DoanDuLich> GetDoanDuLich()
        {
            return daoChiPhi.getDSDoan();
        }

        public ChiPhi timKiemChiPhiById(int id)
        {
            return daoChiPhi.GetChiPhiById(id);
        }
    }
}
