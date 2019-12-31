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
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            btnBang.BackColor = Color.Gray;
            btnBang.ForeColor = Color.OrangeRed;
            btnMoHinh.BackColor = Color.Gray;
            btnMoHinh.ForeColor = Color.OrangeRed;
            btnBang_Click(sender, e);
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            btnBang.BackColor = Color.GreenYellow;
            btnMoHinh.BackColor = Color.Gray;
        }

        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            btnMoHinh.BackColor = Color.GreenYellow;
            btnBang.BackColor = Color.Gray;
        }
    }
}
