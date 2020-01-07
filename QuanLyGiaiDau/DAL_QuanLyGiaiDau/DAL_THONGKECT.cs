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
        public DataTable getEmpty(string mag, string mad)
        {
            string str = string.Format("SELECT * FROM THONGKECT WHERE MaGiai='{0}' AND MaDoi='{1}'",mag,mad);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
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
                string sql = string.Format("INSERT INTO THONGKECT(MaGiai,MaDoi,HoTenCT,SoAo,BanThang,TheVang,TheDo) VALUES ('{0}','{1}',N'{2}','{3}','{4}','{5}','{6}')", d.MaGiai, d.MaDoi, d.HoTenCT, d.SoAo, d.BanThang, d.TheVang, d.TheDo);
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
        //sua
        public bool upTHONGKECT(DTO_THONGKECT d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE THONGKECT SET BanThang={0}, TheVang={1}, TheDo={2} WHERE MaGiai='{3}' AND MaDoi='{4}' AND HoTenCT=N'{5}' AND SoAo={6}", d.BanThang,d.TheVang,d.TheDo,d.MaGiai,d.MaDoi,d.HoTenCT,d.SoAo);
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

