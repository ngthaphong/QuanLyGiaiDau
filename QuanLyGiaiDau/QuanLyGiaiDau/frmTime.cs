﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyGiaiDau;
using DTO_QuanLyGiaiDau;

namespace QuanLyGiaiDau
{
    public partial class frmTime : Form
    {
        BUS_LICHTD l = new BUS_LICHTD();
        BUS_GIAIDAU g = new BUS_GIAIDAU();
        BUS_DOI d = new BUS_DOI();
        BUS_THONGKECT tk = new BUS_THONGKECT();
        string madoi;
        int? p;
        public frmTime()
        {
            InitializeComponent();
        }
        void hide()
        {
            cboChon.Hide();
            numChon.Hide();
            btnChon.Hide();
            lblChon.Hide();
        }
        void show()
        {
            cboChon.Show();
            numChon.Show();
            btnChon.Show();
            lblChon.Show();
        }
        private void frmTime_Load(object sender, EventArgs e)
        {
            btnBang.BackColor = Color.Gray;
            btnBang.ForeColor = Color.OrangeRed;
            btnBang_Click(sender, e);
            cboGiai.DataSource= g.getGIAIDAU();
            cboGiai.DisplayMember = "TenGiai";
            //l.SetupTimewithLoai("MG16",34);
            //dtaTime.DataSource = l.getLICHTD();

            dtaTime.Columns[0].Width = 80;
            dtaTime.Columns[0].HeaderText = "Mã trận";
            dtaTime.Columns[0].ReadOnly = true;
            dtaTime.Columns[0].Frozen = true;
            dtaTime.Columns[0].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[1].Width = 200;
            dtaTime.Columns[1].HeaderText = "Tên đội 1";
            dtaTime.Columns[1].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[1].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[2].Width = 200;
            dtaTime.Columns[2].HeaderText = "Tên đội 2";
            dtaTime.Columns[2].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[3].Width = 150;
            dtaTime.Columns[3].HeaderText = "Thời gian dự tính";
            dtaTime.Columns[3].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[3].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[4].Width = 200;
            dtaTime.Columns[4].HeaderText = "Trọng tài";
            dtaTime.Columns[4].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[5].Width = 80;
            dtaTime.Columns[5].HeaderText = "Bàn thắng đội 1";
            dtaTime.Columns[5].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[5].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[6].Width = 80;
            dtaTime.Columns[6].HeaderText = "Bàn thắng đội 2";
            dtaTime.Columns[6].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[7].Width = 50;
            dtaTime.Columns[7].HeaderText = "Thẻ vàng đội 1";
            dtaTime.Columns[7].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[7].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[8].Width = 50;
            dtaTime.Columns[8].HeaderText = "Thẻ vàng đội 2";
            dtaTime.Columns[8].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[9].Width = 50;
            dtaTime.Columns[9].HeaderText = "Thẻ đỏ đội 1";
            dtaTime.Columns[9].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[9].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[10].Width = 50;
            dtaTime.Columns[10].HeaderText = "Thẻ đỏ đội 2";
            dtaTime.Columns[10].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[11].Width = 50;
            dtaTime.Columns[11].HeaderText = "Số điểm đội 1";
            dtaTime.Columns[11].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[11].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[12].Width = 50;
            dtaTime.Columns[12].HeaderText = "Số điểm đội 2";
            dtaTime.Columns[12].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);

            dtaTime.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaTime.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaTime.ColumnHeadersDefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.ColumnHeadersHeight = 30;
            dtaTime.RowsDefaultCellStyle.ForeColor = Color.Purple;
            dtaTime.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtaTime.AllowUserToResizeRows = false;

            //foreach (DataGridViewRow row in dtaTime.Rows)
            //{
            //    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(row.Cells["TenDoi1"]);
            //    cell.DataSource = new string[] { "10", "30" };
            //}

            hide();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            btnBang.BackColor = Color.GreenYellow;
            dtaTime.Show();
        }
        
