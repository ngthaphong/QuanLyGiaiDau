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
        protected SqlConnection connect()
        {
            SqlConnection conn=new SqlConnection();
            try
            {
                conn = new SqlConnection("data source=PHONG-ALIENWARE;initial catalog=QuanLyGiaiDau;integrated security=True");
                return conn;
            }
            catch
            {
                try
                {
                    conn = new SqlConnection("data source=HUNGNGUYEN\\SQLEXPRESS;initial catalog=QuanLyGiaiDau;integrated security=True");
                    return conn;
                }
                catch (Exception e) { }
            }
            return conn;
        }
    }
}
