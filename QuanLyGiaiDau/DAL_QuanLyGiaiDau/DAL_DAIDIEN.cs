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
    public class DAL_DAIDIEN : DBConnect
    {
        //Lay het user, pass
        public DataTable getDAIDIEN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM DAIDIEN", connect);
            DataTable dtDANGNHAP = new DataTable();
            data.Fill(dtDANGNHAP);
            return dtDANGNHAP;
        }
        //them
        public bool addDAIDIEN(DTO_DAIDIEN d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("INSERT INTO DAIDIEN(MaDD,MaDoi,TenNguoiDD) VALUES ('{0}',NULL,N'{1}')", d.MaDD, d.TenNguoiDD);
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
        public DataTable topDAIDIEN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM DAIDIEN ORDER BY LEFT(MaDD,PATINDEX('%[0-9]%',MaDD)-1),CONVERT(INT,SUBSTRING(MaDD,PATINDEX('%[0-9]%',MaDD),LEN(MaDD))) DESC", connect);
            DataTable dtDANGNHAP = new DataTable();
            data.Fill(dtDANGNHAP);
            return dtDANGNHAP;
        }
        //sua
        public bool upDAIDIEN(DTO_DAIDIEN d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("UPDATE DAIDIEN SET MaDoi='{0}', TenNguoiDD=N'{1}' WHERE MaDD='{2}'", d.MaDoi, d.TenNguoiDD, d.MaDD);
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
        public bool delDAIDIEN(DTO_DAIDIEN d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM DAIDIEN WHERE MaDD='{0}'", d.MaDD);
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
