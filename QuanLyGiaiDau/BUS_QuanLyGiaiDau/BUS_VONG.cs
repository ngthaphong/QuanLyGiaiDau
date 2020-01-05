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
    public class BUS_VONG
    {
        DAL_VONG dalVONG = new DAL_VONG();
        public void addVongChan(int sodoi, string mag)
        {
            int vong = sodoi / 2;
            DTO_VONG dtov = new DTO_VONG();
            BUS_TRANDAU td = new BUS_TRANDAU();
            switch (vong<=1?"ck":vong<=2?"bk":vong<=4?"tk":vong<=8?"8":vong <= 16?"16": vong<=32?"32":"sai")
            {
                case "ck":
                    dtov.MaVong=nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";  
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    break;
                case "bk":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    break;
                case "tk":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    if (vong == 3) td.addTranDau(dtov.MaVong, 2);
                    td.addTranDau(dtov.MaVong, 4);
                    break;
                case "8":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 4);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/8";
                    addVONG(dtov);
                    for (int i = 0; i <= 8; i++)
                    {
                        if (i % 2 == 0)
                            if (i + 8 == vong * 2) td.addTranDau(dtov.MaVong, i);
                    }
                    break;
                case "16":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 4);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/8";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 8);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    for (int i = 0; i <= 16; i++)
                    {
                        if (i % 2 == 0)
                            if (i + 16 == vong * 2) td.addTranDau(dtov.MaVong, i);
                    }
                    break;
                case "32":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 4);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/8";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 8);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 16);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/32";
                    addVONG(dtov);
                    for (int i = 0; i <= 32; i++)
                    {
                        if (i % 2 == 0)
                            if (i + 32 == vong * 2) td.addTranDau(dtov.MaVong, i);
                    }
                    break;

            }
        }
        public void addVongLe(int sodoi, string mag)
        {
            BUS_TRANDAU td = new BUS_TRANDAU();
            DTO_VONG dtov = new DTO_VONG();
            switch (sodoi<=3?"bk":sodoi<=7?"tk":sodoi<=15?"8":sodoi<=31?"16":sodoi<=63?"32":"sai")
            {
                case "bk":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    break;
                case "tk":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    if (sodoi == 5) td.addTranDau(dtov.MaVong, 1);
                    td.addTranDau(dtov.MaVong, 3);
                    break;
                case "8":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 4);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/8";
                    addVONG(dtov);
                    for (int i = 0; i <= 8; i++)
                    {
                        if (i % 2 != 0)
                            if (i + 8 == sodoi) td.addTranDau(dtov.MaVong, i);
                    }
                    break;
                case "16":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 4);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/8";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 8);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    for (int i = 0; i <= 16; i++)
                    {
                        if (i % 2 != 0)
                            if (i + 16 == sodoi) td.addTranDau(dtov.MaVong, i);
                    }
                    break;
                case "32":
                    dtov.MaVong = nextMa();
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 1);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 2);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 4);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/8";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 8);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 16);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/32";
                    addVONG(dtov);
                    for (int i = 0; i <= 32; i++)
                    {
                        if (i % 2 != 0)
                            if (i + 32 == sodoi) td.addTranDau(dtov.MaVong, i);
                    }
                    break;
            }
        }
        public void addVongTron(int sodoi, string mag, int soluot)
        {
            DTO_VONG dtov = new DTO_VONG();
            BUS_TRANDAU td = new BUS_TRANDAU();
            string mav="";
            //add vong
            for(int i = 0; i < sodoi-1; i++)
            {
                mav = nextMa();
                dtov.MaVong = mav;
                dtov.MaGiai = mag;
                dtov.TenVong = (i + 1).ToString();
                addVONG(dtov);
                //add tran
                for (int j = 0; j < sodoi / 2; j++)
                {
                    td.addTranDau(mav, soluot);
                }
            }
            
        }
        public string nextMa()
        {
            string str = "MV";
            //get last matk
            DataTable t = topVONG();
            string Tmag = t.Rows[0].Field<string>(0);
            //get int in a string to add 1 after string
            string mastr = Regex.Match(Tmag, @"\d+").Value;
            int ma = Int32.Parse(mastr);
            ma++; mastr = null;
            mastr += str; mastr += ma;
            return mastr;
        }
        public DataTable getVONG()
        {
            return dalVONG.getVONG();
        }
        public bool addVONG(DTO_VONG g)
        {
            return dalVONG.addVONG(g);
        }
        public DataTable topVONG()
        {
            return dalVONG.topVONG();
        }
        public bool upVONG(DTO_VONG g)
        {
            return dalVONG.upVONG(g);
        }
        public bool delVONG(DTO_VONG g)
        {
            return dalVONG.delVONG(g);
        }
    }
}
