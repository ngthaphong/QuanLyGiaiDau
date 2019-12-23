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
                string sql = string.Format("INSERT INTO THONGKECT(MaTK,username,password) VALUES ('{0}','{1}','{2}')", d.MaTK, d.username, d.password);
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
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM LICHTD ORDER BY MaTK DESC", connect);
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
                string sql = string.Format("UPDATE THONGKECT SET username='{0}', password='{1}' WHERE MaTK='{3}'", d.username, d.password, d.MaTK);
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
                string sql = string.Format("DELETE FROM THONGKECT WHERE MaTK='{0}'", d.MaTK);
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

