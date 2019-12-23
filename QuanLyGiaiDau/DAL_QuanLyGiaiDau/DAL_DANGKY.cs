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
    public class DAL_DANGKY : DBConnect
    {
        //Lay het user, pass
        public DataTable getDANGKY()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM DANGKY", connect);
            DataTable dtDANGKY = new DataTable();
            data.Fill(dtDANGKY);
            return dtDANGKY;
        }
        //them
        public bool addDANGKY(DTO_DANGKY d)
        {
            try
            {
                connect.Open();
                string ngaydk = String.Format("{0:yyyy/MM/dd}", d.NgayDangKy);
                string sql = string.Format("INSERT INTO DANGKY(MaGiai,MaDD,NgayDangKy,MaTK) VALUES ('{0}','{1}','{2}','{3}')", d.MaGiai,d.MaDD,ngaydk,d.MaTK);
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
        public DataTable topDANGKY()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM DANGKY ORDER BY MaGiai DESC", connect);
            DataTable dtDANGNHAP = new DataTable();
            data.Fill(dtDANGNHAP);
            return dtDANGNHAP;
        }
        //sua
        public bool upDANGKY(DTO_DANGKY d)
        {
            try
            {
                connect.Open();
                string ngaydk = String.Format("{0:yyyy/MM/dd}", d.NgayDangKy);
                string sql = string.Format("UPDATE DANGKY SET MaDD='{0}', NgayDangKy='{1}', MaTK='{2}' WHERE MaGiai='{3}'", d.MaDD,ngaydk,d.MaTK,d.MaGiai);
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
        public bool delDANGKY(DTO_DANGKY d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM DANGKY WHERE MaGiai='{0}'", d.MaGiai);
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

