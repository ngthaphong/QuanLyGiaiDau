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
    public class BUS_DAIDIEN
    {
        DAL_DAIDIEN dalDAIDIEN = new DAL_DAIDIEN();
        public DataTable getDAIDIEN()
        {
            return dalDAIDIEN.getDAIDIEN();
        }
        public bool addDAIDIEN(DTO_DAIDIEN g)
        {
            return dalDAIDIEN.addDAIDIEN(g);
        }
        public DataTable topDAIDIEN()
        {
            return dalDAIDIEN.topDAIDIEN();
        }
        public bool upDAIDIEN(DTO_DAIDIEN g)
        {
            return dalDAIDIEN.upDAIDIEN(g);
        }
        public bool delDAIDIEN(DTO_DAIDIEN g)
        {
            return dalDAIDIEN.delDAIDIEN(g);
        }
        public string nextMa(string str)
        {
            BUS_DAIDIEN temp = new BUS_DAIDIEN();
            //get last matk
            DataTable t = temp.topDAIDIEN();
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
