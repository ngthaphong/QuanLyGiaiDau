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
    public class DAL_LICHTD : DBConnect
    {
        //Lay het user, pass
        public DataTable getLICHTD()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM LICHTD", connect);
            DataTable dtLICHTD = new DataTable();
            data.Fill(dtLICHTD);
            return dtLICHTD;
        }
        //them
        public bool addLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO LICHTD(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
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
        public DataTable topLICHTD()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM LICHTD ORDER BY MaTK DESC", connect);
            DataTable dtLICHTD = new DataTable();
            data.Fill(dtLICHTD);
            return dtLICHTD;
        }
        //sua
        public bool upLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE LICHTD SET username='{0}', password='{1}' WHERE MaTK='{3}'", d.username, d.password, d.MaTK);
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
        public bool delLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM LICHTD WHERE MaTK='{0}'", d.MaTK);
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

