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
    public class BUS_GIAIDAU
    {
        DAL_GIAIDAU dalGIAIDAU = new DAL_GIAIDAU();
        public string nextMa(string str)
        {
            BUS_GIAIDAU temp = new BUS_GIAIDAU();
            //get last matk
            DataTable t = temp.topGIAIDAU();
            string Tmag = t.Rows[0].Field<string>(0);
            //get int in a string to add 1 after string
            string mastr = Regex.Match(Tmag, @"\d+").Value;
            int ma = Int32.Parse(mastr);
            ma++; mastr = null;
            mastr += str; mastr += ma;
            return mastr;
        }
        public bool checkSoDoi1(int? so)
        {
            if (so < 2 || so > 64) return false;
            else return true;
        }
        public bool checkSoDoi2(int? so)
        {
            if (so < 2 || so > 30) return false;
            else return true;
        }
        public DataTable getLoai(int loai)
        {
            return dalGIAIDAU.getLoai(loai);
        }
        public DataTable getTenGiai(string teng)
        {
            return dalGIAIDAU.getTenGiai(teng);
        }
        public DataTable getGIAIDAU()
        {
            return dalGIAIDAU.getGIAIDAU();
        }
        public DataTable getMaGiai(string mag)
        {
            return dalGIAIDAU.getMaGiai(mag);
        }
        public bool addGIAIDAU(DTO_GIAIDAU g)
        {
            return dalGIAIDAU.addGIAIDAU(g);
        }
        public DataTable topGIAIDAU()
        {
            return dalGIAIDAU.topGIAIDAU();
        }
        public bool upGIAIDAU(DTO_GIAIDAU g)
        {
            return dalGIAIDAU.upGIAIDAU(g);
        }
        public bool delGIAIDAU(DTO_GIAIDAU g)
        {
            return dalGIAIDAU.delGIAIDAU(g);
        }
    }
}
