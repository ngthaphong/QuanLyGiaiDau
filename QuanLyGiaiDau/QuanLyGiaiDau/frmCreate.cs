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
            DTO_DAIDIEN dd = new DTO_DAIDIEN();
            DTO_DANGKY dk = new DTO_DANGKY();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            DataTable t = giai.getGIAIDAU();
            cboGiaiDau.DataSource = t;
            cboGiaiDau.DisplayMember = "TenGiai";
        }
    }
}
