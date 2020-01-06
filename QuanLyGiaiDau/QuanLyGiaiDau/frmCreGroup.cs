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
using System.Text.RegularExpressions;

namespace QuanLyGiaiDau
{
    public partial class frmCreGroup : Form
    {
        BUS_GIAIDAU giai = new BUS_GIAIDAU();
        BUS_VONG v = new BUS_VONG();
        //init controls global
        NumericUpDown numSoDoi = new NumericUpDown();
        ComboBox cboSoThanhVien = new ComboBox();
        TextBox txtThang = new TextBox();
        TextBox txtHoa = new TextBox();
        TextBox txtThua = new TextBox();
        Button btn1 = new Button();
        Button btn2 = new Button();
        public frmCreGroup()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreate them = new frmCreate();
            them.StartPosition = FormStartPosition.CenterParent;
            them.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DTO_VONG dtov = new DTO_VONG();
            if (string.IsNullOrEmpty(txtTenGiai.Text) || txtTenGiai.TextLength < 6 || txtTenGiai.TextLength >= 50)
            {
                MessageBox.Show("Bạn không nhập vào tên giải! Hoặc tên giải nhập sai, tên giải cần lớn hơn 5 kí tự và bé hơn 50 kí tự!", "Thử lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mag = giai.nextMa("MG");
                int? sodoi, stv, dtg, dh, dth, luot, loai;
                if (radLoai.Checked == true)
                {
                    loai = 1;
                    sodoi = (int)numSoDoi.Value;
                    if (!giai.checkSoDoi1(sodoi) || sodoi>64)
                    {
                        MessageBox.Show("Số đội phải từ 2-64 người!", "Thử lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        numSoDoi.Focus();
                    }
                    stv = (int)cboSoThanhVien.SelectedValue;
                    dtg = null;dh = null;dth = null;luot = null;
                    //do it
                    DTO_GIAIDAU dto = new DTO_GIAIDAU(mag, txtTenGiai.Text, dateBegin.Value, dateEnd.Value, sodoi, stv, dtg, dh, dth, luot, loai);
                    if (giai.addGIAIDAU(dto))
                    {
                        MessageBox.Show("Đã hoàn tất tạo giải đấu, vui lòng cập nhật giải đấu bằng cách nhấp vào nút 'Thêm đại diện' ở bên dưới", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (sodoi % 2 == 0) v.addVongChan((int)sodoi, mag);
                        else v.addVongLe((int)sodoi, mag);
                    }
                    else MessageBox.Show("Tạo giải thất bại, vui lòng thử lại!", "Rất tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (radTron.Checked == true)
                {
                    loai = 2;
                    sodoi = (int)numSoDoi.Value;
                    if (!giai.checkSoDoi2(sodoi))
                    {
                        MessageBox.Show("Số đội phải từ 2-30 người!", "Thử lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        numSoDoi.Focus();
                    }
                    stv = (int)cboSoThanhVien.SelectedValue;
                    dtg = int.Parse(txtThang.Text);
                    dh = int.Parse(txtHoa.Text);
                    dth = int.Parse(txtThua.Text);
                    if (btn1.BackColor == Color.GreenYellow) luot = 1;
                    else luot = 2;
                    //do it
                    DTO_GIAIDAU dto = new DTO_GIAIDAU(mag, txtTenGiai.Text, dateBegin.Value, dateEnd.Value, sodoi, stv, dtg, dh, dth, luot, loai);
                    if (giai.addGIAIDAU(dto))
                    {
                        MessageBox.Show("Đã hoàn tất tạo giải đấu, vui lòng cập nhật giải đấu bằng cách nhấp vào nút 'Thêm đại diện' ở bên dưới", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        v.addVongTron((int)sodoi, mag, (int)luot);
                    }
                    else MessageBox.Show("Tạo giải thất bại, vui lòng thử lại!", "Rất tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mời check vào Phân loại!", "Thử lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sodoi = null; stv = null; dtg = null; dh = null; dth = null; luot = null;loai = null;
                }
            }
        }

        private void radLoai_CheckedChanged(object sender, EventArgs e)
        {
            //init controls
            GroupBox grpLoai = new GroupBox();
            Label lblSoDoi = new Label();
            NumericUpDown numSoDoi = new NumericUpDown();
            Label lblSoThanhVien = new Label();
            ComboBox cboSoThanhVien = new ComboBox();
            if (radLoai.Checked == true)
            {
                //add more space
                this.Height += 98;
                panGiaiDau.Height += 98;
                btnCreate.Location = new Point(63, 329 + 98);
                btnExit.Location = new Point(162, 329 + 98);
                //add property
                    //grpLoai
                grpLoai.Location = new Point(7, 315);
                grpLoai.Name = "grpLoai";
                grpLoai.Size = new Size(281, 100);
                grpLoai.Text = "Loại trực tiếp";
                grpLoai.ForeColor = Color.MidnightBlue;
                panGiaiDau.Controls.Add(grpLoai);
                grpLoai.Controls.Add(lblSoDoi);
                grpLoai.Controls.Add(numSoDoi);
                grpLoai.Controls.Add(lblSoThanhVien);
                grpLoai.Controls.Add(cboSoThanhVien);
                    //lblSodoi
                lblSoDoi.Name = "lblSoDoi";
                lblSoDoi.AutoSize = true;
                lblSoDoi.Text = "Số đội tham gia [2-64]:";
                lblSoDoi.Location = new Point(3, 16);
                lblSoDoi.ForeColor = Color.MidnightBlue;
                    //numSodoi
                numSoDoi.Name = "numSoDoi";
                numSoDoi.Location = new Point(3, 32); 
                numSoDoi.Size = new Size(120, 20);
                numSoDoi.TabIndex = 10;
                numSoDoi.Value = new decimal(new int[] { 2, 0, 0, 0 });
                numSoDoi.ForeColor = Color.MidnightBlue;
                    //lblSothanhvien
                lblSoThanhVien.Name = "lblSoThanhVien";
                lblSoThanhVien.AutoSize = true;
                lblSoThanhVien.Text = "Số người mỗi đội:";
                lblSoThanhVien.Location = new Point(3, 55);
                lblSoThanhVien.ForeColor = Color.MidnightBlue;
                    //cboSothanhvien
                cboSoThanhVien.Name = "cboSoThanhVien";
                cboSoThanhVien.FormattingEnabled = true;
                cboSoThanhVien.Location = new Point(3, 71);
                cboSoThanhVien.Size = new Size(121, 21);
                cboSoThanhVien.TabIndex = 11;
                cboSoThanhVien.ForeColor = Color.MidnightBlue;
                cboSoThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
                //add element
                int[] stv = new int[4];
                stv[0] = 5; stv[1] = 7; stv[2] = 9; stv[3] = 11;
                cboSoThanhVien.DataSource = stv;
                this.cboSoThanhVien = cboSoThanhVien;
                this.numSoDoi = numSoDoi;
            }
            else
            {
                //less space
                this.Height -= 98;
                panGiaiDau.Height -= 98;
                btnCreate.Location = new Point(63, 329);
                btnExit.Location = new Point(162, 329);
                panGiaiDau.Controls.Remove(panGiaiDau.Controls.Find("grpLoai", true)[0]);
                grpLoai.Dispose();
            }
        }

        private void radTron_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox grpTron = new GroupBox();
            Label lblSoDoi = new Label();
            NumericUpDown numSoDoi = new NumericUpDown();
            Label lblSoThanhVien = new Label();
            ComboBox cboSoThanhVien = new ComboBox();
            Label lblThang = new Label();
            TextBox txtThang = new TextBox();
            Label lblHoa = new Label();
            TextBox txtHoa = new TextBox();
            Label lblThua = new Label();
            TextBox txtThua = new TextBox();
            Label lblSoLuot = new Label();
            Button btn1 = new Button();
            Button btn2 = new Button();
            if (radTron.Checked == true)
            {
                //add more space
                this.Height += 184;
                panGiaiDau.Height += 184;
                btnCreate.Location = new Point(63, 329 + 184);
                btnExit.Location = new Point(162, 329 + 184);
                //add property
                    //grpTron
                grpTron.Location = new Point(7, 315);
                grpTron.Name = "grpTron";
                grpTron.Size = new Size(281, 183);
                grpTron.Text = "Đấu vòng tròn";
                grpTron.ForeColor = Color.MidnightBlue;
                panGiaiDau.Controls.Add(grpTron);
                grpTron.Controls.Add(lblSoDoi);
                grpTron.Controls.Add(cboSoThanhVien);
                grpTron.Controls.Add(lblThang);
                grpTron.Controls.Add(btn2);
                grpTron.Controls.Add(lblSoLuot);
                grpTron.Controls.Add(btn1);
                grpTron.Controls.Add(lblSoThanhVien);
                grpTron.Controls.Add(numSoDoi);
                grpTron.Controls.Add(lblHoa);
                grpTron.Controls.Add(txtThua);
                grpTron.Controls.Add(lblThua);
                grpTron.Controls.Add(txtHoa);
                grpTron.Controls.Add(txtThang);
                    //lblSodoi
                lblSoDoi.AutoSize = true;
                lblSoDoi.Location = new Point(3, 16);
                lblSoDoi.Name = "lblSoDoi";
                lblSoDoi.Text = "Số đội tham gia [2-30]:";
                lblSoDoi.ForeColor = Color.MidnightBlue;
                    //numSodoi
                numSoDoi.Location = new Point(3, 32);
                numSoDoi.Name = "numSoDoi";
                numSoDoi.Size = new Size(120, 20);
                numSoDoi.Value = new decimal(new int[] {2,0,0,0});
                numSoDoi.ForeColor = Color.MidnightBlue;
                    //lblThang
                lblThang.AutoSize = true;
                lblThang.Location = new Point(3, 55);
                lblThang.Name = "lblThang";
                lblThang.Text = "Điểm thắng:";
                lblThang.ForeColor = Color.MidnightBlue;
                    //lblHoa
                lblHoa.AutoSize = true;
                lblHoa.Location = new Point(117, 55);
                lblHoa.Name = "lblHoa";
                lblHoa.Text = "Điểm hòa:";
                lblHoa.ForeColor = Color.MidnightBlue;
                    // lblThua
                lblThua.AutoSize = true;
                lblThua.Location = new Point(217, 55);
                lblThua.Name = "lblThua";
                lblThua.Text = "Điểm thua:";
                lblThua.ForeColor = Color.MidnightBlue;
                    // txtThang
                txtThang.Location = new Point(6, 71);
                txtThang.Name = "txtThang";
                txtThang.Size = new Size(57, 20);
                txtThang.ForeColor = Color.MidnightBlue;
                    // txtHoa
                txtHoa.Location = new Point(120, 71);
                txtHoa.Name = "txtHoa";
                txtHoa.Size = new Size(52, 20);
                txtHoa.ForeColor = Color.MidnightBlue;
                    // txtThua
                txtThua.Location = new Point(220, 71);
                txtThua.Name = "txtThua";
                txtThua.Size = new Size(55, 20);
                txtThua.ForeColor = Color.MidnightBlue;
                    // lblSoLuot
                lblSoLuot.AutoSize = true;
                lblSoLuot.Location = new Point(3, 104);
                lblSoLuot.Name = "lblSoLuot";
                lblSoLuot.Text = "Số lượt đá vòng tròn:";
                lblSoLuot.ForeColor = Color.MidnightBlue;
                    // btn1
                btn1.Location = new Point(129, 97);
                btn1.Name = "btn1";
                btn1.Size = new Size(52, 26);
                btn1.Text = "1";
                btn1.UseVisualStyleBackColor = true;
                btn1.ForeColor = Color.MidnightBlue;
                btn1.Click += new System.EventHandler(this.btn1_Click);
                    // btn2
                btn2.Location = new Point(187, 97);
                btn2.Name = "btn2";
                btn2.Size = new Size(52, 26);
                btn2.Text = "2";
                btn2.UseVisualStyleBackColor = true;
                btn2.ForeColor = Color.MidnightBlue;
                btn2.Click += new System.EventHandler(this.btn2_Click);
                // lblSoThanhVien
                lblSoThanhVien.AutoSize = true;
                lblSoThanhVien.Location = new Point(3, 135);
                lblSoThanhVien.Name = "lblSoThanhVien";
                lblSoThanhVien.Text = "Số người mỗi đội:";
                lblSoThanhVien.ForeColor = Color.MidnightBlue;
                    // cboSoThanhVien
                cboSoThanhVien.FormattingEnabled = true;
                cboSoThanhVien.Location = new Point(6, 151);
                cboSoThanhVien.Name = "cboSoThanhVien";
                cboSoThanhVien.ForeColor = Color.MidnightBlue;
                cboSoThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
                cboSoThanhVien.Size = new Size(121, 21);
                //add element
                int[] stv = new int[4];
                stv[0] = 5; stv[1] = 7; stv[2] = 9; stv[3] = 11;
                cboSoThanhVien.DataSource = stv;
                this.numSoDoi = numSoDoi;
                this.cboSoThanhVien = cboSoThanhVien;
                this.txtThang = txtThang;
                this.txtHoa = txtHoa;
                this.txtThua = txtThua;
                this.btn1 = btn1;
                this.btn2 = btn2;
            }
            else
            {
                this.Height -= 184;
                panGiaiDau.Height -= 184;
                btnCreate.Location = new Point(63, 329);
                btnExit.Location = new Point(162, 329);
                panGiaiDau.Controls.Remove(panGiaiDau.Controls.Find("grpTron", true)[0]);
                grpTron.Dispose();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.GreenYellow;
            btn2.BackColor = Color.Transparent;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.GreenYellow;
            btn1.BackColor = Color.Transparent;
        }
    }
}
