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
    public class DAL_CAUTHU : DBConnect
    {
        //Lay het user, pass
        public DataTable getCAUTHU()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM DANGKY", connect);
            DataTable dtCAUTHU = new DataTable();
            data.Fill(dtCAUTHU);
            return dtCAUTHU;
        }
        //them
        public bool addDANGKY(DTO_CAUTHU d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO CAUTHU(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
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
        public DataTable topCAUTHU()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM DANGNHAP ORDER BY MaTK DESC", connect);
            DataTable dtCAUTHU = new DataTable();
            data.Fill(dtCAUTHU);
            return dtCAUTHU;
        }
        //sua
        public bool upCAUTHU(DTO_CAUTHU d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE CAUTHU SET username='{0}', password='{1}' WHERE MaTK='{3}'", d.username, d.password, d.MaTK);
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
        public bool delCAUTHU(DTO_CAUTHU d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM CAUTHU WHERE MaTK='{0}'", d.MaTK);
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

