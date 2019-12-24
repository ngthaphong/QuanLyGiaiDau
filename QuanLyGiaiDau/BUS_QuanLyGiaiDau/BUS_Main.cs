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
    public static class BUS_Main
    {
        private static string ma;
        public static void setMaDN(string user, string pass)
        {
            BUS_DANGNHAP dn = new BUS_DANGNHAP();
            DataTable t = dn.getDANGNHAP();
            foreach (DataRow row in t.Rows)
            {
                if (row.Field<string>(1) == user && row.Field<string>(2) == pass)
                {
                    ma = row.Field<string>(0);
                    return;
                }
            }
        }
        public static string getMaDN() { return ma; }
    }
}
