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
    public class DAL_LICHTD : DBConnect
    {
        //Lay het user, pass
        public DataTable getLICHTD()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM LICHTD", connect);
            DataTable dtLICHTD = new DataTable();
            data.Fill(dtLICHTD);
            return dtLICHTD;
        }
        //lay sotran thong qua magiai;
        public DataTable getRange(string mag)
        {
            //table: matran,mavong,tenvong,sotran
            string str = string.Format("SELECT MaTran,V.MaVong,TenVong,SoTran FROM TRANDAU TD, VONG V WHERE V.MaVong=TD.MaVong AND V.MaGiai='{0}' ORDER BY LEFT(MaTran,PATINDEX('%[0-9]%',MaTran)-1),CONVERT(INT,SUBSTRING(MaTran,PATINDEX('%[0-9]%',MaTran),LEN(MaTran))) DESC", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //lay cac doi thong qua magiai
        public DataTable getTeam(string mag)
        {
            //table: tendoi
            string str = string.Format("SELECT D.TenDoi FROM GIAIDAU G, DANGKY DK, DAIDIEN DD, DOI D WHERE G.MaGiai=DK.MaGiai AND DK.MaDD=DD.MaDD AND DD.MaDoi=D.MaDoi AND G.MaGiai='{0}'", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //lay ban thang
        public DataTable getGoal(string mat)
        {
            //table: tendoi
            string str = string.Format("SELECT BanThang1,BanThang2 FROM LICHTD WHERE MaTran='{0}'", mat);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //them
        public bool addLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string time;
                if (string.Format("{0:yyyy/MM/dd HH:mm:ss}", d.ThoiGianDienRa) == "") time = null;
                else time = string.Format("{0:yyyy/MM/dd HH:mm:ss}", d.ThoiGianDienRa);
                string sql = "";
                sql += "INSERT INTO LICHTD(MaTran,TenDoi1,TenDoi2,ThoiGianDienRa,TrongTai,BanThang1,BanThang2,TheVang1,TheVang2,TheDo1,TheDo2,SoDiem1,SoDiem2) ";
                sql += "VALUES (@MA,@TEN1,@TEN2,@TIME,@TT,@BT1,@BT2,@TV1,@TV2,@TD1,@TD2,@SD1,@SD2)";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@MA", d.MaTran));
                cmd.Parameters.Add(new SqlParameter("@TEN1", d.TenDoi1));
                cmd.Parameters.Add(new SqlParameter("@TEN2", d.TenDoi2));
                //Add param with confused beween two type
                cmd.Parameters.Add(new SqlParameter("@TIME", (object)time ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@TT", (object)d.TrongTai ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@BT1", (object)d.BanThang1 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@BT2", (object)d.BanThang2 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@TV1", (object)d.TheVang1 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@TV2", (object)d.TheVang2 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@TD1", (object)d.TheDo1 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@TD2", (object)d.TheDo2 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@SD1", (object)d.SoDiem1 ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@SD2", (object)d.SoDiem2 ?? DBNull.Value));
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
        public bool upLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string time = String.Format("{yyyy/MM/dd HH:mm:ss}", d.ThoiGianDienRa);
                string sql = string.Format("UPDATE LICHTD SET TenDoi1=N'{0}', TenDoi2=N'{1}',ThoiGianDienRa='{2}',TrongTai=N'{3}',BanThang1={4},BanThang2={5},TheVang1={6},TheVang2={7},TheDo1={8},TheDo2={9},SoDiem1={10},SoDiem2={11} WHERE MaTran='{12}'", d.TenDoi1, d.TenDoi2, time, d.TrongTai, d.BanThang1, d.BanThang2, d.TheVang1, d.TheVang2, d.TheDo1, d.TheDo2, d.SoDiem1, d.SoDiem2, d.MaTran);
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
        public bool delLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM LICHTD WHERE MaTran='{0}'", d.MaTran);
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

