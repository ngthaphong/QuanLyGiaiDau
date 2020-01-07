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
        public DataTable getTenGiai(string mag)
        {
            string str = string.Format("SELECT * FROM GIAIDAU WHERE MaGiai='{0}'", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            return team;
        }
        public DataTable getTenDoi(string mad)
        {
            string str = string.Format("SELECT * FROM DOI WHERE MaDoi='{0}'", mad);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            return team;
        }
        public DataTable SortRank(string mag)
        {
            string str = string.Format("SELECT * FROM XEPHANG WHERE MaGiai='{0}' ORDER BY ViThu ASC", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            return team;
        }
        public DataTable SortwithTong(string mag)
        {
            string str = string.Format("SELECT * FROM XEPHANG WHERE MaGiai='{0}' ORDER BY TongDiem DESC",mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            return team;
        }
        public DataTable SortwithHieu(string mag)
        {
            string str = string.Format("SELECT * FROM XEPHANG WHERE MaGiai='{0}' ORDER BY HieuSo DESC",mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            return team;
        }
        //lay hieuso tu giai dau
        public DataTable getHieuSo(string mag)
        {
            //lay bang cac doi trong giai
            string str = string.Format("SELECT TenDoi1,TenDoi2,BanThang1,BanThang2 FROM GIAIDAU G, VONG V, TRANDAU T, LICHTD L WHERE G.MaGiai=V.MaGiai AND V.MaVong=T.MaVong AND T.MaTran=L.MaTran AND G.MaGiai='{0}'", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            int? subbt = 0;
            List<int?> hs1 = new List<int?>();
            List<int?> hs2 = new List<int?>();
            //lay hieu banthang tu banthang1
            for (int i=0;i<team.Rows.Count;i++)
            {
                subbt = 0;
                object obt1 = team.Rows[i].Field<int?>(2);
                object obt2 = team.Rows[i].Field<int?>(3);
                int? bt1 = obt1 == DBNull.Value ? null : (int?)obt1;
                int? bt2 = obt2 == DBNull.Value ? null : (int?)obt2;
                if (!string.IsNullOrEmpty(bt1.ToString()) && !string.IsNullOrEmpty(bt2.ToString())) subbt = bt1 - bt2;
                else if (string.IsNullOrEmpty(bt1.ToString())) subbt = 0 - bt2;
                else subbt = bt1 - 0;
                team.Rows[i][2] = (object)subbt ?? DBNull.Value;
                if (!string.IsNullOrEmpty(bt1.ToString()) && !string.IsNullOrEmpty(bt2.ToString())) subbt = bt2 - bt1;
                else if (string.IsNullOrEmpty(bt1.ToString())) subbt = 0 - bt1;
                else subbt = bt2 - 0;
                team.Rows[i][3] = (object)subbt ?? DBNull.Value;
            }
            team.AcceptChanges();
            ///////////////////
            str = string.Format("SELECT D.TenDoi,D.SoThanhVien FROM DOI D, DAIDIEN DD, DANGKY DK, GIAIDAU G, VONG V, TRANDAU T, LICHTD L WHERE D.MaDoi=DD.MaDoi AND DD.MaDD=DK.MaDD AND DK.MaGiai=G.MaGiai AND G.MaGiai=V.MaGiai AND V.MaVong=T.MaVong AND T.MaTran=L.MaTran AND G.MaGiai='{0}' GROUP BY D.TenDoi,D.SoThanhVien", mag);
            data = new SqlDataAdapter(str, connect);
            DataTable t = new DataTable();
            data.Fill(t);
            //reset to 0
            foreach (DataRow r in t.Rows) r[1] = 0;
            for(int i=0;i<t.Rows.Count;i++)
            {
                for(int j = 0; j < team.Rows.Count; j++)
                {
                    object obt1= team.Rows[j].Field<int?>(2) + (int)t.Rows[i][1];
                    int? bt1 = obt1 == DBNull.Value ? null : (int?)obt1;
                    if (t.Rows[i].Field<string>(0) == team.Rows[j].Field<string>(0)) t.Rows[i][1]=bt1;
                    object obt2 = team.Rows[j].Field<int?>(3) + (int)t.Rows[i][1];
                    int? bt2 = obt2 == DBNull.Value ? null : (int?)obt2;
                    if (t.Rows[i].Field<string>(0) == team.Rows[j].Field<string>(1)) t.Rows[i][1]=bt2;
                }
            }
            return t;
        }
        //Lay tong so diem cua tendoi trong giaidau
        public DataTable getSoDiem(string mag)
        {
            //lay bang cac doi trong giai
            string str = string.Format("SELECT D.TenDoi,D.SoThanhVien FROM DOI D, DAIDIEN DD, DANGKY DK, GIAIDAU G, VONG V, TRANDAU T, LICHTD L WHERE D.MaDoi=DD.MaDoi AND DD.MaDD=DK.MaDD AND DK.MaGiai=G.MaGiai AND G.MaGiai=V.MaGiai AND V.MaVong=T.MaVong AND T.MaTran=L.MaTran AND G.MaGiai='{0}' GROUP BY D.TenDoi,D.SoThanhVien", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
            DataTable team = new DataTable();
            data.Fill(team);
            int sumsd=0;
            List<int> sd1 = new List<int>();
            List<int> sd2 = new List<int>();
            //lay tong sodiem tu sodiem1
            foreach (DataRow r in team.Rows)
            {
                sumsd = 0;
                string tendoi = r.Field<string>(0);
                str = string.Format("SELECT SUM(SoDiem1) as sd1 FROM LICHTD WHERE TenDoi1='{0}'", tendoi);
                data = new SqlDataAdapter(str, connect);
                DataTable dt = new DataTable();
                data.Fill(dt);
                object o = dt.Rows[0].Field<int?>(0);
                int? temp = o == DBNull.Value ? null : (int?)o;
                if ( !string.IsNullOrEmpty(temp.ToString()) ) sumsd += dt.Rows[0].Field<int>(0);
                sd1.Add(sumsd);
                //lay tong sodiem tu sodiem2
                sumsd = 0;
                tendoi = r.Field<string>(0);
                str = string.Format("SELECT SUM(SoDiem2) as sd2 FROM LICHTD WHERE TenDoi2='{0}'", tendoi);
                data = new SqlDataAdapter(str, connect);
                dt = new DataTable();
                data.Fill(dt);
                o = dt.Rows[0].Field<int?>(0);
                temp = o == DBNull.Value ? null : (int?)o;
                if ( !string.IsNullOrEmpty(temp.ToString()) ) sumsd += dt.Rows[0].Field<int>(0);
                sd2.Add(sumsd);
            }
            
            for (int i=0;i<sd1.Count; i++)
            {
                sd1[i] += sd2[i];
                team.Rows[i][1]=sd1[i];
            }
            team.AcceptChanges();
            return team;
        }
        //Lay het user, pass
        public DataTable getXEPHANG()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM XEPHANG", connect);
            DataTable dtXEPHANG = new DataTable();
            data.Fill(dtXEPHANG);
            return dtXEPHANG;
        }
        //Lay het user, pass
        public DataTable getXEPHANGwithMa(string mag)
        {
            string str = string.Format("SELECT * FROM XEPHANG", mag);
            SqlDataAdapter data = new SqlDataAdapter(str, connect);
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
                string sql = "INSERT INTO XEPHANG(MaGiai,MaDoi,TongDiem,HieuSo,ViThu) VALUES (@MAG,@MAD,@SUM,@SUB,@RANK)";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@MAG", d.MaGiai));
                cmd.Parameters.Add(new SqlParameter("@MAD", d.MaDoi));
                cmd.Parameters.Add(new SqlParameter("@SUM", (object)d.TongDiem ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@SUB", (object)d.HieuSo ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@RANK", (object)d.ViThu ?? DBNull.Value));
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
        public bool upXEPHANG(DTO_XEPHANG d)
        {
            try
            {
                connect.Open();
                string sql = "UPDATE XEPHANG SET ViThu=@RANK WHERE MaGiai=@MAG AND MaDoi=@MAD AND TongDiem=@SUM AND HieuSo=@SUB";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@MAG", d.MaGiai));
                cmd.Parameters.Add(new SqlParameter("@MAD", d.MaDoi));
                cmd.Parameters.Add(new SqlParameter("@SUM", (object)d.TongDiem ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@SUB", (object)d.HieuSo ?? DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@RANK", (object)d.ViThu ?? DBNull.Value));
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

