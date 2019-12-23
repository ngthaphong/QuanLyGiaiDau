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
    public class DAL_THONGKECT : DBConnect
    {
        //Lay het user, pass
        public DataTable getTHONGKECT()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM THONGKECT", connect);
            DataTable dtTHONGKECT = new DataTable();
            data.Fill(dtTHONGKECT);
            return dtTHONGKECT;
        }
        //them
        public bool addTHONGKECT(DTO_THONGKECT d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO THONGKECT(MaGiai,MaDoi,HoTenCT,SoAo,BanThang,TheVang,TheDo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", d.MaGiai, d.MaDoi, d.HoTenCT, d.SoAo, d.BanThang, d.TheVang, d.TheDo);
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
        public DataTable topTHONGKECT()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM LICHTD ORDER BY MaGiai DESC", connect);
            DataTable dtTHONGKECT = new DataTable();
            data.Fill(dtTHONGKECT);
            return dtTHONGKECT;
        }
        //sua
        public bool upTHONGKECT(DTO_THONGKECT d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE THONGKECT SET MaDoi='{0}', HoTenCT=N'{1}', SoAo={2}, BanThang={3}, TheVang={4}, TheDo={5} WHERE MaGiai='{6}'", d.MaDoi, d.HoTenCT, d.SoAo, d.BanThang, d.TheVang, d.TheDo, d.MaGiai);
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
        public bool delTHONGKECT(DTO_THONGKECT d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM THONGKECT WHERE MaGiai='{0}'", d.MaGiai);
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

