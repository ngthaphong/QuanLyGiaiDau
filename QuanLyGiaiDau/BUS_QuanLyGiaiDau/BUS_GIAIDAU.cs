﻿using System;
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
        public DataTable getGIAIDAU()
        {
            return dalGIAIDAU.getGIAIDAU();
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
    }
}
