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
    public partial class frmGroup : Form
    {
        BUS_GIAIDAU g = new BUS_GIAIDAU();
        BUS_DANGNHAP dn = new BUS_DANGNHAP();
        public frmGroup()
        {
            InitializeComponent();
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
            DataTable t = g.getGIAIDAU();
            t.Columns.Remove("MaGiai");
            dtaGiai.DataSource = t;
            dtaGiai.Columns[0].Width = 330;
            dtaGiai.Columns[0].HeaderText = "Tên Giải";
            dtaGiai.Columns[0].ReadOnly = true;
            dtaGiai.Columns[0].Frozen = true;
            dtaGiai.Columns[0].DefaultCellStyle.Font = new Font(dtaGiai.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaGiai.Columns[1].Width = 120;
            dtaGiai.Columns[1].HeaderText = "Ngày bắt đầu";
            dtaGiai.Columns[1].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaGiai.Columns[1].ReadOnly = true;
            dtaGiai.Columns[2].Width = 120;
            dtaGiai.Columns[2].HeaderText = "Ngày kết thúc";
            dtaGiai.Columns[2].ReadOnly = true;
            dtaGiai.Columns[3].Width = 70;
            dtaGiai.Columns[3].HeaderText = "Số đội";
            dtaGiai.Columns[3].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaGiai.Columns[3].ReadOnly = true;
            dtaGiai.Columns[4].Width = 90;
            dtaGiai.Columns[4].HeaderText = "Số thành viên";
            dtaGiai.Columns[4].ReadOnly = true;
            dtaGiai.Columns[5].Width = 80;
            dtaGiai.Columns[5].HeaderText = "Điểm thắng";
            dtaGiai.Columns[5].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaGiai.Columns[5].ReadOnly = true;
            dtaGiai.Columns[6].Width = 80;
            dtaGiai.Columns[6].HeaderText = "Điểm hòa";
            dtaGiai.Columns[6].ReadOnly = true;
            dtaGiai.Columns[7].Width = 80;
            dtaGiai.Columns[7].HeaderText = "Điểm thua";
            dtaGiai.Columns[7].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaGiai.Columns[7].ReadOnly = true;
            dtaGiai.Columns[8].Width = 70;
            dtaGiai.Columns[8].HeaderText = "Số lượt";
            dtaGiai.Columns[8].ReadOnly = true;
            dtaGiai.Columns[9].Width = 50;
            dtaGiai.Columns[9].HeaderText = "Loại";
            dtaGiai.Columns[9].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaGiai.Columns[9].ReadOnly = true;

            dtaGiai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaGiai.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaGiai.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaGiai.ColumnHeadersDefaultCellStyle.Font = new Font(dtaGiai.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaGiai.ColumnHeadersHeight = 30;
            dtaGiai.RowsDefaultCellStyle.ForeColor = Color.Purple;
            dtaGiai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtaGiai.AllowUserToResizeRows = false;
            // Or _Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty
            //dtaGiai.GetType().InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.NonPublic, Nothing, dgv, New Object() { True});
            //
            DataTable temp = dn.getTenDangNhap(BUS_Main.getMaDN());
            toolAccounted.Text = temp.Rows[0].Field<string>(1);
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.Text = null;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            DataTable t = g.getTenGiai(txtFind.Text);
            t.Columns.Remove("MaGiai");
            dtaGiai.DataSource = t;
        }

        private void cboHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cboHinhThuc.SelectedText;
            if(str== "Loại Trực Tiếp")
            {
                DataTable t = g.getLoai(1);
                t.Columns.Remove("MaGiai");
                dtaGiai.DataSource = t;
            }
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCreaGroup_Click(object sender, EventArgs e)
        {
            frmCreGroup create = new frmCreGroup();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
        }
        private void toolCreTeam_Click(object sender, EventArgs e)
        {
            frmCreTeam create = new frmCreTeam();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
        }
    }
}
