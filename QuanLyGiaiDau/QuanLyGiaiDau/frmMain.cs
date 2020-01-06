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
            lblWelcome.Font = new Font("Arial", 25);
            lblWelcome.ForeColor = Color.GreenYellow;
            lblWelcome.Left += 50;
            lblOption.Text = "Hệ thống quản lý giải đấu";
            lblOption.Left += 40;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmTime create = new frmTime();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadText();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmGroup create = new frmGroup();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            frmCreTeam create = new frmCreTeam();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
        }

        private void btnKicker_Click(object sender, EventArgs e)
        {
            frmKicker create = new frmKicker();
            create.StartPosition = FormStartPosition.CenterParent;
            create.ShowDialog();
        }
    }
}
