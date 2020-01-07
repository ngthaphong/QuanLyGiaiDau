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
        //lay ma giai 
        public DataTable getMaGiai(string mag)
        {
            string t = string.Format("SELECT * FROM GIAIDAU WHERE MaGiai='{0}'", mag);
            SqlDataAdapter data = new SqlDataAdapter(t, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //lay tengiai
        public DataTable getTenGiai(string teng)
        {
            string t = string.Format("SELECT * FROM GIAIDAU WHERE TenGiai like N'%{0}%'", teng);
            SqlDataAdapter data = new SqlDataAdapter(t, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //lay loai
        public DataTable getLoai(int loai)
        {
            string t = string.Format("SELECT * FROM GIAIDAU WHERE Loai={0}", loai);
            SqlDataAdapter data = new SqlDataAdapter(t, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //them
        public bool addGIAIDAU(DTO_GIAIDAU g)
        {
            try
            {
                connect.Open();
                string start = string.Format("{0:yyyy/MM/dd}", g.NgayBatDau);
                string end = string.Format("{0:yyyy/MM/dd}", g.NgayKetThuc);
                string sql = "";
                sql += "INSERT INTO GIAIDAU(MaGiai,TenGiai,NgayBatDau,NgayKetThuc,SoDoi,SoThanhVien,DiemThang,DiemHoa,DiemThua,SoLuot,Loai) ";
                sql += "VALUES (@MA,@TEN,@DS,@DE,@SD,@STV,@DTG,@DH,@DTH,@LUOT,@LOAI)";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType= CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@MA", g.MaGiai));
                cmd.Parameters.Add(new SqlParameter("@TEN", g.TenGiai));
                cmd.Parameters.Add(new SqlParameter("@DS", start));
                cmd.Parameters.Add(new SqlParameter("@DE", end));
                //Add param with confused beween two type
                cmd.Parameters.Add(new SqlParameter("@SD", (object)g.SoDoi ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@STV", (object)g.SoThanhVien ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@DTG", (object)g.DiemThang ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@DH", (object)g.DiemHoa ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@DTH", (object)g.DiemThua ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@LUOT", (object)g.SoLuot ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@LOAI", (object)g.Loai ?? DBNull.Value));
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
                string start = string.Format("{0:yyyy/MM/dd}", g.NgayBatDau);
                string end = string.Format("{0:yyyy/MM/dd}", g.NgayKetThuc);
                string sql = "UPDATE GIAIDAU SET TenGiai=@TE, NgayBatDau=@DS, NgayKetThuc=@DE, SoDoi=@SD, SoThanhVien=@STV, ";
                sql+="DiemThang=@DTG, DiemHoa=@DH, DiemThua=@DTH, SoLuot=@LUOT, Loai=@LOAI WHERE MaGiai=@MA";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@MA", g.MaGiai));
                cmd.Parameters.Add(new SqlParameter("@TEN", g.TenGiai));
                cmd.Parameters.Add(new SqlParameter("@DS", start));
                cmd.Parameters.Add(new SqlParameter("@DE", end));
                //Add param with null-coalescing operator
                cmd.Parameters.Add(new SqlParameter("@SD", (object)g.SoDoi ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@STV", (object)g.SoThanhVien ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@DTG", (object)g.DiemThang ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@DH", (object)g.DiemHoa ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@DTH", (object)g.DiemThua ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@LUOT", (object)g.SoLuot ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@LOAI", (object)g.Loai ?? DBNull.Value));
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
