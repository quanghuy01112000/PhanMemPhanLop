using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_TourDuLich.DAO;

namespace QL_TourDuLich.BUS
{
    partial class DiaDiem
    {
        public static List<DiaDiem> listDiaDiem = null;
        DAO_QL_DiaDiem daoDiaDiem = new DAO_QL_DiaDiem();
        public void getDSDiaDiem()
        {
            listDiaDiem = daoDiaDiem.getDanhSachDiaDiem();
            listDiaDiem = listDiaDiem.OrderBy(t => t.MaDiaDiem).ToList();
        }
        public Boolean suaDiaDiem(DiaDiem diaDiem)
        {
            return daoDiaDiem.suaDiaDiem(diaDiem);
        }
        public Boolean themDiaDiem(DiaDiem diaDiem)
        {
            listDiaDiem.Add(diaDiem);
            return daoDiaDiem.themDiaDiem(diaDiem);
        }
        public Boolean xoaDiaDiem(DiaDiem diaDiem)
        {
            if(daoDiaDiem.xoaDiaDiem(diaDiem.MaDiaDiem))
            {
                listDiaDiem.Remove(diaDiem);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<DiaDiem> timKiemDiaDiem(String textTim)
        {
            var table = from t in listDiaDiem
                        where t.MaDiaDiem.ToString().Contains(textTim) || t.TenDiaDiem.ToLower().Contains(textTim)
                        select t;

            return table.ToList();
        }
        public int getMaDiaDiemMax()
        {
            return listDiaDiem.Last().MaDiaDiem;
        }
        public DiaDiem timKiemDiaDiemById(int id)
        {
            return daoDiaDiem.GetDiaDiemById(id);
        }
    }
}
