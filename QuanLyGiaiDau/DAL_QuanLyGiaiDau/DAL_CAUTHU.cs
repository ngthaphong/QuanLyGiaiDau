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
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM CAUTHU ORDER BY MaCT DESC", connect);
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
        public bool delCAUTHU(DTO_CAUTHU d)
        {
            try
            {
                connect.Open();
                string sql = string.Format("DELETE FROM CAUTHU WHERE MaTK='{0}'", d.MaCT);
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

