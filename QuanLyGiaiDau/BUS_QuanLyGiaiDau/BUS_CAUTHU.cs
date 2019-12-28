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
    public class BUS_CAUTHU
    {
        DAL_CAUTHU dalCAUTHU = new DAL_CAUTHU();
        public string nextMa()
        {
            string str = "CT";
            //get last matk
            DataTable t = topCAUTHU();
            string Tmag = t.Rows[0].Field<string>(0);
            //get int in a string to add 1 after string
            string mastr = Regex.Match(Tmag, @"\d+").Value;
            int ma = Int32.Parse(mastr);
            ma++; mastr = null;
            mastr += str; mastr += ma;
            return mastr;
        }
        public DataTable getCAUTHU()
        {
            return dalCAUTHU.getCAUTHU();
        }
        public bool addCAUTHU(DTO_CAUTHU g)
        {
            return dalCAUTHU.addCAUTHU(g);
        }
        public DataTable topCAUTHU()
        {
            return dalCAUTHU.topCAUTHU();
        }
        public bool upCAUTHU(DTO_CAUTHU g)
        {
            return dalCAUTHU.upCAUTHU(g);
        }
        public bool delCAUTHU(DTO_CAUTHU g)
        {
            return dalCAUTHU.delCAUTHU(g);
        }
        
    }
}
