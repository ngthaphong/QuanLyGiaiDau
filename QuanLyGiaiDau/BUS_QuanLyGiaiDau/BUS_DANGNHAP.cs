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
    }
}
