using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLyGiaiDau
{
    public class DBConnect
    {
        protected SqlConnection connect = new SqlConnection("data source=HUNGNGUYEN\SQLEXPRESS;initial catalog=QuanLyGiaiDau;integrated security=True");
    }
}
