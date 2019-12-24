using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUS_QuanLyGiaiDau;
using DTO_QuanLyGiaiDau;

namespace QuanLyGiaiDau
{
    public partial class frmLogin : Form
    {
        BUS_DANGNHAP busdn = new BUS_DANGNHAP();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Username hoặc Password không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable t=busdn.getDANGNHAP();
                foreach (DataRow row in t.Rows)
                {
                    if (row.Field<string>(1) == txtUser.Text && row.Field<string>(2) == txtPass.Text)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUS_Main.setMaDN(txtUser.Text, txtPass.Text);
                        txtUser.Text = null;
                        txtPass.Text = null;
                        this.Hide();
                        frmMain main = new frmMain();
                        main.StartPosition = FormStartPosition.CenterScreen;
                        main.ShowDialog();
                        return;
                    }
                }
                if (txtUser.Text != null || txtPass.Text != null)
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Rất tiếc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = null;
                    txtPass.Text = null;
                }
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Username hoặc Password không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string matk = busdn.nextMa("TK");
                //init
                DTO_DANGNHAP dtodn = new DTO_DANGNHAP(matk,txtUser.Text,txtPass.Text);
                if (busdn.addDANGNHAP(dtodn))
                {
                    MessageBox.Show("Đã đăng kí thành công tài khoản, vui lòng đăng nhập để vào chương trình.", "Chúc mừng! Đăng kí thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
    }
}