        private void cboGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "MaGiai";
            dtaTime.DataSource = l.getLICHTD((string)cboGiai.SelectedValue);
            cboGiai.ValueMember = "Loai";
            if ((int)cboGiai.SelectedValue == 2)
            {
                dtaTime.Columns["SoDiem1"].Visible = true;
                dtaTime.Columns["SoDiem2"].Visible = true;
            }
            else
            {
                dtaTime.Columns["SoDiem1"].Visible = false;
                dtaTime.Columns["SoDiem2"].Visible = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "Loai";
            int loai = (int)cboGiai.SelectedValue;
            if (loai == 1)
            {
                cboGiai.ValueMember = "MaGiai";
                string mag = (string)cboGiai.SelectedValue;
                cboGiai.ValueMember = "SoDoi";
                int sodoi = (int)cboGiai.SelectedValue;
                l.SetupTimewithLoai(mag, sodoi);
            }
            else
            {
                cboGiai.ValueMember = "MaGiai";
                string mag = (string)cboGiai.SelectedValue;
                cboGiai.ValueMember = "SoDoi";
                int sodoi = (int)cboGiai.SelectedValue;
                l.SetupTimewithTron(mag, sodoi);
            }
            cboGiai.ValueMember = "MaGiai";
            dtaTime.DataSource = l.getLICHTD((string)cboGiai.SelectedValue);
        }

