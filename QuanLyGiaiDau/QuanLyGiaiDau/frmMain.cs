using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void LoadText()
        {
            lblWelcome.Text = "Chào mừng bạn đến với Giải Đấu";
            lblWelcome.Height += 52;
            lblOption.Text = "Hệ thống quản lý giải đấu";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadText();
        }
    }
}
