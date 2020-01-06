using System;
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
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            btnBang.BackColor = Color.Gray;
            btnBang.ForeColor = Color.OrangeRed;
            btnMoHinh.BackColor = Color.Gray;
            btnMoHinh.ForeColor = Color.OrangeRed;
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
            dtaTime.Columns[1].ReadOnly = true;
            dtaTime.Columns[1].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[2].Width = 200;
            dtaTime.Columns[2].HeaderText = "Tên đội 2";
            dtaTime.Columns[2].ReadOnly = true;
            dtaTime.Columns[2].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[3].Width = 150;
            dtaTime.Columns[3].HeaderText = "Thời gian dự tính";
            dtaTime.Columns[3].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[3].ReadOnly = true;
            dtaTime.Columns[3].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[4].Width = 200;
            dtaTime.Columns[4].HeaderText = "Trọng tài";
            dtaTime.Columns[4].ReadOnly = true;
            dtaTime.Columns[4].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[5].Width = 80;
            dtaTime.Columns[5].HeaderText = "Bàn thắng đội 1";
            dtaTime.Columns[5].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[5].ReadOnly = true;
            dtaTime.Columns[5].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[6].Width = 80;
            dtaTime.Columns[6].HeaderText = "Bàn thắng đội 2";
            dtaTime.Columns[6].ReadOnly = true;
            dtaTime.Columns[6].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[7].Width = 50;
            dtaTime.Columns[7].HeaderText = "Thẻ vàng đội 1";
            dtaTime.Columns[7].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[7].ReadOnly = true;
            dtaTime.Columns[7].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[8].Width = 50;
            dtaTime.Columns[8].HeaderText = "Thẻ vàng đội 2";
            dtaTime.Columns[8].ReadOnly = true;
            dtaTime.Columns[8].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[9].Width = 50;
            dtaTime.Columns[9].HeaderText = "Thẻ đỏ đội 1";
            dtaTime.Columns[9].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[9].ReadOnly = true;
            dtaTime.Columns[9].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[10].Width = 50;
            dtaTime.Columns[10].HeaderText = "Thẻ đỏ đội 2";
            dtaTime.Columns[10].ReadOnly = true;
            dtaTime.Columns[10].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[11].Width = 50;
            dtaTime.Columns[11].HeaderText = "Số điểm đội 1";
            dtaTime.Columns[11].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaTime.Columns[11].ReadOnly = true;
            dtaTime.Columns[11].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.Columns[12].Width = 50;
            dtaTime.Columns[12].HeaderText = "Số điểm đội 2";
            dtaTime.Columns[12].ReadOnly = true;
            dtaTime.Columns[12].DefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);

            dtaTime.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaTime.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaTime.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaTime.ColumnHeadersDefaultCellStyle.Font = new Font(dtaTime.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTime.ColumnHeadersHeight = 30;
            dtaTime.RowsDefaultCellStyle.ForeColor = Color.Purple;
            dtaTime.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtaTime.AllowUserToResizeRows = false;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            btnBang.BackColor = Color.GreenYellow;
            btnMoHinh.BackColor = Color.Gray;
            dtaTime.Show();
        }
        
        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            btnMoHinh.BackColor = Color.GreenYellow;
            btnBang.BackColor = Color.Gray;
            dtaTime.Hide();
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Size = new Size(1295, 553);
            flow.Location = new Point(3,3);
            flow.AutoScroll = true;
            panTime.Controls.Add(flow);
            for (int i = 0; i < 400; i++)
            {
                Button bt = new Button();
                flow.Controls.Add(bt);
                bt.Text = "1111111111111111";
                bt.Top = ((i - 1) / 9) % 9 * bt.Height + 1 + ((i - 1) / 27) * 10 + 10;
                bt.Left = (i - 1) % 9 * bt.Width + 1 + ((i - 1) % 9) / 3 * 10 + 10;
            }
        }

        private void cboGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "MaGiai";
            dtaTime.DataSource = l.getLICHTD((string)cboGiai.SelectedValue);
            cboGiai.ValueMember = "Loai";
            if ((int)cboGiai.SelectedValue == 2) btnMoHinh.Enabled = false;
            else btnMoHinh.Enabled = true;
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
                };
            };
        }
    }
}
