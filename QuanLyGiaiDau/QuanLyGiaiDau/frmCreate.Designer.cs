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
            this.grbDangKy = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGiaiDau = new System.Windows.Forms.ComboBox();
            this.grbDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDaiDien
            // 
            this.txtDaiDien.Location = new System.Drawing.Point(58, 72);
            this.txtDaiDien.Name = "txtDaiDien";
            this.txtDaiDien.Size = new System.Drawing.Size(228, 20);
            this.txtDaiDien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đại diện";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(50, 201);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // dtaNgayDangKy
            // 
            this.dtaNgayDangKy.Location = new System.Drawing.Point(86, 126);
            this.dtaNgayDangKy.Name = "dtaNgayDangKy";
            this.dtaNgayDangKy.Size = new System.Drawing.Size(200, 20);
            this.dtaNgayDangKy.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(175, 201);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // grbDangKy
            // 
            this.grbDangKy.Controls.Add(this.cboGiaiDau);
            this.grbDangKy.Controls.Add(this.txtDaiDien);
            this.grbDangKy.Controls.Add(this.dtaNgayDangKy);
            this.grbDangKy.Controls.Add(this.label2);
            this.grbDangKy.Controls.Add(this.label3);
            this.grbDangKy.Controls.Add(this.label1);
            this.grbDangKy.Controls.Add(this.btnThoat);
            this.grbDangKy.Controls.Add(this.btnTao);
            this.grbDangKy.Location = new System.Drawing.Point(12, 12);
            this.grbDangKy.Name = "grbDangKy";
            this.grbDangKy.Size = new System.Drawing.Size(306, 230);
            this.grbDangKy.TabIndex = 4;
            this.grbDangKy.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giải đấu:";
            // 
            // cboGiaiDau
            // 
            this.cboGiaiDau.FormattingEnabled = true;
            this.cboGiaiDau.Location = new System.Drawing.Point(58, 19);
            this.cboGiaiDau.Name = "cboGiaiDau";
            this.cboGiaiDau.Size = new System.Drawing.Size(228, 21);
            this.cboGiaiDau.TabIndex = 4;
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 258);
            this.Controls.Add(this.grbDangKy);
            this.Name = "frmCreate";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.grbDangKy.ResumeLayout(false);
            this.grbDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDaiDien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.DateTimePicker dtaNgayDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGiaiDau;
    }
}