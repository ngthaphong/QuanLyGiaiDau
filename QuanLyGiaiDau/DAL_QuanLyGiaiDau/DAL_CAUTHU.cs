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
    public class DAL_CAUTHU : DBConnect
    {
        public DataTable getThongKe(string mad, string ten)
        {
            string str = string.Format("SELECT T.HoTenCT,BanThang,TheVang,TheDo FROM THONGKECT T,DOI D, CAUTHU C WHERE C.MaDoi=D.MaDoi AND D.MaDoi=T.MaDoi AND T.MaDoi='{0}' AND T.HoTenCT=N'{1}' GROUP BY T.HoTenCT,BanThang,TheVang,TheDo", mad,ten);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        //get tendoi by madoi
        public DataTable getMADOI(string mad)
        {
            string str = string.Format("SELECT TenDoi FROM CAUTHU CT, DOI D WHERE CT.MaDoi=D.MaDoi AND CT.MaDoi='{0}' GROUP BY TenDoi", mad);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable dtCAUTHU = new DataTable();
            data.Fill(dtCAUTHU);
            return dtCAUTHU;
        }
        //Lay het user, pass
        public DataTable getCAUTHU()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM CAUTHU", connect);
            DataTable dtCAUTHU = new DataTable();
            data.Fill(dtCAUTHU);
            return dtCAUTHU;
        }
        //them
        public bool addCAUTHU(DTO_CAUTHU d)
        {
            try
            {
                connect.Open();
                string ngaysinh = String.Format("{0:yyyy/MM/dd}", d.NgaySinh);
                string sql = string.Format("INSERT INTO CAUTHU(MaCT,MaDoi,HoTenCT,NgaySinh,SoAo,ViTri) VALUES ('{0}','{1}',N'{2}','{3}',{4},N'{5}')", d.MaCT, d.MaDoi, d.HoTenCT, ngaysinh, d.SoAo, d.ViTri);
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
        public DataTable topCAUTHU()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM CAUTHU ORDER BY LEFT(MaCT,PATINDEX('%[0-9]%',MaCT)-1),CONVERT(INT,SUBSTRING(MaCT,PATINDEX('%[0-9]%',MaCT),LEN(MaCT))) DESC", connect);
            DataTable dtCAUTHU = new DataTable();
            data.Fill(dtCAUTHU);
            return dtCAUTHU;
        }
        //sua
        public bool upCAUTHU(DTO_CAUTHU d)
        {
            try
            {
                connect.Open();
                string ngaysinh = String.Format("{0:yyyy/MM/dd}", d.NgaySinh);
                string sql = string.Format("UPDATE CAUTHU SET MaDoi='{0}', HoTenCT=N'{1}', NgaySinh='{2}', SoAo={3}, ViTri=N'{4}' WHERE MaCT='{5}'", d.MaDoi, d.HoTenCT, ngaysinh, d.SoAo, d.ViTri, d.MaCT);
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
        public bool delCAUTHU(string mact)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM CAUTHU WHERE MaCT='{0}'", mact);
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

