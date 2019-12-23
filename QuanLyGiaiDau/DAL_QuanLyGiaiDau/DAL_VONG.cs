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
    public class DAL_VONG : DBConnect
    {
        //Lay het user, pass
        public DataTable getTRAN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM VONG", connect);
            DataTable dtVONG = new DataTable();
            data.Fill(dtVONG);
            return dtVONG;
        }
        //them
        public bool addVONG(DTO_VONG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO VONG(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
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
        public DataTable topVONG()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM VONG ORDER BY MaTK DESC", connect);
            DataTable dtVONG = new DataTable();
            data.Fill(dtVONG);
            return dtVONG;
        }
        //sua
        public bool upVONG(DTO_VONG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE VONG SET username='{0}', password='{1}' WHERE MaTK='{3}'", d.username, d.password, d.MaTK);
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
        public bool delVONG(DTO_VONG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM VONG WHERE MaTK='{0}'", d.MaTK);
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

