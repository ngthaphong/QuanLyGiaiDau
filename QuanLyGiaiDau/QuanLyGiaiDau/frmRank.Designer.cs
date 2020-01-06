namespace QuanLyGiaiDau
{
    partial class frmRank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRank));
            this.dtaXepHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGiai = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaXepHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaXepHang
            // 
            this.dtaXepHang.BackgroundColor = System.Drawing.Color.White;
            this.dtaXepHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaXepHang.EnableHeadersVisualStyles = false;
            this.dtaXepHang.Location = new System.Drawing.Point(12, 66);
            this.dtaXepHang.Name = "dtaXepHang";
            this.dtaXepHang.RowHeadersVisible = false;
            this.dtaXepHang.Size = new System.Drawing.Size(980, 559);
            this.dtaXepHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng xếp hạng các đội";
            // 
            // cboGiai
            // 
            this.cboGiai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboGiai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cboGiai.FormattingEnabled = true;
            this.cboGiai.Location = new System.Drawing.Point(12, 42);
            this.cboGiai.Name = "cboGiai";
            this.cboGiai.Size = new System.Drawing.Size(249, 21);
            this.cboGiai.TabIndex = 2;
            this.cboGiai.SelectedIndexChanged += new System.EventHandler(this.cboGiai_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoad.Location = new System.Drawing.Point(267, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(45, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(1004, 637);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboGiai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaXepHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRank";
            this.Text = "Xếp hạng";
            this.Load += new System.EventHandler(this.frmRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaXepHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaXepHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGiai;
        private System.Windows.Forms.Button btnLoad;
    }
}