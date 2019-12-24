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
    public class BUS_DANGNHAP
    {
        DAL_DANGNHAP dalDANGNHAP = new DAL_DANGNHAP();
        public DataTable getDANGNHAP()
        {
            return dalDANGNHAP.getDANGNHAP();
        }
        public bool addDANGNHAP(DTO_DANGNHAP d)
        {
            return dalDANGNHAP.addDANGNHAP(d);
        }
        public DataTable topDANGNHAP()
        {
            return dalDANGNHAP.topDANGNHAP();
        }
        public string nextMa(string str)
        {
            BUS_DANGNHAP temp = new BUS_DANGNHAP();
            //get last matk
            DataTable t = temp.topDANGNHAP();
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
