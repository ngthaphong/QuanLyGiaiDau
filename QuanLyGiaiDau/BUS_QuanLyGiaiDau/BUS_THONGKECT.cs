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
    public class BUS_THONGKECT
    {
        DAL_THONGKECT dalTHONGKECT = new DAL_THONGKECT();
        public DataTable getEmpty(string mag, string mad)
        {
            return dalTHONGKECT.getEmpty(mag, mad);
        }
        public DataTable getTHONGKECT()
        {
            return dalTHONGKECT.getTHONGKECT();
        }
        public bool addTHONGKECT(DTO_THONGKECT g)
        {
            return dalTHONGKECT.addTHONGKECT(g);
        }
        public bool upTHONGKECT(DTO_THONGKECT g)
        {
            return dalTHONGKECT.upTHONGKECT(g);
        }
        public bool delTHONGKECT(DTO_THONGKECT g)
        {
            return dalTHONGKECT.delTHONGKECT(g);
        }
    }
}
