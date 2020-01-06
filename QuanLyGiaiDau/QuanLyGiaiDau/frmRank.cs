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
    public partial class frmRank : Form
    {
        public frmRank()
        {
            InitializeComponent();

        }
        BUS_XEPHANG x = new BUS_XEPHANG();
        BUS_GIAIDAU g = new BUS_GIAIDAU();
        private void frmRank_Load(object sender, EventArgs e)
        {
            cboGiai.DataSource = g.getGIAIDAU();
            cboGiai.DisplayMember = "TenGiai";
            cboGiai.ValueMember = "MaGiai";
            string mag = (string)cboGiai.SelectedValue;
            dtaXepHang.DataSource = x.getXEPHANG();

            dtaXepHang.Columns[0].Width = 430;
            dtaXepHang.Columns[0].HeaderText = "Tên giải đấu";
            dtaXepHang.Columns[0].ReadOnly = true;
            dtaXepHang.Columns[0].Frozen = true;
            dtaXepHang.Columns[0].DefaultCellStyle.Font = new Font(dtaXepHang.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaXepHang.Columns[1].Width = 250;
            dtaXepHang.Columns[1].HeaderText = "Tên đội";
            dtaXepHang.Columns[1].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaXepHang.Columns[1].ReadOnly = true;
            dtaXepHang.Columns[2].Width = 120;
            dtaXepHang.Columns[2].HeaderText = "Tổng điểm";
            dtaXepHang.Columns[2].ReadOnly = true;
            dtaXepHang.Columns[3].Width = 70;
            dtaXepHang.Columns[3].HeaderText = "Hiệu số";
            dtaXepHang.Columns[3].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaXepHang.Columns[3].ReadOnly = true;
            dtaXepHang.Columns[4].Width = 110;
            dtaXepHang.Columns[4].HeaderText = "Thứ hạng";
            dtaXepHang.Columns[4].DefaultCellStyle.Font= new Font(dtaXepHang.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaXepHang.Columns[4].ReadOnly = true;
            dtaXepHang.Columns[4].DefaultCellStyle.BackColor = Color.Orange;

            dtaXepHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaXepHang.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaXepHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaXepHang.ColumnHeadersDefaultCellStyle.Font = new Font(dtaXepHang.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaXepHang.ColumnHeadersHeight = 30;
            dtaXepHang.RowsDefaultCellStyle.ForeColor = Color.Purple;
            dtaXepHang.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaXepHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtaXepHang.AllowUserToResizeRows = false;
            dtaXepHang.Controls[0].Enabled = false; // Index zero is the horizontal scrollbar
            dtaXepHang.Controls[1].Enabled = false; // Index one is the vertical scrollbar
        }

        private void cboGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "MaGiai";
            string mag = (string)cboGiai.SelectedValue;
            dtaXepHang.DataSource = x.getXEPHANG();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "Loai";
            int loai = (int)cboGiai.SelectedValue;
            cboGiai.ValueMember = "MaGiai";
            string mag = (string)cboGiai.SelectedValue;
            if (loai == 2)
            {
                DataTable t;
                x.ListRank(mag);
                x.addRank(loai,mag);
                t = x.SortRank(mag);
                foreach(DataRow r in t.Rows)
                {
                    DataTable temp=new DataTable();
                    temp = x.getTenGiai(r.Field<string>(0));
                    if (!string.IsNullOrEmpty(temp.Rows[0].Field<string>(0))) r.SetField<string>(0, temp.Rows[0].Field<string>(1));
                    temp.Clear();
                    temp = x.getTenDoi(r.Field<string>(1));
                    if (!string.IsNullOrEmpty(temp.Rows[0].Field<string>(1))) r.SetField<string>(1, temp.Rows[0].Field<string>(1));
                }
                t.AcceptChanges();
                dtaXepHang.DataSource = t;
            }
            else
            {
                DataTable t;
                x.ListRank((string)cboGiai.SelectedValue);
                x.addRank(loai,mag);
                t = x.SortRank(mag);
                foreach (DataRow r in t.Rows)
                {
                    DataTable temp=new DataTable();
                    temp = x.getTenGiai(r.Field<string>(0));
                    if (!string.IsNullOrEmpty(temp.Rows[0].Field<string>(0))) r.SetField<string>(0, temp.Rows[0].Field<string>(1));
                    temp.Clear();
                    temp = x.getTenDoi(r.Field<string>(1));
                    if (!string.IsNullOrEmpty(temp.Rows[0].Field<string>(1))) r.SetField<string>(1, temp.Rows[0].Field<string>(1));
                }
                t.AcceptChanges();
                dtaXepHang.DataSource = t;
            }
        }
    }
}
