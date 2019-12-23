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
    public class DAL_DANGNHAP : DBConnect
    {
        //Lay het user, pass
        public DataTable getDANGNHAP()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM DANGNHAP", connect);
            DataTable dtDANGNHAP = new DataTable();
            data.Fill(dtDANGNHAP);
            return dtDANGNHAP;
        }
        //them
        public bool addDANGNHAP(DTO_DANGNHAP d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO DANGNHAP(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
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
        public DataTable topDANGNHAP()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM DANGNHAP ORDER BY MaTK DESC", connect);
            DataTable dtDANGNHAP = new DataTable();
            data.Fill(dtDANGNHAP);
            return dtDANGNHAP;
        }
        //sua
        public bool upDANGNHAP(DTO_DANGNHAP d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE DANGNHAP SET username='{0}', password='{1}' WHERE MaTK='{2}'", d.username, d.password, d.MaTK);
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
        public bool delDANGNHAP(DTO_DANGNHAP d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM DANGNHAP WHERE MaTK='{0}'", d.MaTK);
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
