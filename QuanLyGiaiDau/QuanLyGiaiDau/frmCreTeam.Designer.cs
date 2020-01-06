namespace QuanLyGiaiDau
{
    partial class frmCreTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreTeam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboXoa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtaDoi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDaiDien = new System.Windows.Forms.ComboBox();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTenHLV = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDoiTruong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboThanhVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtaDoi);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 645);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboXoa);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(922, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 73);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa đội tuyển";
            // 
            // cboXoa
            // 
            this.cboXoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoa.FormattingEnabled = true;
            this.cboXoa.Location = new System.Drawing.Point(14, 19);
            this.cboXoa.Name = "cboXoa";
            this.cboXoa.Size = new System.Drawing.Size(267, 21);
            this.cboXoa.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(112, 46);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.shirt;
            this.pictureBox1.Location = new System.Drawing.Point(922, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 186);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(929, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quản lý đội bóng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bảng danh sách các đội:";
            // 
            // dtaDoi
            // 
            this.dtaDoi.BackgroundColor = System.Drawing.Color.White;
            this.dtaDoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDoi.EnableHeadersVisualStyles = false;
            this.dtaDoi.Location = new System.Drawing.Point(3, 37);
            this.dtaDoi.Name = "dtaDoi";
            this.dtaDoi.RowHeadersVisible = false;
            this.dtaDoi.Size = new System.Drawing.Size(913, 605);
            this.dtaDoi.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboDaiDien);
            this.groupBox1.Controls.Add(this.txtTenDoi);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtTenHLV);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtDoiTruong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCreate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboThanhVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(922, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 317);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hãy tạo một đội tuyển";
            // 
            // cboDaiDien
            // 
            this.cboDaiDien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboDaiDien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDaiDien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cboDaiDien.FormattingEnabled = true;
            this.cboDaiDien.Location = new System.Drawing.Point(14, 56);
            this.cboDaiDien.Name = "cboDaiDien";
            this.cboDaiDien.Size = new System.Drawing.Size(185, 21);
            this.cboDaiDien.TabIndex = 11;
            this.cboDaiDien.SelectedIndexChanged += new System.EventHandler(this.cboDaiDien_SelectedIndexChanged);
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenDoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTenDoi.Location = new System.Drawing.Point(14, 96);
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(260, 20);
            this.txtTenDoi.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(159, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTenHLV
            // 
            this.txtTenHLV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTenHLV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTenHLV.Location = new System.Drawing.Point(14, 135);
            this.txtTenHLV.Name = "txtTenHLV";
            this.txtTenHLV.Size = new System.Drawing.Size(260, 20);
            this.txtTenHLV.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCreate.Location = new System.Drawing.Point(78, 290);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDoiTruong
            // 
            this.txtDoiTruong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDoiTruong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDoiTruong.Location = new System.Drawing.Point(14, 174);
            this.txtDoiTruong.Name = "txtDoiTruong";
            this.txtDoiTruong.Size = new System.Drawing.Size(260, 20);
            this.txtDoiTruong.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(10, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đại diện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đội:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đội trưởng:";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(48, 260);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(0, 13);
            this.lblCreate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(11, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Màu áo:";
            // 
            // cboThanhVien
            // 
            this.cboThanhVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboThanhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThanhVien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cboThanhVien.FormattingEnabled = true;
            this.cboThanhVien.Location = new System.Drawing.Point(14, 213);
            this.cboThanhVien.Name = "cboThanhVien";
            this.cboThanhVien.Size = new System.Drawing.Size(260, 21);
            this.cboThanhVien.TabIndex = 8;
            this.cboThanhVien.SelectedIndexChanged += new System.EventHandler(this.cboThanhVien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên huấn luyện viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(11, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số thành viên:";
            // 
            // txtMau
            // 
            this.txtMau.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMau.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMau.Location = new System.Drawing.Point(14, 252);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(260, 20);
            this.txtMau.TabIndex = 12;
            // 
            // frmCreTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(1245, 669);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCreTeam";
            this.Text = "Tạo đội bóng";
            this.Load += new System.EventHandler(this.frmCreTeam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTenDoi;
        private System.Windows.Forms.TextBox txtDoiTruong;
        private System.Windows.Forms.TextBox txtTenHLV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboThanhVien;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDaiDien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtaDoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboXoa;
        private System.Windows.Forms.TextBox txtMau;
    }
}