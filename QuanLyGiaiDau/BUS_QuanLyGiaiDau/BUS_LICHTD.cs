﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyGiaiDau;
using DTO_QuanLyGiaiDau;
using System.Data;
using System.Text.RegularExpressions; 

namespace BUS_QuanLyGiaiDau
{
    public class BUS_LICHTD
    {
        DAL_LICHTD dalLICHTD = new DAL_LICHTD();
        public void SetupTimewithLoai(string mag, int sodoitg)
        {
            //get table
            DataTable t = getRange(mag);
            DataTable ten;
            string matran;
            int sotran, sodoidk, sodoitemp;
            List<string> win32 = new List<string>();
            List<string> win16 = new List<string>();
            List<string> win8 = new List<string>();
            List<string> win4 = new List<string>();
            List<string> win2 = new List<string>();
            switch (t.Rows[0].Field<string>(2))
            {
                case "1/32":
                    matran = t.Rows[0].Field<string>(0);
                    ten = getTeam(mag);
                    sotran = t.Rows[0].Field<int>(3);
                    sodoidk = ten.Rows.Count;
                    sodoitemp = sotran * 2;
                    //neu sodoi co the tham gia lon hon sodoi da dang ky
                    win32 = new List<string>();
                    if (sodoidk < sodoitg)  //them ten doi cho cac doi
                    {
                        for (int i = sodoidk + 1; i <= sodoitg; i++)
                        {
                            string str = string.Format("Đội #{0}", i);
                            ten.Rows.Add(str);
                        }
                    }
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1 = ten.Rows[i * 2].Field<string>(0);
                        string ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng 1/32", i + 1);
                        win32.Add(str);
                    }
                    //1/16
                    sotran = t.Rows[1].Field<int>(3);
                    matran = t.Rows[1].Field<string>(0);
                    win16 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        if (sodoitg % 2 != 0)
                        {
                            if (i == 0)
                            {
                                ten1 = ten.Rows[sodoitg - 1].Field<string>(0);
                                ten2 = win32[i * 2];
                            }
                            else
                            {
                                if (sodoidk < sodoitemp)
                                {
                                    ten1 = win32[i * 2 - 1];
                                    ten2 = win32[i * 2];
                                }
                                else
                                {
                                    ten1 = ten.Rows[i * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                                }
                            }
                        }
                        else
                        {
                            if (sodoitg < 32)
                            {
                                if (i == sotran - 1)
                                {
                                    ten1 = ten.Rows[sodoitg - 2].Field<string>(0);
                                    ten2 = ten.Rows[sodoitg - 1].Field<string>(0);
                                }
                                else
                                {
                                    ten1 = win32[i * 2];
                                    ten2 = win32[i * 2 + 1];
                                }
                            }
                            if (sodoitg==32)
                            {
                                ten1 = win32[i * 2];
                                ten2 = win32[i * 2 + 1];
                            }
                            else
                            {
                                if (i == sotran - 1)
                                {
                                    ten1 = win32[sodoitg-(sotran+1)*2];
                                    ten2 = win32[sodoitg-(sotran*2+1)];
                                }
                                else
                                {
                                    if (i * 2 + win32.Count * 2 < sodoitg)
                                    {
                                        ten1 = ten.Rows[i * 2 + win32.Count * 2].Field<string>(0);
                                        ten2 = ten.Rows[i * 2 + 1 + win32.Count * 2].Field<string>(0);
                                    }
                                    else
                                    {
                                        ten1 = win32[((i+win32.Count)*2)-Math.Abs(sotran+win32.Count/2)*2];
                                        ten2 = win32[((i+win32.Count)*2)-Math.Abs(sotran+win32.Count/2)*2+1];
                                    }
                                }
                            }
                        }
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng 1/16", i + 1);
                        win16.Add(str);
                    }
                    //1/8
                    sotran = t.Rows[2].Field<int>(3);
                    matran = t.Rows[2].Field<string>(0);
                    win8 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win16[i * 2];
                        ten2 = win16[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng 1/8", i + 1);
                        win8.Add(str);
                    }
                    //tu ket
                    sotran = t.Rows[3].Field<int>(3);
                    matran = t.Rows[3].Field<string>(0);
                    win4 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win8[i * 2];
                        ten2 = win8[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Tứ Kết", i + 1);
                        win4.Add(str);
                    }
                    //ban ket
                    sotran = t.Rows[4].Field<int>(3);
                    matran = t.Rows[4].Field<string>(0);
                    win2 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win4[i * 2];
                        ten2 = win4[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Bán Kết", i + 1);
                        win2.Add(str);
                    }
                    //chung ket
                    sotran = t.Rows[5].Field<int>(3);
                    matran = t.Rows[5].Field<string>(0);
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win2[i * 2];
                        ten2 = win2[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    break;
                case "1/16":
                    matran = t.Rows[0].Field<string>(0);
                    ten = getTeam(mag);
                    sotran = t.Rows[0].Field<int>(3);
                    sodoidk = ten.Rows.Count;
                    sodoitemp = sotran * 2;
                    //neu sodoi co the tham gia lon hon sodoi da dang ky
                    win16 = new List<string>();
                    if (sodoidk < sodoitg)  //them ten doi cho cac doi
                    {
                        for (int i = sodoidk + 1; i <= sodoitg; i++)
                        {
                            string str = string.Format("Đội #{0}", i);
                            ten.Rows.Add(str);
                        }
                    }
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1 = ten.Rows[i * 2].Field<string>(0);
                        string ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng 1/16", i + 1);
                        win16.Add(str);
                    }
                    //1/8
                    sotran = t.Rows[1].Field<int>(3);
                    matran = t.Rows[1].Field<string>(0);
                    win8 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        if (sodoitg % 2 != 0)
                        {
                            if (i == 0)
                            {
                                ten1 = ten.Rows[sodoitg - 1].Field<string>(0);
                                ten2 = win16[i * 2];
                            }
                            else
                            {
                                if (sodoidk < sodoitemp)
                                {
                                    ten1 = win16[i * 2 - 1];
                                    ten2 = win16[i * 2];
                                }
                                else
                                {
                                    ten1 = ten.Rows[i * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                                }
                            }
                        }
                        else
                        {
                            if (i == sotran - 1)
                            {
                                ten1 = win16[sodoitg - (sotran + 1) * 2];
                                ten2 = win16[sodoitg - (sotran * 2 + 1)];
                            }
                            else
                            {
                                if (i * 2 + win16.Count * 2 < sodoitg)
                                {
                                    ten1 = ten.Rows[i * 2 + win16.Count * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1 + win16.Count * 2].Field<string>(0);
                                }
                                else
                                {
                                    ten1 = win16[((i + win16.Count) * 2) - Math.Abs(sotran + win16.Count / 2) * 2];
                                    ten2 = win16[((i + win16.Count) * 2) - Math.Abs(sotran + win16.Count / 2) * 2 + 1];
                                }
                            }
                        }
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng 1/8", i + 1);
                        win8.Add(str);
                    }
                    //tu ket
                    sotran = t.Rows[2].Field<int>(3);
                    matran = t.Rows[2].Field<string>(0);
                    win4 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win8[i * 2];
                        ten2 = win8[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Tứ Kết", i + 1);
                        win4.Add(str);
                    }
                    //ban ket
                    sotran = t.Rows[3].Field<int>(3);
                    matran = t.Rows[3].Field<string>(0);
                    win2 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win4[i * 2];
                        ten2 = win4[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Bán Kết", i + 1);
                        win2.Add(str);
                    }
                    //chung ket
                    sotran = t.Rows[4].Field<int>(3);
                    matran = t.Rows[4].Field<string>(0);
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win2[i * 2];
                        ten2 = win2[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    break;
                case "1/8":
                    matran = t.Rows[0].Field<string>(0);
                    ten = getTeam(mag);
                    sotran = t.Rows[0].Field<int>(3);
                    sodoidk = ten.Rows.Count;
                    sodoitemp = sotran * 2;
                    //neu sodoi co the tham gia lon hon sodoi da dang ky
                    win8 = new List<string>();
                    if (sodoidk < sodoitg)  //them ten doi cho cac doi
                    {
                        for (int i = sodoidk + 1; i <= sodoitg; i++)
                        {
                            string str = string.Format("Đội #{0}", i);
                            ten.Rows.Add(str);
                        }
                    }
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1 = ten.Rows[i * 2].Field<string>(0);
                        string ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng 1/8", i + 1);
                        win8.Add(str);
                    }
                    //tu ket
                    sotran = t.Rows[1].Field<int>(3);
                    matran = t.Rows[1].Field<string>(0);
                    win4 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        if (sodoitg % 2 != 0)
                        {
                            if (i == 0)
                            {
                                ten1 = ten.Rows[sodoitg - 1].Field<string>(0);
                                ten2 = win8[i * 2];
                            }
                            else
                            {
                                if (sodoidk < sodoitemp)
                                {
                                    ten1 = win8[i * 2 - 1];
                                    ten2 = win8[i * 2];
                                }
                                else
                                {
                                    ten1 = ten.Rows[i*2].Field<string>(0);
                                    ten2 = ten.Rows[i*2+1].Field<string>(0);
                                }
                            }
                        }
                        else
                        {
                            if (i == sotran - 1)
                            {
                                ten1 = win8[sodoitg - (sotran + 1) * 2];
                                ten2 = win8[sodoitg - (sotran * 2 + 1)];
                            }
                            else
                            {
                                if (i * 2 + win8.Count * 2 < sodoitg)
                                {
                                    ten1 = ten.Rows[i * 2 + win8.Count * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1 + win8.Count * 2].Field<string>(0);
                                }
                                else
                                {
                                    ten1 = win8[((i + win8.Count) * 2) - Math.Abs(sotran + win8.Count / 2) * 2];
                                    ten2 = win8[((i + win8.Count) * 2) - Math.Abs(sotran + win8.Count / 2) * 2 + 1];
                                }
                            }
                        }
                            DTO_LICHTD dtol = new DTO_LICHTD(matran,ten1,ten2,null,null,null,null,null,null,null,null,null,null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Tứ Kết", i + 1);
                            win4.Add(str);
                    }
                    //ban ket
                    sotran = t.Rows[2].Field<int>(3);
                    matran = t.Rows[2].Field<string>(0);
                    win2 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win4[i * 2];
                        ten2 = win4[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Bán Kết", i + 1);
                        win2.Add(str);
                    }
                    //chung ket
                    sotran = t.Rows[3].Field<int>(3);
                    matran = t.Rows[3].Field<string>(0);
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win2[i * 2];
                        ten2 = win2[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    break;
                case "Tứ Kết":
                    matran = t.Rows[0].Field<string>(0);
                    ten = getTeam(mag);
                    sotran = t.Rows[0].Field<int>(3);
                    sodoidk = ten.Rows.Count;
                    sodoitemp = sotran * 2;
                    //neu sodoi co the tham gia lon hon sodoi da dang ky
                    win4 = new List<string>();
                    if (sodoidk < sodoitg)  //them ten doi cho cac doi
                    {
                        for (int i = sodoidk + 1; i <= sodoitg; i++)
                        {
                            string str = string.Format("Đội #{0}", i);
                            ten.Rows.Add(str);
                        }
                    }
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1 = ten.Rows[i * 2].Field<string>(0);
                        string ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Tứ Kết", i + 1);
                        win4.Add(str);
                    }
                    //ban ket
                    sotran = t.Rows[1].Field<int>(3);
                    matran = t.Rows[1].Field<string>(0);
                    win2 = new List<string>();
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        if (sodoitg % 2 != 0)
                        {
                            if (i == 0)
                            {
                                ten1 = ten.Rows[sodoitg - 1].Field<string>(0);
                                ten2 = win4[i * 2];
                            }
                            else
                            {
                                if (sodoidk < sodoitemp)
                                {
                                    ten1 = win4[i * 2 - 1];
                                    ten2 = win4[i * 2];
                                }
                                else
                                {
                                    ten1 = ten.Rows[i * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                                }
                            }
                        }
                        else
                        {
                            if (i == sotran - 1)
                            {
                                ten1 = win4[sodoitg - (sotran + 1) * 2];
                                ten2 = win4[sodoitg - (sotran * 2 + 1)];
                            }
                            else
                            {
                                if (i * 2 + win4.Count * 2 < sodoitg)
                                {
                                    ten1 = ten.Rows[i * 2 + win4.Count * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1 + win4.Count * 2].Field<string>(0);
                                }
                                else
                                {
                                    ten1 = win4[((i + win4.Count) * 2) - Math.Abs(sotran + win4.Count / 2) * 2];
                                    ten2 = win4[((i + win4.Count) * 2) - Math.Abs(sotran + win4.Count / 2) * 2 + 1];
                                }
                            }
                        }
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Bán Kết", i + 1);
                        win2.Add(str);
                    }
                    //chung ket
                    sotran = t.Rows[2].Field<int>(3);
                    matran = t.Rows[2].Field<string>(0);
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win2[i * 2];
                        ten2 = win2[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    break;
                case "Bán Kết":
                    matran = t.Rows[0].Field<string>(0);
                    ten = getTeam(mag);
                    sotran = t.Rows[0].Field<int>(3);
                    sodoidk = ten.Rows.Count;
                    sodoitemp = sotran * 2;
                    //neu sodoi co the tham gia lon hon sodoi da dang ky
                    win2 = new List<string>();
                    if (sodoidk < sodoitg)  //them ten doi cho cac doi
                    {
                        for (int i = sodoidk + 1; i <= sodoitg; i++)
                        {
                            string str = string.Format("Đội #{0}", i);
                            ten.Rows.Add(str);
                        }
                    }
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1 = ten.Rows[i * 2].Field<string>(0);
                        string ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                        string str = string.Format("W#{0} Vòng Bán Kết", i + 1);
                        win2.Add(str);
                    }
                    //ban ket
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        if (sodoitg % 2 != 0)
                        {
                            if (i == 0)
                            {
                                ten1 = ten.Rows[sodoitg - 1].Field<string>(0);
                                ten2 = win2[i * 2];
                            }
                            else
                            {
                                if (sodoidk < sodoitemp)
                                {
                                    ten1 = win2[i * 2 - 1];
                                    ten2 = win2[i * 2];
                                }
                                else
                                {
                                    ten1 = ten.Rows[i * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1].Field<string>(0);
                                }
                            }
                        }
                        else
                        {
                            if (i == sotran - 1)
                            {
                                ten1 = win2[sodoitg - (sotran + 1) * 2];
                                ten2 = win2[sodoitg - (sotran * 2 + 1)];
                            }
                            else
                            {
                                if (i * 2 + win2.Count * 2 < sodoitg)
                                {
                                    ten1 = ten.Rows[i * 2 + win2.Count * 2].Field<string>(0);
                                    ten2 = ten.Rows[i * 2 + 1 + win2.Count * 2].Field<string>(0);
                                }
                                else
                                {
                                    ten1 = win2[((i + win2.Count) * 2) - Math.Abs(sotran + win2.Count / 2) * 2];
                                    ten2 = win2[((i + win2.Count) * 2) - Math.Abs(sotran + win2.Count / 2) * 2 + 1];
                                }
                            }
                        }
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    //chung ket
                    sotran = t.Rows[1].Field<int>(3);
                    matran = t.Rows[1].Field<string>(0);
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = win2[i * 2];
                        ten2 = win2[i * 2 + 1];
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    break;
                case "Chung Kết":
                    matran = t.Rows[0].Field<string>(0);
                    ten = getTeam(mag);
                    sotran = t.Rows[0].Field<int>(3);
                    //chung ket
                    for (int i = 0; i < sotran; i++)
                    {
                        string ten1; string ten2;
                        ten1 = ten.Rows[i * 2].Field<string>(0);
                        ten2 = ten.Rows[i * 2+1].Field<string>(0);
                        DTO_LICHTD dtol = new DTO_LICHTD(matran, ten1, ten2, null, null, null, null, null, null, null, null, null, null);
                        if (CheckTrungbelow(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                    }
                    break;
            }
        }
        public void SetupTimewithTron(string mag, int sodoitg)
        {
            DataTable ten = getTeam(mag);
            int sodoidk = ten.Rows.Count;
            //neu sodoi co the tham gia lon hon sodoi da dang ky
            if (sodoidk < sodoitg)  //them ten doi cho cac doi
            {
                for (int i = sodoidk + 1; i <= sodoitg; i++)
                {
                    string str = string.Format("Đội #{0}", i);
                    ten.Rows.Add(str);
                }
            }
            List<string> tendoi = ten.AsEnumerable().Select(x => x[0].ToString()).ToList();
            ListMatches(tendoi,mag);
        }
        public void ListMatches(List<string> ListTeam, string mag)
        {
            DataTable t = getRangenon(mag);
            List<string> teamdone = new List<string>();
            if (ListTeam.Count % 2 != 0)
            {
                ListTeam.Add("Bye");
            }
            int numTeams = ListTeam.Count;
            int numDays = (numTeams - 1);
            int halfSize = numTeams / 2;

            List<string> teams = new List<string>();

            teams.AddRange(ListTeam.Skip(halfSize).Take(halfSize));
            teams.AddRange(ListTeam.Skip(1).Take(halfSize - 1).ToArray().Reverse());

            int teamsSize = teams.Count;
            for (int day = 0; day < numDays; day++)
            {
                //add dau tien
                string matran=t.Rows[day*halfSize].Field<string>(0);
                int teamIdx = day % teamsSize;
                DTO_LICHTD dtol = new DTO_LICHTD(matran, teams[teamIdx], ListTeam[0],null, null, null, null, null, null, null, null, null, null);
                if (CheckTrung(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                for (int idx = 1; idx < halfSize; idx++)
                {
                    int firstTeam = (day + idx) % teamsSize;
                    int secondTeam = (day + teamsSize - idx) % teamsSize;
                    matran = t.Rows[(day*halfSize)+idx].Field<string>(0);
                    dtol = new DTO_LICHTD(matran, teams[firstTeam], teams[secondTeam], null, null, null, null, null, null, null, null, null, null);
                    if (CheckTrung(mag, dtol.TenDoi1, dtol.TenDoi2)) addLICHTD(dtol);
                }
            }
        }
        public bool CheckTrung(string mag, string tendoi1, string tendoi2)
        {
            DataTable temp = getLICHTD(mag);
            if (temp.Rows.Count == 0) return true;
                foreach (DataRow r in temp.Rows)
                {
                    if (r.Field<string>(1) == tendoi1 && r.Field<string>(2) == tendoi2) return false;
                }
                return true;
        }
        public bool CheckTrungbelow(string mag, string tendoi1, string tendoi2)
        {
            DataTable temp = getLICHTD(mag);
            if (temp.Rows.Count == 0) return true;
                foreach (DataRow r in temp.Rows)
                {
                    if (r.Field<string>(1) == tendoi1 && r.Field<string>(2) == tendoi2) return false;
                }
                return true;
        }
        public DataTable getGoal(string mat)
        {
            return dalLICHTD.getGoal(mat);
        }
        public DataTable getTeam(string mag)
        {
            return dalLICHTD.getTeam(mag);
        }
        public DataTable getRange(string mag)
        {
            return dalLICHTD.getRange(mag);
        }
        public DataTable getRangenon(string mag)
        {
            return dalLICHTD.getRangenon(mag);
        }
        public DataTable getLICHTD(string mag)
        {
            return dalLICHTD.getLICHTD(mag);
        }
        public bool addLICHTD(DTO_LICHTD g)
        {
            return dalLICHTD.addLICHTD(g);
        }
        public bool upLICHTD(DTO_LICHTD g)
        {
            return dalLICHTD.upLICHTD(g);
        }
        public bool delLICHTD(DTO_LICHTD g)
        {
            return dalLICHTD.delLICHTD(g);
        }
    }
}
