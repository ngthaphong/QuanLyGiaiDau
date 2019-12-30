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
    public class BUS_DOI
    {
        DAL_DOI dalDOI = new DAL_DOI();
        public string nextMa(string str)
        {
            //get last matk
            DataTable t = topDOI();
            string Tmag = t.Rows[0].Field<string>(0);
            //get int in a string to add 1 after string
            string mastr = Regex.Match(Tmag, @"\d+").Value;
            int ma = Int32.Parse(mastr);
            ma++; mastr = null;
            mastr += str; mastr += ma;
            return mastr;
        }
        public DataTable getLimited()
        {
            DataTable t = dalDOI.getRegister();
            //gom 3 cot:ma doi, ten doi, so lan xuat hien
            foreach(DataRow r in t.Rows)
            {
                //so cau thu >= so thanh vien thi xoa' row do'
                if(r.Field<int>(3) >= r.Field<int>(2)) r.Delete();
            }
            t.AcceptChanges();
            return t;
        }
        public DataTable getSTV(string madd)
        {
            return dalDOI.getSTV(madd);
        }
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
