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
    public partial class frmRank : Form
    {
        public frmRank()
        {
            InitializeComponent();

        }
        BUS_XEPHANG x = new BUS_XEPHANG();
        BUS_GIAIDAU g = new BUS_GIAIDAU();
        private void frmRank_Load(object sender, EventArgs e)
        {
            cboGiai.DataSource = g.getGIAIDAU();
            cboGiai.DisplayMember = "TenGiai";
            cboGiai.ValueMember = "MaGiai";
            string mag = (string)cboGiai.SelectedValue;
            dtaXepHang.DataSource = x.getSoDiem(mag);
            //dtaXepHang.DataSource = x.getHieuSo("MG2");
        }

        private void cboGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "MaGiai";
            string mag = (string)cboGiai.SelectedValue;
            dtaXepHang.DataSource = x.getXEPHANG();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cboGiai.ValueMember = "Loai";
            int loai = (int)cboGiai.SelectedValue;
            cboGiai.ValueMember = "MaGiai";
            string mag = (string)cboGiai.SelectedValue;
            if (loai == 2)
            {
                x.ListRank(mag);
                x.addRank(loai,mag);
                dtaXepHang.DataSource = x.SortRank(mag);
            }
            else
            {
                x.ListRank((string)cboGiai.SelectedValue);
                x.addRank(loai,mag);
                dtaXepHang.DataSource = x.SortRank(mag);
            }
        }
    }
}
