namespace QuanLyGiaiDau
{
    partial class frmGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroup));
            this.dtaGiai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolGiaiDau = new System.Windows.Forms.ToolStrip();
            this.toolHome = new System.Windows.Forms.ToolStripButton();
            this.toolSpace = new System.Windows.Forms.ToolStripLabel();
            this.toolCreaGroup = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFinGroup = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCreTeam = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAcc = new System.Windows.Forms.ToolStripLabel();
            this.toolAccounted = new System.Windows.Forms.ToolStripLabel();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiai)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolGiaiDau.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtaGiai
            // 
            this.dtaGiai.BackgroundColor = System.Drawing.Color.White;
            this.dtaGiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGiai.EnableHeadersVisualStyles = false;
            this.dtaGiai.GridColor = System.Drawing.Color.Maroon;
            this.dtaGiai.Location = new System.Drawing.Point(12, 153);
            this.dtaGiai.Name = "dtaGiai";
            this.dtaGiai.RowHeadersVisible = false;
            this.dtaGiai.Size = new System.Drawing.Size(1095, 472);
            this.dtaGiai.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.greenball;
            this.panel1.Controls.Add(this.toolGiaiDau);
            this.panel1.Controls.Add(this.cboTrangThai);
            this.panel1.Controls.Add(this.cboHinhThuc);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 135);
            this.panel1.TabIndex = 1;
            // 
            // toolGiaiDau
            // 
            this.toolGiaiDau.AutoSize = false;
            this.toolGiaiDau.BackColor = System.Drawing.Color.BurlyWood;
            this.toolGiaiDau.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHome,
            this.toolSpace,
            this.toolFinGroup,
            this.toolStripSeparator1,
            this.toolCreaGroup,
            this.toolStripSeparator2,
            this.toolCreTeam,
            this.toolStripSeparator4,
            this.toolAcc,
            this.toolAccounted});
            this.toolGiaiDau.Location = new System.Drawing.Point(0, 0);
            this.toolGiaiDau.Name = "toolGiaiDau";
            this.toolGiaiDau.Size = new System.Drawing.Size(1095, 40);
            this.toolGiaiDau.TabIndex = 3;
            this.toolGiaiDau.Text = "toolStrip1";
            // 
            // toolHome
            // 
            this.toolHome.AutoSize = false;
            this.toolHome.BackColor = System.Drawing.Color.BurlyWood;
            this.toolHome.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.homepage;
            this.toolHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHome.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(40, 40);
            this.toolHome.Text = "Quay lại";
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // toolSpace
            // 
            this.toolSpace.Name = "toolSpace";
            this.toolSpace.Size = new System.Drawing.Size(547, 37);
            this.toolSpace.Text = "                                                                                 " +
    "                                                                                " +
    "                   ";
            // 
            // toolCreaGroup
            // 
            this.toolCreaGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolCreaGroup.ForeColor = System.Drawing.Color.Maroon;
            this.toolCreaGroup.IsLink = true;
            this.toolCreaGroup.LinkColor = System.Drawing.Color.Maroon;
            this.toolCreaGroup.Name = "toolCreaGroup";
            this.toolCreaGroup.Size = new System.Drawing.Size(73, 37);
            this.toolCreaGroup.Text = "Tạo giải đấu";
            this.toolCreaGroup.Click += new System.EventHandler(this.toolCreaGroup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Lime;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolFinGroup
            // 
            this.toolFinGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolFinGroup.ForeColor = System.Drawing.Color.Maroon;
            this.toolFinGroup.IsLink = true;
            this.toolFinGroup.LinkColor = System.Drawing.Color.Maroon;
            this.toolFinGroup.Name = "toolFinGroup";
            this.toolFinGroup.Size = new System.Drawing.Size(74, 37);
            this.toolFinGroup.Text = "Tìm giải đấu";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolCreTeam
            // 
            this.toolCreTeam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolCreTeam.ForeColor = System.Drawing.Color.Maroon;
            this.toolCreTeam.IsLink = true;
            this.toolCreTeam.LinkColor = System.Drawing.Color.Maroon;
            this.toolCreTeam.Name = "toolCreTeam";
            this.toolCreTeam.Size = new System.Drawing.Size(48, 37);
            this.toolCreTeam.Text = "Tạo đội";
            this.toolCreTeam.Click += new System.EventHandler(this.toolCreTeam_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // toolAcc
            // 
            this.toolAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolAcc.ForeColor = System.Drawing.Color.Maroon;
            this.toolAcc.LinkColor = System.Drawing.Color.Maroon;
            this.toolAcc.Name = "toolAcc";
            this.toolAcc.Size = new System.Drawing.Size(62, 37);
            this.toolAcc.Text = "Tài khoản:";
            // 
            // toolAccounted
            // 
            this.toolAccounted.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAccounted.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolAccounted.Name = "toolAccounted";
            this.toolAccounted.Size = new System.Drawing.Size(0, 37);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đăng ký",
            "Hoạt động",
            "Kết thúc"});
            this.cboTrangThai.Location = new System.Drawing.Point(979, 109);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(113, 21);
            this.cboTrangThai.TabIndex = 1;
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThuc.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Loại Trực Tiếp",
            "Vòng Tròn"});
            this.cboHinhThuc.Location = new System.Drawing.Point(848, 109);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(125, 21);
            this.cboHinhThuc.TabIndex = 1;
            this.cboHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cboHinhThuc_SelectedIndexChanged);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFind.Location = new System.Drawing.Point(3, 111);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(204, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "Nhập để tìm kiếm";
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(1119, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtaGiai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGroup";
            this.Text = "Thống kê giải đấu";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGiai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolGiaiDau.ResumeLayout(false);
            this.toolGiaiDau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGiai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ToolStrip toolGiaiDau;
        private System.Windows.Forms.ToolStripButton toolHome;
        private System.Windows.Forms.ToolStripLabel toolSpace;
        private System.Windows.Forms.ToolStripLabel toolCreaGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolFinGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolCreTeam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolAcc;
        private System.Windows.Forms.ToolStripLabel toolAccounted;
    }
}