        private void dtaTime_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int? rowIdx = e?.RowIndex;
            int? colIdx = e?.ColumnIndex;
            if (rowIdx.HasValue && colIdx.HasValue)
            {
                var dgv = (DataGridView)sender;
                var cell = dgv?.Rows?[rowIdx.Value]?.Cells?[colIdx.Value]?.Value;
                if (!string.IsNullOrEmpty(cell?.ToString()))
                {
                    DataGridViewRow row = dgv?.Rows?[rowIdx.Value];
                    string mat = row?.Cells?[0]?.Value.ToString();
                    string ten1 = row?.Cells?[1]?.Value.ToString();
                    string ten2 = row?.Cells?[2]?.Value.ToString();
                    object o = row?.Cells?[3]?.Value;
                    DateTime? time = o == DBNull.Value ? null : (DateTime?)o;
                    string tt = row?.Cells?[4]?.Value.ToString();
                    //convert to null param
                    o = row?.Cells?[5]?.Value;
                    int? bt1 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[6]?.Value;
                    int? bt2 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[7]?.Value;
                    int? tv1 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[8]?.Value;
                    int? tv2 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[9]?.Value;
                    int? td1 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[10]?.Value;
                    int? td2 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[11]?.Value;
                    int? sd1 = o == DBNull.Value ? null : (int?)o;
                    o = row?.Cells?[12]?.Value;
                    int? sd2 = o == DBNull.Value ? null : (int?)o;
                    DTO_LICHTD dtol = new DTO_LICHTD(mat,ten1,ten2,time,tt,bt1,bt2,tv1,tv2,td1,td2,sd1,sd2);
                    l.upLICHTD(dtol);
                    //
                    switch (colIdx)
                    {
                        case 5:
                            show();
                            lblChon.Text = "Ghi bàn đội 1";
                            numChon.Maximum = (decimal)bt1;
                            madoi = d.getMa(ten1);
                            p = bt1;
                            DataTable temp = d.getCauThu(madoi);
                            if (temp.Rows.Count > 0)
                            {
                                cboChon.DataSource = temp;
                                cboChon.DisplayMember = "HoTenCT";
                                dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.RowsDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.Enabled = false;
                            }
                            break;
                        case 6:
                            show();
                            lblChon.Text = "Ghi bàn đội 2";
                            madoi = d.getMa(ten2);
                            p = bt2;
                            temp = d.getCauThu(madoi);
                            if (temp.Rows.Count > 0)
                            {
                                cboChon.DataSource = temp;
                                cboChon.DisplayMember = "HoTenCT";
                                dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.RowsDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.Enabled = false;
                            }
                            break;
                        case 7:
                            show();
                            lblChon.Text = "Thẻ vàng đội 1";
                            madoi = d.getMa(ten1);
                            p = tv1;
                            temp = d.getCauThu(madoi);
                            if (temp.Rows.Count > 0)
                            {
                                cboChon.DataSource = temp;
                                cboChon.DisplayMember = "HoTenCT";
                                dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.RowsDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.Enabled = false;
                            }
                            break;
                        case 8:
                            show();
                            lblChon.Text = "Thẻ vàng đội 2";
                            madoi = d.getMa(ten2);
                            p = tv2;
                            temp = d.getCauThu(madoi);
                            if (temp.Rows.Count > 0)
                            {
                                cboChon.DataSource = temp;
                                cboChon.DisplayMember = "HoTenCT";
                                dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.RowsDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.Enabled = false;
                            }
                            break;
                        case 9:
                            show();
                            lblChon.Text = "Thẻ đỏ đội 1";
                            madoi = d.getMa(ten1);
                            p = td1;
                            temp = d.getCauThu(madoi);
                            if (temp.Rows.Count > 0)
                            {
                                cboChon.DataSource = temp;
                                cboChon.DisplayMember = "HoTenCT";
                                dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.RowsDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.Enabled = false;
                            }
                            break;
                        case 10:
                            show();
                            lblChon.Text = "Thẻ đỏ đội 2";
                            madoi = d.getMa(ten2);
                            p = td2;
                            temp = d.getCauThu(madoi);
                            if (temp.Rows.Count > 0)
                            {
                                cboChon.DataSource = temp;
                                cboChon.DisplayMember = "HoTenCT";
                                dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.RowsDefaultCellStyle.ForeColor = Color.Gray;
                                dtaTime.Enabled = false;
                            }
                            break;
                    } 
                };
            };
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRank create = new frmRank();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            dtaTime.Enabled = true;
            dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaTime.RowsDefaultCellStyle.ForeColor = Color.Purple;
            cboGiai.ValueMember = "MaGiai";
            cboChon.ValueMember = "SoAo";
            switch (lblChon.Text)
            {
                case "Ghi bàn đội 1":
                    string mag = (string)cboGiai.SelectedValue;
                    DTO_THONGKECT dtotk = new DTO_THONGKECT(mag,madoi,cboChon.Text,(int)cboChon.SelectedValue,(int)numChon.Value,null,null);
                    DataTable t=tk.getEmpty(mag, madoi);
                    if (t.Rows.Count > 0) tk.upTHONGKECT(dtotk);
                    else tk.addTHONGKECT(dtotk);
                    break;
                case "Ghi bàn đội 2":
                    mag = (string)cboGiai.SelectedValue;
                    dtotk = new DTO_THONGKECT(mag, madoi, cboChon.Text, (int)cboChon.SelectedValue, (int)numChon.Value, null, null);
                    t = tk.getEmpty(mag, madoi);
                    if (t.Rows.Count > 0) tk.upTHONGKECT(dtotk);
                    else tk.addTHONGKECT(dtotk);
                    break;
                case "Thẻ vàng đội 1":
                    mag = (string)cboGiai.SelectedValue;
                    dtotk = new DTO_THONGKECT(mag, madoi, cboChon.Text, (int)cboChon.SelectedValue, (int)numChon.Value, null, null);
                    t = tk.getEmpty(mag, madoi);
                    if (t.Rows.Count > 0) tk.upTHONGKECT(dtotk);
                    else tk.addTHONGKECT(dtotk);
                    break;
                case "Thẻ vàng đội 2":
                    mag = (string)cboGiai.SelectedValue;
                    dtotk = new DTO_THONGKECT(mag, madoi, cboChon.Text, (int)cboChon.SelectedValue, (int)numChon.Value, null, null);
                    t = tk.getEmpty(mag, madoi);
                    if (t.Rows.Count > 0) tk.upTHONGKECT(dtotk);
                    else tk.addTHONGKECT(dtotk);
                    break;
                case "Thẻ đỏ đội 1":
                    mag = (string)cboGiai.SelectedValue;
                    dtotk = new DTO_THONGKECT(mag, madoi, cboChon.Text, (int)cboChon.SelectedValue, (int)numChon.Value, null, null);
                    t = tk.getEmpty(mag, madoi);
                    if (t.Rows.Count > 0) tk.upTHONGKECT(dtotk);
                    else tk.addTHONGKECT(dtotk);
                    break;
                case "Thẻ đỏ đội 2":
                    mag = (string)cboGiai.SelectedValue;
                    dtotk = new DTO_THONGKECT(mag, madoi, cboChon.Text, (int)cboChon.SelectedValue, (int)numChon.Value, null, null);
                    t = tk.getEmpty(mag, madoi);
                    if (t.Rows.Count > 0) tk.upTHONGKECT(dtotk);
                    else tk.addTHONGKECT(dtotk);
                    break;
            }
            hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
