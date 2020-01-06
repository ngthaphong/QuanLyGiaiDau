namespace QuanLyGiaiDau
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panWelcome = new System.Windows.Forms.Panel();
            this.btnKicker = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLeague = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblOption = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panWelcome
            // 
            this.panWelcome.BackColor = System.Drawing.Color.Transparent;
            this.panWelcome.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.panWelcome.Controls.Add(this.btnKicker);
            this.panWelcome.Controls.Add(this.lblWelcome);
            this.panWelcome.Controls.Add(this.btnLeague);
            this.panWelcome.Controls.Add(this.btnCreate);
            this.panWelcome.Controls.Add(this.lblOption);
            this.panWelcome.Controls.Add(this.btnHome);
            this.panWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panWelcome.Location = new System.Drawing.Point(12, 12);
            this.panWelcome.Name = "panWelcome";
            this.panWelcome.Size = new System.Drawing.Size(1095, 613);
            this.panWelcome.TabIndex = 5;
            // 
            // btnKicker
            // 
            this.btnKicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKicker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKicker.Image = global::QuanLyGiaiDau.Properties.Resources.player;
            this.btnKicker.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKicker.Location = new System.Drawing.Point(523, 451);
            this.btnKicker.Name = "btnKicker";
            this.btnKicker.Size = new System.Drawing.Size(132, 116);
            this.btnKicker.TabIndex = 5;
            this.btnKicker.Text = "Cầu thủ";
            this.btnKicker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKicker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKicker.UseVisualStyleBackColor = true;
            this.btnKicker.Click += new System.EventHandler(this.btnKicker_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Location = new System.Drawing.Point(277, 63);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(559, 46);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng bạn đến với Giải Đấu";
            // 
            // btnLeague
            // 
            this.btnLeague.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeague.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLeague.Image = global::QuanLyGiaiDau.Properties.Resources.giaidau;
            this.btnLeague.Location = new System.Drawing.Point(523, 251);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(132, 116);
            this.btnLeague.TabIndex = 2;
            this.btnLeague.Text = "Đội bóng";
            this.btnLeague.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeague.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLeague.UseVisualStyleBackColor = true;
            this.btnLeague.Click += new System.EventHandler(this.btnLeague_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Image = global::QuanLyGiaiDau.Properties.Resources.create;
            this.btnCreate.Location = new System.Drawing.Point(754, 363);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 116);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Giải đấu";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOption.Location = new System.Drawing.Point(391, 143);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(283, 29);
            this.lblOption.TabIndex = 4;
            this.lblOption.Text = "Hệ thống quản lý giải đấu";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = global::QuanLyGiaiDau.Properties.Resources.homepage;
            this.btnHome.Location = new System.Drawing.Point(300, 363);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(132, 116);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Lịch thi đấu";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseMnemonic = false;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 637);
            this.Controls.Add(this.panWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panWelcome.ResumeLayout(false);
            this.panWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Panel panWelcome;
        private System.Windows.Forms.Button btnKicker;
    }
}