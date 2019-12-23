using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyGiaiDau;
using DTO_QuanLyGiaiDau;
using System.Data;


namespace BUS_QuanLyGiaiDau
{
    public class BUS_DOI
    {
        DAL_DOI dalDOI = new DAL_DOI();
        public DataTable getDOI()
        {
            return dalDOI.getDOI();
        }
        public bool addDOI(DTO_DOI g)
        {
            return dalDOI.addDOI(g);
        }
        public DataTable topDOI()
        {
            return dalDOI.topDOI();
        }
        public bool upDOI(DTO_DOI g)
        {
            return dalDOI.upDOI(g);
        }
        public bool delDOI(DTO_DOI g)
        {
            return dalDOI.delDOI(g);
        }
    }
}
