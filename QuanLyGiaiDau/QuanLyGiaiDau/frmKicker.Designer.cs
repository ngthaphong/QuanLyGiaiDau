namespace QuanLyGiaiDau
{
    partial class frmKicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpKicker = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtaNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboSoAo = new System.Windows.Forms.ComboBox();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDoi = new System.Windows.Forms.ComboBox();
            this.grpKicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKicker
            // 
            this.grpKicker.Controls.Add(this.cboDoi);
            this.grpKicker.Controls.Add(this.label5);
            this.grpKicker.Controls.Add(this.cboViTri);
            this.grpKicker.Controls.Add(this.cboSoAo);
            this.grpKicker.Controls.Add(this.dtaNgaySinh);
            this.grpKicker.Controls.Add(this.txtHoTen);
            this.grpKicker.Controls.Add(this.label2);
            this.grpKicker.Controls.Add(this.label4);
            this.grpKicker.Controls.Add(this.label3);
            this.grpKicker.Controls.Add(this.label1);
            this.grpKicker.Location = new System.Drawing.Point(12, 12);
            this.grpKicker.Name = "grpKicker";
            this.grpKicker.Size = new System.Drawing.Size(280, 311);
            this.grpKicker.TabIndex = 0;
            this.grpKicker.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(51, 103);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(212, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // dtaNgaySinh
            // 
            this.dtaNgaySinh.Location = new System.Drawing.Point(63, 158);
            this.dtaNgaySinh.Name = "dtaNgaySinh";
            this.dtaNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtaNgaySinh.TabIndex = 3;
            // 
            // cboSoAo
            // 
            this.cboSoAo.FormattingEnabled = true;
            this.cboSoAo.Location = new System.Drawing.Point(47, 215);
            this.cboSoAo.Name = "cboSoAo";
            this.cboSoAo.Size = new System.Drawing.Size(126, 21);
            this.cboSoAo.TabIndex = 4;
            // 
            // cboViTri
            // 
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(41, 275);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(132, 21);
            this.cboViTri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số áo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vị trí:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(53, 371);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(164, 371);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đội:";
            // 
            // cboDoi
            // 
            this.cboDoi.FormattingEnabled = true;
            this.cboDoi.Location = new System.Drawing.Point(38, 53);
            this.cboDoi.Name = "cboDoi";
            this.cboDoi.Size = new System.Drawing.Size(225, 21);
            this.cboDoi.TabIndex = 6;
            // 
            // frmKicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 406);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpKicker);
            this.Name = "frmKicker";
            this.Text = "Cầu thủ";
            this.Load += new System.EventHandler(this.frmKicker_Load);
            this.grpKicker.ResumeLayout(false);
            this.grpKicker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKicker;
        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.ComboBox cboSoAo;
        private System.Windows.Forms.DateTimePicker dtaNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboDoi;
        private System.Windows.Forms.Label label5;
    }
}