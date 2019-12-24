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
            btnTao.Enabled = true;
            lblTao.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
