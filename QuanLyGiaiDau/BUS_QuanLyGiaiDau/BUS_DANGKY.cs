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
    public class BUS_DANGKY
    {
        DAL_DANGKY dalDANGKY = new DAL_DANGKY();
        public DataTable getDANGKY()
        {
            return dalDANGKY.getDANGKY();
        }
        public bool addDANGKY(DTO_DANGKY g)
        {
            return dalDANGKY.addDANGKY(g);
        }
        public bool upDANGKY(DTO_DANGKY g)
        {
            return dalDANGKY.upDANGKY(g);
        }
        public bool delDANGKY(DTO_DANGKY g)
        {
            return dalDANGKY.delDANGKY(g);
        }
    }
}
