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
    public class DAL_DANGKY : DBConnect
    {
        //Lay het user, pass
        public DataTable getDANGKY()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM DANGKY", connect);
            DataTable dtDANGKY = new DataTable();
            data.Fill(dtDANGKY);
            return dtDANGKY;
        }
        //them
        public bool addDANGKY(DTO_DANGKY d)
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
        public DataTable topDANGKY()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM DANGNHAP ORDER BY MaTK DESC", connect);
            DataTable dtDANGNHAP = new DataTable();
            data.Fill(dtDANGNHAP);
            return dtDANGNHAP;
        }
        //sua
        public bool upDANGKY(DTO_DANGKY d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE DANGNHAP SET username='{0}', password='{1}' WHERE MaTK='{3}'", d.username, d.password, d.MaTK);
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
        public bool delDANGKY(DTO_DANGKY d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM DANGKY WHERE MaTK='{0}'", d.MaTK);
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

