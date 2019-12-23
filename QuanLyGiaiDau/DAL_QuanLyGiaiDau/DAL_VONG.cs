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
                string sql = string.Format("INSERT INTO VONG(MaGiai,TenVong) VALUES ('{0}','{1}')", d.MaGiai, d.TenVong);
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
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM VONG ORDER BY MaGiai DESC", connect);
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
                string sql = string.Format("UPDATE VONG SET TenVong='{0}' WHERE MaGiai='{1}'", d.TenVong, d.MaGiai);
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
                string sql = string.Format("DELETE FROM VONG WHERE MaGiai='{0}'", d.MaGiai);
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

