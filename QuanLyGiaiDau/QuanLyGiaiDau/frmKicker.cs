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
    public partial class frmKicker : Form
    {
        BUS_CAUTHU ct = new BUS_CAUTHU();
        BUS_DOI d = new BUS_DOI();
        public frmKicker()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKicker_Load(object sender, EventArgs e)
        {
            int[] soao = new int[25];
            for (int i = 0; i < 25; i++)
            {
                soao[i] = i + 1;
            }
            cboSoAo.DataSource = soao;
            string[] vitri = new string[11];
            vitri[0] = "Thủ môn"; vitri[1] = "Hậu vệ"; vitri[2] = "Hậu vệ quét"; vitri[3] = "Hậu vệ biên"; vitri[4] = "Hậu vệ tấn công"; vitri[5] = "Trung vệ"; vitri[6] = "Tiền vệ phòng ngự"; vitri[7] = "Tiền vệ trung tâm"; vitri[8] = "Tiền vệ cánh"; vitri[9] = "Tiền vệ tấn công"; vitri[10] = "Tiền đạo";
            cboViTri.DataSource = vitri;
            cboDoi.DataSource = d.getDOI();
            cboDoi.DisplayMember = "TenDoi";
            cboDoi.ValueMember = "MaDoi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.TextLength < 6 || txtHoTen.TextLength > 50)
            {
                MessageBox.Show("Họ tên không được bé hơn 6 và vượt 50 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtaNgaySinh.Value.Year > 2007)
            {
                MessageBox.Show("Cầu thủ phải trên 12 tuổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mact = ct.nextMa("CT");
                string mad = cboDoi.ValueMember;
                int soao = (int)cboSoAo.SelectedValue;
                string vitri = (string)cboViTri.SelectedValue;
                DTO_CAUTHU dtoct = new DTO_CAUTHU(mact, mad, txtHoTen.Text, dtaNgaySinh.Value, soao, vitri);
                if (ct.addCAUTHU(dtoct)) MessageBox.Show("Đã thêm thành công cầu thủ", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Thêm thất bại vui lòng thử lại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
