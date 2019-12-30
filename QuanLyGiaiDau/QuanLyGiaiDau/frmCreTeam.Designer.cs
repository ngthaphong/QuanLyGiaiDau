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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboDaiDien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.cboThanhVien = new System.Windows.Forms.ComboBox();
            this.cboMau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoiTruong = new System.Windows.Forms.TextBox();
            this.txtTenHLV = new System.Windows.Forms.TextBox();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboDaiDien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblCreate);
            this.panel1.Controls.Add(this.cboThanhVien);
            this.panel1.Controls.Add(this.cboMau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDoiTruong);
            this.panel1.Controls.Add(this.txtTenHLV);
            this.panel1.Controls.Add(this.txtTenDoi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 417);
            this.panel1.TabIndex = 1;
            // 
            // cboDaiDien
            // 
            this.cboDaiDien.FormattingEnabled = true;
            this.cboDaiDien.Location = new System.Drawing.Point(7, 86);
            this.cboDaiDien.Name = "cboDaiDien";
            this.cboDaiDien.Size = new System.Drawing.Size(185, 21);
            this.cboDaiDien.TabIndex = 11;
            this.cboDaiDien.SelectedIndexChanged += new System.EventHandler(this.cboDaiDien_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đại diện:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(188, 380);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm cầu thủ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(41, 390);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(0, 13);
            this.lblCreate.TabIndex = 2;
            // 
            // cboThanhVien
            // 
            this.cboThanhVien.FormattingEnabled = true;
            this.cboThanhVien.Location = new System.Drawing.Point(7, 292);
            this.cboThanhVien.Name = "cboThanhVien";
            this.cboThanhVien.Size = new System.Drawing.Size(260, 21);
            this.cboThanhVien.TabIndex = 8;
            this.cboThanhVien.SelectedIndexChanged += new System.EventHandler(this.cboThanhVien_SelectedIndexChanged);
            // 
            // cboMau
            // 
            this.cboMau.FormattingEnabled = true;
            this.cboMau.Location = new System.Drawing.Point(7, 346);
            this.cboMau.Name = "cboMau";
            this.cboMau.Size = new System.Drawing.Size(260, 21);
            this.cboMau.TabIndex = 7;
            this.cboMau.SelectedIndexChanged += new System.EventHandler(this.cboMau_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tạo một đội tuyển";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên huấn luyện viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Màu áo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đội trưởng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đội:";
            // 
            // txtDoiTruong
            // 
            this.txtDoiTruong.Location = new System.Drawing.Point(7, 232);
            this.txtDoiTruong.Name = "txtDoiTruong";
            this.txtDoiTruong.Size = new System.Drawing.Size(260, 20);
            this.txtDoiTruong.TabIndex = 0;
            // 
            // txtTenHLV
            // 
            this.txtTenHLV.Location = new System.Drawing.Point(7, 178);
            this.txtTenHLV.Name = "txtTenHLV";
            this.txtTenHLV.Size = new System.Drawing.Size(260, 20);
            this.txtTenHLV.TabIndex = 0;
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.Location = new System.Drawing.Point(7, 126);
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(260, 20);
            this.txtTenDoi.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(161, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(56, 435);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmCreTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(311, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnExit);
            this.Name = "frmCreTeam";
            this.Text = "Tạo đội bóng";
            this.Load += new System.EventHandler(this.frmCreTeam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboMau;
        private System.Windows.Forms.ComboBox cboThanhVien;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDaiDien;
    }
}