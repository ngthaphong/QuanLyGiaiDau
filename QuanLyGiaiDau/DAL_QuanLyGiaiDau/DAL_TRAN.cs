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
                string sql = string.Format("INSERT INTO TRAN(SoTran,TenVong) VALUES ({0},'{1}')", d.SoTran, d.TenVong);
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
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM LICHTD ORDER BY SoTran DESC", connect);
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
                string sql = string.Format("UPDATE LICHTD SET TenVong='{0}' WHERE SoTran={1}", d.TenVong, d.SoTran);
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
                string sql = string.Format("DELETE FROM TRAN WHERE SoTran={0}", d.SoTran);
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

