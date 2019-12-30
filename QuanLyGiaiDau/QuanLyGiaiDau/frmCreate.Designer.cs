namespace QuanLyGiaiDau
{
    partial class frmCreate
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
            this.txtDaiDien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.dtaNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbGiai = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtaGiai = new System.Windows.Forms.DataGridView();
            this.cboGiaiDau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panDangKy = new System.Windows.Forms.Panel();
            this.grbGiai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiai)).BeginInit();
            this.panDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDaiDien
            // 
            this.txtDaiDien.Location = new System.Drawing.Point(358, 171);
            this.txtDaiDien.Name = "txtDaiDien";
            this.txtDaiDien.Size = new System.Drawing.Size(228, 20);
            this.txtDaiDien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đại diện";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(365, 248);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // dtaNgayDangKy
            // 
            this.dtaNgayDangKy.Location = new System.Drawing.Point(386, 197);
            this.dtaNgayDangKy.Name = "dtaNgayDangKy";
            this.dtaNgayDangKy.Size = new System.Drawing.Size(200, 20);
            this.dtaNgayDangKy.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(459, 248);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbGiai
            // 
            this.grbGiai.Controls.Add(this.label4);
            this.grbGiai.Controls.Add(this.dtaGiai);
            this.grbGiai.Controls.Add(this.cboGiaiDau);
            this.grbGiai.Controls.Add(this.label3);
            this.grbGiai.Location = new System.Drawing.Point(3, 3);
            this.grbGiai.Name = "grbGiai";
            this.grbGiai.Size = new System.Drawing.Size(916, 162);
            this.grbGiai.TabIndex = 4;
            this.grbGiai.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xem trước giải sắp chọn:";
            // 
            // dtaGiai
            // 
            this.dtaGiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGiai.Location = new System.Drawing.Point(6, 80);
            this.dtaGiai.Name = "dtaGiai";
            this.dtaGiai.Size = new System.Drawing.Size(904, 58);
            this.dtaGiai.TabIndex = 5;
            // 
            // cboGiaiDau
            // 
            this.cboGiaiDau.FormattingEnabled = true;
            this.cboGiaiDau.Location = new System.Drawing.Point(65, 19);
            this.cboGiaiDau.Name = "cboGiaiDau";
            this.cboGiaiDau.Size = new System.Drawing.Size(228, 21);
            this.cboGiaiDau.TabIndex = 4;
            this.cboGiaiDau.SelectedIndexChanged += new System.EventHandler(this.cboGiaiDau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giải đấu:";
            // 
            // lblTao
            // 
            this.lblTao.AutoSize = true;
            this.lblTao.Location = new System.Drawing.Point(364, 235);
            this.lblTao.Name = "lblTao";
            this.lblTao.Size = new System.Drawing.Size(0, 13);
            this.lblTao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đăng ký";
            // 
            // panDangKy
            // 
            this.panDangKy.Controls.Add(this.lblTao);
            this.panDangKy.Controls.Add(this.grbGiai);
            this.panDangKy.Controls.Add(this.btnTao);
            this.panDangKy.Controls.Add(this.txtDaiDien);
            this.panDangKy.Controls.Add(this.btnThoat);
            this.panDangKy.Controls.Add(this.dtaNgayDangKy);
            this.panDangKy.Controls.Add(this.label1);
            this.panDangKy.Controls.Add(this.label2);
            this.panDangKy.Location = new System.Drawing.Point(12, 12);
            this.panDangKy.Name = "panDangKy";
            this.panDangKy.Size = new System.Drawing.Size(922, 277);
            this.panDangKy.TabIndex = 6;
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 301);
            this.Controls.Add(this.panDangKy);
            this.Name = "frmCreate";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.grbGiai.ResumeLayout(false);
            this.grbGiai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiai)).EndInit();
            this.panDangKy.ResumeLayout(false);
            this.panDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDaiDien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.DateTimePicker dtaNgayDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGiaiDau;
        private System.Windows.Forms.Label lblTao;
        private System.Windows.Forms.Panel panDangKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtaGiai;
    }
}