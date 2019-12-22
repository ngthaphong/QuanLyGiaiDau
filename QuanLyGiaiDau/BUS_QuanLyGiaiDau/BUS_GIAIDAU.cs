using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyGiaiDau;
using DTO_QuanLyGiaiDau;
using System.Data;

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
    }
}
