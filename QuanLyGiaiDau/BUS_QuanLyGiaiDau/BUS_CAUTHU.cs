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
        public DataTable tableLimitCauThu()
        {
            DataTable cauthu = getCAUTHU();
            cauthu.Columns.Remove("SoAo");
            cauthu.Columns.Remove("ViTri");
            DataTable temp;
            foreach (DataRow r in cauthu.Rows)
            {
                string ten = "";
                string mad = r.Field<string>(1);
                temp = getMADOI(mad);
                if (!string.IsNullOrEmpty(temp.Rows[0].Field<string>(0))) ten = temp.Rows[0].Field<string>(0);
                r.SetField<string>(1, ten);
            }
            cauthu.AcceptChanges();
            return cauthu;
        }
        public DataTable tableCauThu()
        {
            DataTable cauthu = getCAUTHU();
            cauthu.Columns.Remove("MaCT");
            DataTable temp;
                foreach (DataRow r in cauthu.Rows)
                {
                    string ten = "";
                    string mad = r.Field<string>(0);
                    temp = getMADOI(mad);
                    if (!string.IsNullOrEmpty(temp.Rows[0].Field<string>(0))) ten = temp.Rows[0].Field<string>(0);
                    r.SetField<string>(0, ten);
                }
            cauthu.AcceptChanges();
            return cauthu;
        }
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

        public DataTable getMADOI(string mad)
        {
            return dalCAUTHU.getMADOI(mad);
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
        public bool delCAUTHU(string mact)
        {
            return dalCAUTHU.delCAUTHU(mact);
        }
        
    }
}
