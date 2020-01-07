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
    public partial class frmCreTeam : Form
    {
        BUS_DOI d = new BUS_DOI();
        BUS_DAIDIEN dd = new BUS_DAIDIEN();

        public frmCreTeam()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            //refresh
            DataTable t = d.getDOI();
            t.Columns.Remove("SoThanhVien");
            t.Columns.Remove("MauAo");
            var results = from table in t.AsEnumerable()
                          select
                             new
                             {
                                 MaDoi = table.Field<string>("MaDoi"),
                                 TenDoi = table.Field<string>("TenDoi") + " - HLV: " + table.Field<string>("TenHLV") + " - Đội trưởng: " + table.Field<string>("DoiTruong")
                             };
            cboXoa.DataSource = results.ToArray();
            cboXoa.DisplayMember = "TenDoi";
            t = d.getDOI();
            t.Columns.Remove("MaDoi");
            dtaDoi.DataSource = t;
            //
            t = dd.getDAIDIEN();
            //delete with madoi!=null
            foreach (DataRow r in t.Rows)
            {
                if (r.Field<string>(1) != null) r.Delete();
            }
            t.AcceptChanges();
            cboDaiDien.DataSource = t;
            cboDaiDien.DisplayMember = "TenNguoiDD";
            cboDaiDien.ValueMember = "MaDD";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTenDoi.TextLength < 6 || txtTenDoi.TextLength > 50)
            {
                MessageBox.Show("Tên đội phải lớn hơn 6 và nhỏ hơn 50 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDoi.Focus();
            }
            else if (txtTenHLV.TextLength < 6 || txtTenHLV.TextLength > 50)
            {
                MessageBox.Show("Tên HLV phải lớn hơn 6 và nhỏ hơn 50 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHLV.Focus();
            }
            else if (txtDoiTruong.TextLength < 6 || txtDoiTruong.TextLength > 50)
            {
                MessageBox.Show("Tên đội trưởng phải lớn hơn 6 và nhỏ hơn 50 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoiTruong.Focus();
            }
            else
            {
                //create team
                string mad = d.nextMa();
                cboThanhVien.ValueMember = "SoThanhVien";
                int tv = (int)cboThanhVien.SelectedValue;
                string mau = txtMau.Text;
                DTO_DOI dtod = new DTO_DOI(mad,txtTenDoi.Text,txtTenHLV.Text,txtDoiTruong.Text,tv,mau);
                if (d.addDOI(dtod))
                {
                    MessageBox.Show("Tạo đội hoàn tất, bạn có thể thêm cầu thủ vào đội của mình", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //add daidien ma doi
                    string madd = (string)cboDaiDien.SelectedValue;
                    cboDaiDien.ValueMember = "TenNguoiDD";
                    string nguoi = (string)cboDaiDien.SelectedValue;
                    DTO_DAIDIEN dtodd = new DTO_DAIDIEN(madd, mad, nguoi);
                    dd.upDAIDIEN(dtodd);
                    //refresh
                    refresh();
                }
                else MessageBox.Show("Tạo đội thất bại, kiểm tra lại thông tin", "Thật tiếc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreTeam_Load(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            lblCreate.Text = "Vui lòng điển đủ thông tin";
            //set cboXoa
            refresh();
            
            dtaDoi.Columns[0].Width = 200;
            dtaDoi.Columns[0].HeaderText = "Tên đội";
            dtaDoi.Columns[0].ReadOnly = true;
            dtaDoi.Columns[0].Frozen = true;
            dtaDoi.Columns[0].DefaultCellStyle.Font = new Font(dtaDoi.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaDoi.Columns[1].Width = 280;
            dtaDoi.Columns[1].HeaderText = "Tên huấn luyện viên";
            dtaDoi.Columns[1].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaDoi.Columns[1].ReadOnly = true;
            dtaDoi.Columns[2].Width = 200;
            dtaDoi.Columns[2].HeaderText = "Đội trưởng";
            dtaDoi.Columns[2].ReadOnly = true;
            dtaDoi.Columns[3].Width = 70;
            dtaDoi.Columns[3].HeaderText = "Số thành viên";
            dtaDoi.Columns[3].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaDoi.Columns[3].ReadOnly = true;
            dtaDoi.Columns[4].Width = 150;
            dtaDoi.Columns[4].HeaderText = "Màu áo";
            dtaDoi.Columns[4].ReadOnly = true;

            dtaDoi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaDoi.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaDoi.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaDoi.ColumnHeadersDefaultCellStyle.Font = new Font(dtaDoi.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaDoi.ColumnHeadersHeight = 30;
            dtaDoi.RowsDefaultCellStyle.ForeColor = Color.Purple;
            dtaDoi.RowsDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dtaDoi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtaDoi.AllowUserToResizeRows = false;
        }

        private void cboThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            lblCreate.Text = "";
        }

        private void cboMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            lblCreate.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKicker kick = new frmKicker();
            kick.StartPosition = FormStartPosition.CenterParent;
            kick.ShowDialog();
            this.Close();
        }

        private void cboDaiDien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDaiDien.ValueMember = "MaDD";
            string madd = (string)cboDaiDien.SelectedValue;
            cboThanhVien.DataSource = d.getSTV(madd);
            cboThanhVien.DisplayMember = "SoThanhVien";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cboXoa.ValueMember = "MaDoi";
            //up dd
            DTO_DAIDIEN dtodd = new DTO_DAIDIEN();
            string mad="";
            DataTable t = d.getDaiDien((string)cboXoa.SelectedValue);
            if (t.Rows.Count>0)
            {
                dtodd.MaDD = t.Rows[0].Field<string>(0);
                mad = t.Rows[0].Field<string>(1);
                dtodd.MaDoi = null;
                dtodd.TenNguoiDD = t.Rows[0].Field<string>(2);
                dd.upDAIDIEN(dtodd);
            }
            if (!d.delDOI((string)cboXoa.SelectedValue))
            {
                MessageBox.Show("Xóa thất bại, bạn chỉ được phép xóa những đội vừa mới tạo! Hoặc đội trong giải đã hết hạn", "Thật tiếc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtodd.MaDoi = mad;
                dd.upDAIDIEN(dtodd);
            }
            refresh();
        }
    }
}
