﻿using System;
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
        //them
        public bool addLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string time = String.Format("{yyyy/MM/dd HH:mm:ss}", d.ThoiGianDienRa);
                string sql = string.Format("INSERT INTO LICHTD(MaDoi1,MaDoi2,SoTran,TenSan,ThoiGianDienRa,TrongTai,BanThang1,BanThang2,TheVang1,TheVang2,TheDo1,TheDo2,SoDiem1,SoDiem2) VALUES ('{0}','{1}',{2},N'{3}','{4}',N'{5}',{6},{7},{8},{9},{10},{11},{12},{13})", d.MaDoi1,d.MaDoi2,d.SoTran,d.TenSan,time,d.TrongTai,d.BanThang1,d.BanThang2,d.TheVang1,d.TheVang2,d.TheDo1,d.TheDo2,d.SoDiem1,d.SoDiem2);
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
        public DataTable topLICHTD()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT TOP 1 * FROM LICHTD ORDER BY MaDoi1 DESC", connect);
            DataTable dtLICHTD = new DataTable();
            data.Fill(dtLICHTD);
            return dtLICHTD;
        }
        //sua
        public bool upLICHTD(DTO_LICHTD d)
        {
            try
            {
                connect.Open();
                string time = String.Format("{yyyy/MM/dd HH:mm:ss}", d.ThoiGianDienRa);
                string sql = string.Format("UPDATE LICHTD SET MaDoi2='{0}',SoTran={1},TenSan=N'{2}',ThoiGianDienRa='{3}',TrongTai=N'{4}',BanThang1={5},BanThang2={6},TheVang1={7},TheVang2={8},TheDo1={9},TheDo2={10},SoDiem1={11},SoDiem2={12} WHERE MaDoi1='{13}'",  d.MaDoi2, d.SoTran, d.TenSan, time, d.TrongTai, d.BanThang1, d.BanThang2, d.TheVang1, d.TheVang2, d.TheDo1, d.TheDo2, d.SoDiem1, d.SoDiem2, d.MaDoi1);
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
                string sql = string.Format("DELETE FROM LICHTD WHERE MaDoi1='{0}'", d.MaDoi1);
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
