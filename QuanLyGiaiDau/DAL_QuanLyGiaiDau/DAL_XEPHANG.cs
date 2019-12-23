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
    public class DAL_XEPHANG : DBConnect
    {
        //Lay het user, pass
        public DataTable getXEPHANG()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM XEPHANG", connect);
            DataTable dtXEPHANG = new DataTable();
            data.Fill(dtXEPHANG);
            return dtXEPHANG;
        }
        //them
        public bool addXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO XEPHANG(MaGiai,MaDoi,TongDiem,HieuSo,ViThu) VALUES ('{0}','{1}',{2},{3},{4})", d.MaGiai, d.MaDoi, d.TongDiem,d.HieuSo,d.ViThu);
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
        public DataTable topXEPHANGT()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM XEPHANG ORDER BY MaGiai DESC", connect);
            DataTable dtXEPHANG = new DataTable();
            data.Fill(dtXEPHANG);
            return dtXEPHANG;
        }
        //sua
        public bool upXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE XEPHANG SET MaDoi='{0}', TongDiem={1}, HieuSo={2}, ViThu={3} WHERE MaGiai='{4}'", d.MaDoi, d.TongDiem, d.HieuSo, d.ViThu, d.MaGiai);
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
        public bool delXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM XEPHANG WHERE MaGiai='{0}'", d.MaGiai);
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

