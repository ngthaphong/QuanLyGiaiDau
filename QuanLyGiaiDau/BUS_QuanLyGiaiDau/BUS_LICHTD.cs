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
    public class BUS_LICHTD
    {
        DAL_LICHTD dalLICHTD = new DAL_LICHTD();
        public DataTable getLICHTD()
        {
            return dalLICHTD.getLICHTD();
        }
        public bool addLICHTD(DTO_LICHTD g)
        {
            return dalLICHTD.addLICHTD(g);
        }
        public bool upLICHTD(DTO_LICHTD g)
        {
            return dalLICHTD.upLICHTD(g);
        }
        public bool delLICHTD(DTO_LICHTD g)
        {
            return dalLICHTD.delLICHTD(g);
        }
    }
}
