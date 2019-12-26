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
    public class DAL_DOI : DBConnect
    {
        //Lay het user, pass
        public DataTable getDOI()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM DOI", connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //get bang so cau thu dang ki vao doi
        public DataTable getRegister()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT d.MaDoi, d.TenDoi, d.SoThanhVien, COUNT(ct.MaCT) as SoCauThu FROM DOI d LEFT JOIN CAUTHU ct ON ct.MaDoi = d.MaDoi GROUP BY d.MaDoi, d.TenDoi, d.SoThanhVien", connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //them
        public bool addDOI(DTO_DOI g)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO DOI(MaDoi,TenDoi,TenHLV,DoiTruong,SoThanhVien,MauAo) VALUES ('{0}',N'{1}',N'{2}',N'{3}',{4},N'{5}')", g.MaDoi, g.TenDoi, g.TenHLV, g.DoiTruong,g.SoThanhVien,g.MauAo);
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
        //top 1 from below
        public DataTable topDOI()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM DOI ORDER BY LEFT(MaDoi,PATINDEX('%[0-9]%',MaDoi)-1),CONVERT(INT,SUBSTRING(MaDoi,PATINDEX('%[0-9]%',MaDoi),LEN(MaDoi))) DESC", connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //sua
        public bool upDOI(DTO_DOI g)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE DOI SET TenDoi=N'{0}', TenHLV=N'{1}', DoiTruong=N'{2}', SoThanhVien={3}, MauAo=N'{4}' WHERE MaDoi='{5}'", g.TenDoi, g.TenHLV, g.DoiTruong, g.SoThanhVien, g.MauAo ,g.MaDoi);
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
        public bool delDOI(DTO_DOI g)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM DOI WHERE MaDoi='{0}'", g.MaDoi);
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
