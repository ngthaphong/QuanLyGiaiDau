﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDau
{
    public partial class frmLogin : Form
    {
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
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username không được để trống", "WARING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Password không được để trống", "WARING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Hide();
            frmMain main = new frmMain();
            if (main.ShowDialog() != DialogResult.OK)
                Application.Exit();
            
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username không được để trống", "WARING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Password không được để trống", "WARING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Đã đăng kí thành công tài khoản, vui lòng đăng nhập để vào chương trình.", "Chúc mừng! Đăng kí thành công!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
