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
    public partial class frmKicker : Form
    {
        BUS_CAUTHU ct = new BUS_CAUTHU();
        BUS_DOI d = new BUS_DOI();
        BUS_THONGKECT tk = new BUS_THONGKECT();
        public frmKicker()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            //refresh
            DataTable t = ct.tableLimitCauThu();
            var result = from table in t.AsEnumerable()
                         select
                            new
                            {
                                MaCT = table.Field<string>("MaCT"),
                                TenDoi = table.Field<string>("MaDoi") + " - tên: " + table.Field<string>("HoTenCT") + " - ngày sinh: " + table.Field<DateTime>("NgaySinh")
                            };
            cboXoa.DataSource = result.ToArray();
            cboXoa.DisplayMember = "TenDoi";
            cboXoa.ValueMember = "MaCT";
            dtaCauThu.DataSource = ct.tableCauThu();
            t = d.getLimited();
            var results = from table in t.AsEnumerable()
                         select
                            new
                            {
                                MaDoi = table.Field<string>("MaDoi"),
                                TenDoi = table.Field<string>("TenDoi") + " - thành viên: " + table.Field<int>("SoCauThu") + " - tổng: " + table.Field<int>("SoThanhVien")
                            };
            cboDoi.DataSource = results.ToArray();
            cboDoi.DisplayMember = "TenDoi";
            cboDoi.ValueMember = "MaDoi";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            // combobox with 3 colum
            DataTable t = tk.getTHONGKECT();
            t.Columns.Remove("MaGiai");
            t.Columns.Remove("MaDoi");
            t.Columns.Remove("SoAo");
            dtaTK.DefaultCellStyle.SelectionBackColor = dtaTK.DefaultCellStyle.BackColor;
            dtaTK.DefaultCellStyle.SelectionForeColor = Color.Purple;
            dtaTK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaTK.ColumnHeadersDefaultCellStyle.Font = new Font(dtaTK.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaTK.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaTK.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaTK.DataSource = t;
            /////////
            refresh();
            dtaTK.Columns[0].Width = 150;
            dtaTK.Columns[0].HeaderText = "Họ tên";
            dtaTK.Columns[1].Width = 50;
            dtaTK.Columns[1].HeaderText = "Bàn thắng";
            dtaTK.Columns[2].Width = 50;
            dtaTK.Columns[2].HeaderText = "Thẻ vàng";
            dtaTK.Columns[3].Width = 50;
            dtaTK.Columns[3].HeaderText = "Thẻ đỏ";
            /////////////
            dtaCauThu.DataSource = ct.tableCauThu();
            dtaCauThu.Columns[0].Width = 200;
            dtaCauThu.Columns[0].HeaderText = "Tên đội";
            dtaCauThu.Columns[0].ReadOnly = true;
            dtaCauThu.Columns[0].Frozen = true;
            dtaCauThu.Columns[0].DefaultCellStyle.Font = new Font(dtaCauThu.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaCauThu.Columns[1].Width = 280;
            dtaCauThu.Columns[1].HeaderText = "Họ tên cầu thủ";
            dtaCauThu.Columns[1].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaCauThu.Columns[1].ReadOnly = true;
            dtaCauThu.Columns[2].Width = 120;
            dtaCauThu.Columns[2].HeaderText = "Ngày sinh";
            dtaCauThu.Columns[2].ReadOnly = true;
            dtaCauThu.Columns[3].Width = 70;
            dtaCauThu.Columns[3].HeaderText = "Số áo";
            dtaCauThu.Columns[3].DefaultCellStyle.BackColor = Color.ForestGreen;
            dtaCauThu.Columns[3].ReadOnly = true;
            dtaCauThu.Columns[4].Width = 150;
            dtaCauThu.Columns[4].HeaderText = "Vị trí";
            dtaCauThu.Columns[4].ReadOnly = true;

            dtaCauThu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtaCauThu.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dtaCauThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dtaCauThu.ColumnHeadersDefaultCellStyle.Font = new Font(dtaCauThu.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dtaCauThu.ColumnHeadersHeight = 30;
            dtaCauThu.RowsDefaultCellStyle.ForeColor = Color.Purple;
            dtaCauThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtaCauThu.AllowUserToResizeRows = false;
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
                string mact = ct.nextMa();
                string mad = (string)cboDoi.SelectedValue;
                int soao = (int)cboSoAo.SelectedValue;
                string vitri = (string)cboViTri.SelectedValue;
                DTO_CAUTHU dtoct = new DTO_CAUTHU(mact, mad, txtHoTen.Text, dtaNgaySinh.Value, soao, vitri);
                if (ct.addCAUTHU(dtoct))
                {
                    MessageBox.Show("Đã thêm thành công cầu thủ", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // refresh combobox
                    refresh();
                }
                else MessageBox.Show("Thêm thất bại vui lòng thử lại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cboXoa.ValueMember = "MaCT";
            ct.delCAUTHU((string)cboXoa.SelectedValue);
            

            refresh();
        }

        private void dtaCauThu_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtaCauThu.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                string mad = d.getMa(row.Cells[0].Value.ToString());
                dtaTK.DataSource = ct.getThongKe(mad, row.Cells[1].Value.ToString());
            }
        }
    }
}
