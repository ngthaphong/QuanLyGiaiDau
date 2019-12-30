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
    public class BUS_TRANDAU
    {
        DAL_TRANDAU dalTRANDAU = new DAL_TRANDAU();
        public string nextMa()
        {
            string str = "MT";
            //get last matk
            DataTable t = topTRAN();
            string Tmag = t.Rows[0].Field<string>(0);
            //get int in a string to add 1 after string
            string mastr = Regex.Match(Tmag, @"\d+").Value;
            int ma = Int32.Parse(mastr);
            ma++; mastr = null;
            mastr += str; mastr += ma;
            return mastr;
        }
        public void addTranDau(string mav, int sotran)
        {
            DTO_TRANDAU dtot = new DTO_TRANDAU();
            dtot.MaTran = nextMa();
            dtot.MaVong = mav;
            dtot.SoTran = sotran;
            addTRAN(dtot);
        }
        public DataTable getTRAN()
        {
            return dalTRANDAU.getTRAN();
        }
        public bool addTRAN(DTO_TRANDAU g)
        {
            return dalTRANDAU.addTRAN(g);
        }
        public DataTable topTRAN()
        {
            return dalTRANDAU.topTRAN();
        }
        public bool upTRAN(DTO_TRANDAU g)
        {
            return dalTRANDAU.upTRAN(g);
        }
        public bool delTRAN(DTO_TRANDAU g)
        {
            return dalTRANDAU.delTRAN(g);
        }
    }
}
