﻿namespace QuanLyGiaiDau
{
    partial class frmTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtaTime = new System.Windows.Forms.DataGridView();
            this.panTime = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnMoHinh = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTime)).BeginInit();
            this.panTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Thi Đấu";
            // 
            // dtaTime
            // 
            this.dtaTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaTime.Location = new System.Drawing.Point(3, 3);
            this.dtaTime.Name = "dtaTime";
            this.dtaTime.Size = new System.Drawing.Size(1089, 553);
            this.dtaTime.TabIndex = 1;
            // 
            // panTime
            // 
            this.panTime.Controls.Add(this.dtaTime);
            this.panTime.Location = new System.Drawing.Point(12, 66);
            this.panTime.Name = "panTime";
            this.panTime.Size = new System.Drawing.Size(1095, 559);
            this.panTime.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnMoHinh
            // 
            this.btnMoHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoHinh.Location = new System.Drawing.Point(1053, 40);
            this.btnMoHinh.Name = "btnMoHinh";
            this.btnMoHinh.Size = new System.Drawing.Size(54, 23);
            this.btnMoHinh.TabIndex = 3;
            this.btnMoHinh.Text = "Sơ đồ";
            this.btnMoHinh.UseVisualStyleBackColor = true;
            this.btnMoHinh.Click += new System.EventHandler(this.btnMoHinh_Click);
            // 
            // btnBang
            // 
            this.btnBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.Location = new System.Drawing.Point(999, 40);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(54, 23);
            this.btnBang.TabIndex = 3;
            this.btnBang.Text = "Bảng";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(1119, 637);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnMoHinh);
            this.Controls.Add(this.panTime);
            this.Controls.Add(this.label1);
            this.Name = "frmTime";
            this.Text = "frmTime";
            this.Load += new System.EventHandler(this.frmTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaTime)).EndInit();
            this.panTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtaTime;
        private System.Windows.Forms.Panel panTime;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnMoHinh;
    }
}