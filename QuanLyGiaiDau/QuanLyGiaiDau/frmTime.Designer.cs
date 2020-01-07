namespace QuanLyGiaiDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTime));
            this.label1 = new System.Windows.Forms.Label();
            this.dtaTime = new System.Windows.Forms.DataGridView();
            this.panTime = new System.Windows.Forms.Panel();
            this.lblChon = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.numChon = new System.Windows.Forms.NumericUpDown();
            this.cboChon = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnBang = new System.Windows.Forms.Button();
            this.cboGiai = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTime)).BeginInit();
            this.panTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(649, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Thi Đấu";
            // 
            // dtaTime
            // 
            this.dtaTime.BackgroundColor = System.Drawing.Color.White;
            this.dtaTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaTime.EnableHeadersVisualStyles = false;
            this.dtaTime.Location = new System.Drawing.Point(3, 3);
            this.dtaTime.Name = "dtaTime";
            this.dtaTime.RowHeadersVisible = false;
            this.dtaTime.Size = new System.Drawing.Size(1295, 553);
            this.dtaTime.TabIndex = 1;
            this.dtaTime.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaTime_CellEndEdit);
            // 
            // panTime
            // 
            this.panTime.BackColor = System.Drawing.Color.ForestGreen;
            this.panTime.Controls.Add(this.lblChon);
            this.panTime.Controls.Add(this.btnChon);
            this.panTime.Controls.Add(this.numChon);
            this.panTime.Controls.Add(this.cboChon);
            this.panTime.Controls.Add(this.dtaTime);
            this.panTime.Location = new System.Drawing.Point(12, 66);
            this.panTime.Name = "panTime";
            this.panTime.Size = new System.Drawing.Size(1301, 590);
            this.panTime.TabIndex = 2;
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChon.ForeColor = System.Drawing.Color.Maroon;
            this.lblChon.Location = new System.Drawing.Point(500, 563);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(30, 17);
            this.lblChon.TabIndex = 5;
            this.lblChon.Text = "Mời";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(441, 560);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(53, 23);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // numChon
            // 
            this.numChon.Location = new System.Drawing.Point(383, 563);
            this.numChon.Name = "numChon";
            this.numChon.Size = new System.Drawing.Size(52, 20);
            this.numChon.TabIndex = 3;
            this.numChon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboChon
            // 
            this.cboChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChon.FormattingEnabled = true;
            this.cboChon.Location = new System.Drawing.Point(3, 562);
            this.cboChon.Name = "cboChon";
            this.cboChon.Size = new System.Drawing.Size(374, 21);
            this.cboChon.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnBang
            // 
            this.btnBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.Location = new System.Drawing.Point(1259, 42);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(54, 23);
            this.btnBang.TabIndex = 3;
            this.btnBang.Text = "Bảng";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // cboGiai
            // 
            this.cboGiai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiai.FormattingEnabled = true;
            this.cboGiai.Location = new System.Drawing.Point(12, 42);
            this.cboGiai.Name = "cboGiai";
            this.cboGiai.Size = new System.Drawing.Size(317, 21);
            this.cboGiai.TabIndex = 4;
            this.cboGiai.SelectedIndexChanged += new System.EventHandler(this.cboGiai_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoad.Location = new System.Drawing.Point(335, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(54, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.Maroon;
            this.btnRank.Location = new System.Drawing.Point(1205, 11);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(108, 31);
            this.btnRank.TabIndex = 7;
            this.btnRank.Text = "Xếp hạng";
            this.btnRank.UseVisualStyleBackColor = false;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(1329, 696);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboGiai);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.panTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTime";
            this.Text = "Lịch thi đấu";
            this.Load += new System.EventHandler(this.frmTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaTime)).EndInit();
            this.panTime.ResumeLayout(false);
            this.panTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChon)).EndInit();
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
        private System.Windows.Forms.ComboBox cboGiai;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.NumericUpDown numChon;
        private System.Windows.Forms.ComboBox cboChon;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.Button btnBack;
    }
}