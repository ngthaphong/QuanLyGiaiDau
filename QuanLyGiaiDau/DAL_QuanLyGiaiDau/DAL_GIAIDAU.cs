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
    public class DAL_GIAIDAU : DBConnect
    {
        //Lay het user, pass
        public DataTable getGIAIDAU()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM GIAIDAU", connect);
            DataTable dtGIAIDAU = new DataTable();
            data.Fill(dtGIAIDAU);
            return dtGIAIDAU;
        }
        //them
        public bool addGIAIDAU(DTO_GIAIDAU g)
        {
            try
            {
                connect.Open();
                string start = String.Format("{0:yyyy/MM/dd}", g.NgayBatDau);
                string end = String.Format("{0:yyyy/MM/dd}", g.NgayKetThuc);
                string sql = string.Format("INSERT INTO GIAIDAU(MaGiai,TenGiai,NgayBatDau,NgayKetThuc) VALUES ('{0}',N'{1}','{2}','{3}')", g.MaGiai, g.TenGiai, start, end);
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
        public DataTable topGIAIDAU()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM GIAIDAU ORDER BY LEFT(MaGiai,PATINDEX('%[0-9]%',MaGiai)-1),CONVERT(INT,SUBSTRING(MaGiai,PATINDEX('%[0-9]%',MaGiai),LEN(MaGiai))) DESC", connect);
            DataTable dtGIAIDAU = new DataTable();
            data.Fill(dtGIAIDAU);
            return dtGIAIDAU;
        }
        //sua
        public bool upGIAIDAU(DTO_GIAIDAU g)
        {
            try
            {
                connect.Open();
                string start = String.Format("{0:yyyy/MM/dd}", g.NgayBatDau);
                string end = String.Format("{0:yyyy/MM/dd}", g.NgayKetThuc);
                string sql = string.Format("UPDATE GIAIDAU SET TenGiai=N'{0}', NgayBatDau='{1}', NgayKetThuc='{2}' WHERE MaGiai='{3}'", g.TenGiai,start,end,g.MaGiai);
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
        public bool delGIAIDAU(DTO_GIAIDAU g)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM GIAIDAU WHERE MaGiai='{0}'", g.MaGiai);
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
