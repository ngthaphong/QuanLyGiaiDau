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
        public void addVongChan(int vong, string mag)
        {
            DTO_VONG dtov = new DTO_VONG();
            BUS_TRANDAU td = new BUS_TRANDAU();
            switch (vong<=1?"ck":vong<=2?"bk":vong<=4?"tk":vong<=8?"16":"32")
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
                    td.addTranDau(dtov.MaVong, 4);
                    addVONG(dtov);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    for (int i = 0; i <= 8; i++)
                    {
                        if (i % 2 == 0)
                            if (i + 8 == vong * 2) td.addTranDau(dtov.MaVong, i);
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
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    td.addTranDau(dtov.MaVong, 8);
                    dtov.MaVong = nextMa();
                    dtov.TenVong = "1/32";
                    addVONG(dtov);
                    for (int i = 0; i <= 16; i++)
                    {
                        if (i % 2 == 0)
                            if (i + 16 == vong * 2) td.addTranDau(dtov.MaVong, i);
                    }
                    break;
            }
        }
        public void addVongLe(int vong, int sodoi, string mag)
        {
            DTO_VONG dtov = new DTO_VONG();
            switch (vong)
            {
                case 1:
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    break;
                case 2:
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    break;
                case 3 - 4:
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    break;
                case 5 - 8:
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    break;
                default:
                    dtov.MaGiai = mag;
                    dtov.TenVong = "Chung Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Bán Kết";
                    addVONG(dtov);
                    dtov.TenVong = "Tứ Kết";
                    addVONG(dtov);
                    dtov.TenVong = "1/16";
                    addVONG(dtov);
                    dtov.TenVong = "1/32";
                    addVONG(dtov);
                    break;
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
