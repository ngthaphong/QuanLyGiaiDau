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
    public class BUS_DANGKY
    {
        DAL_DANGKY dalDANGKY = new DAL_DANGKY();
        public DataTable getDANGKY()
        {
            return dalDANGKY.getDANGKY();
        }
        public bool addDANGKY(DTO_DANGKY g)
        {
            return dalDANGKY.addDANGKY(g);
        }
        public DataTable topDANGKY()
        {
            return dalDANGKY.topDANGKY();
        }
        public bool upDANGKY(DTO_DANGKY g)
        {
            return dalDANGKY.upDANGKY(g);
        }
        public bool delDANGKY(DTO_DANGKY g)
        {
            return dalDANGKY.delDANGKY(g);
        }
        public string nextMa(string str)
        {
            BUS_DANGKY temp = new BUS_DANGKY();
            //get last matk
            DataTable t = temp.topDANGKY();
            string Tmag = t.Rows[0].Field<string>(0);
            //get int in a string to add 1 after string
            string mastr = Regex.Match(Tmag, @"\d+").Value;
            int ma = Int32.Parse(mastr);
            ma++; mastr = null;
            mastr += str; mastr += ma;
            return mastr;
        }
    }
}
