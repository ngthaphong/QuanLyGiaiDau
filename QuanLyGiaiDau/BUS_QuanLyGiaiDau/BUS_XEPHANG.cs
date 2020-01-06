using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyGiaiDau;
using DTO_QuanLyGiaiDau;
using System.Data;
using System.Text.RegularExpressions;

namespace BUS_QuanLyGiaiDau
{
    public class BUS_XEPHANG
    {
        DAL_XEPHANG dalXEPHANG = new DAL_XEPHANG();
        public void addRank(int loai,string mag)
        {
            DataTable t = new DataTable();
            if (loai == 1)
            {
                t = SortwithHieu(mag);
                for(int i = 0; i < t.Rows.Count; i++)
                {
                    string mad = t.Rows[i].Field<string>(1);
                    object o = t.Rows[i].Field<int?>(2);
                    int? tong = o == DBNull.Value ? null : (int?)o;
                    o = t.Rows[i].Field<int?>(3);
                    int? hieu = o == DBNull.Value ? null : (int?)o;
                    int? vithu = i + 1;
                    DTO_XEPHANG dtox = new DTO_XEPHANG(mag,mad,tong,hieu,vithu);
                    upXEPHANG(dtox);
                }
            }
            else
            {
                t = SortwithTong(mag);
                for(int i = 0; i < t.Rows.Count; i++)
                {
                    string mad = t.Rows[i].Field<string>(1);
                    object o = t.Rows[i].Field<int?>(2);
                    int? tong = o == DBNull.Value ? null : (int?)o;
                    o = t.Rows[i].Field<int?>(3);
                    int? hieu = o == DBNull.Value ? null : (int?)o;
                    int? vithu = i + 1;
                    DTO_XEPHANG dtox = new DTO_XEPHANG(mag, mad, tong, hieu, vithu);
                    upXEPHANG(dtox);
                }
            }
        }
        public void ListRank(string mag)
        {
            BUS_DOI d = new BUS_DOI();
            DataTable diem = getSoDiem(mag);
            DataTable hieu = getHieuSo(mag);
            for(int i = 0; i < diem.Rows.Count; i++)
            {
                string ten = diem.Rows[i].Field<string>(0);
                string mad = d.getMa(ten);
                int tong = diem.Rows[i].Field<int>(1);
                int h = hieu.Rows[i].Field<int>(1);
                DTO_XEPHANG dtox = new DTO_XEPHANG(mag, mad, tong, h, null);
                if(CheckTrung(mag,mad)) addXEPHANG(dtox);
            }
        }
        public bool CheckTrung(string mag, string mad)
        {
            DataTable temp = getXEPHANGwithMa(mag);
            if (temp.Rows.Count == 0) return true;
            foreach (DataRow r in temp.Rows)
            {
                if (r.Field<string>(1) == mad) return false;
            }
            return true;
        }
        public DataTable getTenGiai(string mag)
        {
            return dalXEPHANG.getTenGiai(mag);
        }
        public DataTable getTenDoi(string mad)
        {
            return dalXEPHANG.getTenDoi(mad);
        }
        public DataTable SortRank(string mag)
        {
            return dalXEPHANG.SortRank(mag);
        }
        public DataTable SortwithTong(string mag)
        {
            return dalXEPHANG.SortwithTong(mag);
        }
        public DataTable SortwithHieu(string mag)
        {
            return dalXEPHANG.SortwithHieu(mag);
        }
        public DataTable getHieuSo(string mag)
        {
            return dalXEPHANG.getHieuSo(mag);
        }
        public DataTable getSoDiem(string mag)
        {
            return dalXEPHANG.getSoDiem(mag);
        }
        public DataTable getXEPHANGwithMa(string mag)
        {
            return dalXEPHANG.getXEPHANGwithMa(mag);
        }
        public DataTable getXEPHANG()
        {
            return dalXEPHANG.getXEPHANG();
        }
        public bool addXEPHANG(DTO_XEPHANG g)
        {
            return dalXEPHANG.addXEPHANG(g);
        }
        public bool upXEPHANG(DTO_XEPHANG g)
        {
            return dalXEPHANG.upXEPHANG(g);
        }
        public bool delXEPHANG(DTO_XEPHANG g)
        {
            return dalXEPHANG.delXEPHANG(g);
        }
    }
}
