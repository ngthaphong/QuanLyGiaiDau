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
    public class DAL_TRANDAU : DBConnect
    {
        //Lay het user, pass
        public DataTable getTRAN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM TRANDAU", connect());
            DataTable dtTRAN = new DataTable();
            data.Fill(dtTRAN);
            return dtTRAN;
        }
        //them
        public bool addTRAN(DTO_TRANDAU d)
        {
            try
            {
                connect().Open();
                string sql = string.Format("INSERT INTO TRANDAU(MaTran,MaVong,SoTran) VALUES ('{0}','{1}',{2})", d.MaTran,d.MaVong,d.SoTran);
                SqlCommand cmd = new SqlCommand(sql, connect());
                //kiem tra
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e) { }
            finally
            {
                //close connect()
                connect().Close();
            }
            return false;
        }
        //top 1
        public DataTable topTRAN()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM TRANDAU ORDER BY LEFT(MaTran,PATINDEX('%[0-9]%',MaTran)-1),CONVERT(INT,SUBSTRING(MaTran,PATINDEX('%[0-9]%',MaTran),LEN(MaTran))) DESC", connect());
            DataTable dtTRAN = new DataTable();
            data.Fill(dtTRAN);
            return dtTRAN;
        }
        //sua
        public bool upTRAN(DTO_TRANDAU d)
        {
            try
            {
                connect().Open();
                string sql = string.Format("UPDATE LICHTD SET MaVong='{0}', SoTran={1} WHERE MaTran='{2}'", d.MaVong,d.SoTran,d.MaTran);
                SqlCommand cmd = new SqlCommand(sql, connect());
                //kiem tra
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e) { }
            finally
            {
                connect().Close();
            }
            return false;
        }
        //xoa
        public bool delTRAN(DTO_TRANDAU d)
        {
            try
            {
                connect().Open();
                string sql = string.Format("DELETE FROM TRANDAU WHERE MaTran={0}", d.MaTran);
                SqlCommand cmd = new SqlCommand(sql, connect());
                //kiem tra
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception e) { }
            finally
            {
                connect().Close();
            }
            return false;
        }
    }
}

