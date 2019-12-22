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
        public frmCreGroup()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenGiai.Text) || txtTenGiai.TextLength < 6 || txtTenGiai.TextLength >= 50)
            {
                MessageBox.Show("Bạn không nhập vào tên giải! Hoặc tên giải nhập sai, tên giải cần lớn hơn 5 kí tự và bé hơn 50 kí tự!", "Thử lại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //get last matk
                DataTable t = giai.topGIAIDAU();
                string Tmag = t.Rows[0].Field<string>(0);
                //get int in a string to add 1 after string
                string mag = Regex.Match(Tmag, @"\d+").Value;
                int ma = Int32.Parse(mag);
                ma++; mag = null;
                mag += "MG"; mag += ma;
                DTO_GIAIDAU dto = new DTO_GIAIDAU(mag, txtTenGiai.Text, dateBegin.Value, dateEnd.Value);
                if (giai.addGIAIDAU(dto))
                {
                    MessageBox.Show("Đã hoàn tất tạo giải đấu", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Tạo thất bại, xin thử lại", "Rất tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
