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
    public class DAL_TRAN : DBConnect
    {
        //Lay het user, pass
        public DataTable getTRAN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM TRAN", connect);
            DataTable dtTRAN = new DataTable();
            data.Fill(dtTRAN);
            return dtTRAN;
        }
        //them
        public bool addTRAN(DTO_TRAN d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO TRAN(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
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
        public DataTable topTRAN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM LICHTD ORDER BY MaTK DESC", connect);
            DataTable dtTRAN = new DataTable();
            data.Fill(dtTRAN);
            return dtTRAN;
        }
        //sua
        public bool upTRAN(DTO_TRAN d)
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
        public bool delTRAN(DTO_TRAN d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM TRAN WHERE MaTK='{0}'", d.MaTK);
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

