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

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreate them = new frmCreate();
            them.ShowDialog();
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
                string mag = giai.nextMa("MG");
                DTO_GIAIDAU dto = new DTO_GIAIDAU(mag, txtTenGiai.Text, dateBegin.Value, dateEnd.Value);
                if (giai.addGIAIDAU(dto))
                {
                    MessageBox.Show("Đã hoàn tất tạo giải đấu, vui lòng cập nhật giải đấu bằng cách nhấp vào nút 'Thêm đại diện' ở bên dưới", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Tạo thất bại, xin thử lại", "Rất tiếc!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
