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
        public DataTable getVONG()
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
                string sql = string.Format("INSERT INTO VONG(MaVong,MaGiai,TenVong) VALUES ('{0}','{1}',N'{2}')", d.MaVong, d.MaGiai, d.TenVong);
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
        //get vong by magiai
        
        public DataTable getVongbyMG(string mag)
        {
            string str = string.Format("SELECT* FROM VONG WHERE MaGiai='{0}' ORDER BY LEFT(MaVong, PATINDEX('%[0-9]%', MaVong)-1),CONVERT(INT, SUBSTRING(MaVong, PATINDEX('%[0-9]%', MaVong),LEN(MaVong)))",mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //top 1
        public DataTable topVONG()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM VONG ORDER BY LEFT(MaVong,PATINDEX('%[0-9]%',MaVong)-1),CONVERT(INT,SUBSTRING(MaVong,PATINDEX('%[0-9]%',MaVong),LEN(MaVong))) DESC", connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //sua
        public bool upVONG(DTO_VONG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE VONG SET MaGiai='{0}', TenVong=N'{1}' WHERE MaVong='{2}'", d.MaGiai,d.TenVong,d.MaVong);
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
                string sql = string.Format("DELETE FROM VONG WHERE MaVong='{0}'", d.MaVong);
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

