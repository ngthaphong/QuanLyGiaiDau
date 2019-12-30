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
                string mad = d.nextMa("MD");
                int tv = (int)cboThanhVien.SelectedValue;
                string mau = (string)cboMau.SelectedValue;
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
                }
                else MessageBox.Show("Tạo đội thất bại, kiểm tra lại thông tin", "Thật tiếc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCreTeam_Load(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            lblCreate.Text = "Vui lòng điển đủ thông tin";
            string[] mau = new string[10];
            mau[0] = "đỏ"; mau[1] = "xanh"; mau[2] = "trắng"; mau[3] = "đen"; mau[4] = "xanh lá"; mau[5] = "hồng"; mau[6] = "trắng sọc đen"; mau[7] = "xanh sọc trắng"; mau[8] = "đỏ sọc trắng"; mau[9] = "xanh lá sọc trắng";
            cboMau.DataSource = mau;
            DataTable t= dd.getDAIDIEN();
            //delete with madoi!=null
            foreach(DataRow r in t.Rows)
            {
                if (r.Field<string>(1) != null) r.Delete();
            }
            t.AcceptChanges();
            cboDaiDien.DataSource = t;
            cboDaiDien.DisplayMember = "TenNguoiDD";
            cboDaiDien.ValueMember = "MaDD";
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
    }
}
