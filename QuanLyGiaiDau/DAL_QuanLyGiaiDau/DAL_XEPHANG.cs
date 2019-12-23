using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLyGiaiDau;

namespace DAL_QuanLyGiaiDau
{
    public class DAL_XEPHANG : DBConnect
    {
        //Lay het user, pass
        public DataTable getXEPHANG()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM XEPHANG", connect);
            DataTable dtXEPHANG = new DataTable();
            data.Fill(dtXEPHANG);
            return dtXEPHANG;
        }
        //them
        public bool addXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO XEPHANG(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
                SqlCommand cmd = new SqlCommand(sql, connect);
                //kiem tra
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e) { }
            finally
            {
                //close connect
                connect.Close();
            }
            return false;
        }
        //top 1
        public DataTable topXEPHANGT()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM XEPHANG ORDER BY MaTK DESC", connect);
            DataTable dtXEPHANG = new DataTable();
            data.Fill(dtXEPHANG);
            return dtXEPHANG;
        }
        //sua
        public bool upXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE XEPHANG SET username='{0}', password='{1}' WHERE MaTK='{3}'", d.username, d.password, d.MaTK);
                SqlCommand cmd = new SqlCommand(sql, connect);
                //kiem tra
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e) { }
            finally
            {
                connect.Close();
            }
            return false;
        }
        //xoa
        public bool delXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM XEPHANG WHERE MaTK='{0}'", d.MaTK);
                SqlCommand cmd = new SqlCommand(sql, connect);
                //kiem tra
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e) { }
            finally
            {
                connect.Close();
            }
            return false;
        }
    }
}

