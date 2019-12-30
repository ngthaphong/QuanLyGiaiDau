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
    public partial class frmCreate : Form
    {
        BUS_DAIDIEN dd = new BUS_DAIDIEN();
        BUS_DANGKY dk = new BUS_DANGKY();
        BUS_GIAIDAU giai = new BUS_GIAIDAU();
        public frmCreate()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            
            
            if (txtDaiDien.TextLength < 10 || txtDaiDien.TextLength > 50)
            {
                MessageBox.Show("Tên đại diện phải lớn hơn 10 kí tự và nhỏ hơn 50 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //create daidien
                string madd = dd.nextMa("MDD");
                DTO_DAIDIEN dtodd = new DTO_DAIDIEN(madd, null, txtDaiDien.Text);
                if (dd.addDAIDIEN(dtodd))
                {
                    //create dangky
                    string magiai = (string)cboGiaiDau.SelectedValue;
                    string matk = BUS_Main.getMaDN();
                    DTO_DANGKY dtodk = new DTO_DANGKY(magiai,madd,dtaNgayDangKy.Value,matk);
                    if (dk.addDANGKY(dtodk)) MessageBox.Show("Bạn đã hoàn tất đăng ký, vui lòng tạo một đội bóng để có thể tham gia Giải Đấu", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Tạo thất bại, vui lòng kiểm tra lại thông tin đăng kí", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Tạo thất bại, vui lòng kiểm tra lại thông tin người đại diện", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            DataTable t = giai.getGIAIDAU();
            cboGiaiDau.DataSource = t;
            cboGiaiDau.ValueMember = "MaGiai";
            cboGiaiDau.DisplayMember = "TenGiai";
            btnTao.Enabled = false;
            lblTao.Text = "Mời chọn Giải";
        }

        private void cboGiaiDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGiaiDau.ValueMember = "MaGiai";
            btnTao.Enabled = true;
            lblTao.Text = "";
            string mag = (string)cboGiaiDau.SelectedValue;
            DataTable t = giai.getMaGiai(mag);
            t.Columns.Remove("MaGiai");
            dtaGiai.DataSource = t;
            dtaGiai.Columns[0].Width=200;
            dtaGiai.Columns[0].HeaderText = "Tên Giải";
            dtaGiai.Columns[1].Width = 100;
            dtaGiai.Columns[1].HeaderText = "Ngày bắt đầu";
            dtaGiai.Columns[2].Width = 100;
            dtaGiai.Columns[2].HeaderText = "Ngày kết thúc";
            dtaGiai.Columns[3].Width = 70;
            dtaGiai.Columns[3].HeaderText = "Số đội";
            dtaGiai.Columns[4].Width = 80;
            dtaGiai.Columns[4].HeaderText = "Số thành viên";
            dtaGiai.Columns[5].Width = 70;
            dtaGiai.Columns[5].HeaderText = "Điểm thắng";
            dtaGiai.Columns[6].Width = 60;
            dtaGiai.Columns[6].HeaderText = "Điểm hòa";
            dtaGiai.Columns[7].Width = 60;
            dtaGiai.Columns[7].HeaderText = "Điểm thua";
            dtaGiai.Columns[8].Width = 50;
            dtaGiai.Columns[8].HeaderText = "Số lượt";
            dtaGiai.Columns[9].Width = 50;
            dtaGiai.Columns[9].HeaderText = "Loại";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
