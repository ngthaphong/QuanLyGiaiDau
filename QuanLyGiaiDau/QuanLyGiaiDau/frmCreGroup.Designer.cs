namespace QuanLyGiaiDau
{
    partial class frmCreGroup
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
            this.panGiaiDau = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTenGiai = new System.Windows.Forms.TextBox();
            this.radLoai = new System.Windows.Forms.RadioButton();
            this.radTron = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panGiaiDau.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGiaiDau
            // 
            this.panGiaiDau.Controls.Add(this.groupBox1);
            this.panGiaiDau.Controls.Add(this.label4);
            this.panGiaiDau.Controls.Add(this.dateEnd);
            this.panGiaiDau.Controls.Add(this.dateBegin);
            this.panGiaiDau.Controls.Add(this.label2);
            this.panGiaiDau.Controls.Add(this.label3);
            this.panGiaiDau.Controls.Add(this.label1);
            this.panGiaiDau.Controls.Add(this.btnThem);
            this.panGiaiDau.Controls.Add(this.btnExit);
            this.panGiaiDau.Controls.Add(this.btnCreate);
            this.panGiaiDau.Controls.Add(this.txtTenGiai);
            this.panGiaiDau.Location = new System.Drawing.Point(12, 12);
            this.panGiaiDau.Name = "panGiaiDau";
            this.panGiaiDau.Size = new System.Drawing.Size(299, 355);
            this.panGiaiDau.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tạo một giải đấu";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(3, 192);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 5;
            this.dateEnd.Value = new System.DateTime(2021, 12, 17, 2, 10, 0, 0);
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(3, 138);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(200, 20);
            this.dateBegin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên giải đấu:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(196, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm đại diện";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(162, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(63, 329);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtTenGiai
            // 
            this.txtTenGiai.Location = new System.Drawing.Point(3, 86);
            this.txtTenGiai.Name = "txtTenGiai";
            this.txtTenGiai.Size = new System.Drawing.Size(285, 20);
            this.txtTenGiai.TabIndex = 0;
            // 
            // radLoai
            // 
            this.radLoai.AutoSize = true;
            this.radLoai.Location = new System.Drawing.Point(6, 19);
            this.radLoai.Name = "radLoai";
            this.radLoai.Size = new System.Drawing.Size(86, 17);
            this.radLoai.TabIndex = 1;
            this.radLoai.TabStop = true;
            this.radLoai.Text = "Loại trực tiếp";
            this.radLoai.UseVisualStyleBackColor = true;
            this.radLoai.CheckedChanged += new System.EventHandler(this.radLoai_CheckedChanged);
            // 
            // radTron
            // 
            this.radTron.AutoSize = true;
            this.radTron.Location = new System.Drawing.Point(6, 42);
            this.radTron.Name = "radTron";
            this.radTron.Size = new System.Drawing.Size(93, 17);
            this.radTron.TabIndex = 2;
            this.radTron.TabStop = true;
            this.radTron.Text = "Đấu vòng tròn";
            this.radTron.UseVisualStyleBackColor = true;
            this.radTron.CheckedChanged += new System.EventHandler(this.radTron_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLoai);
            this.groupBox1.Controls.Add(this.radTron);
            this.groupBox1.Location = new System.Drawing.Point(7, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân loại";
            // 
            // frmCreGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(322, 379);
            this.Controls.Add(this.panGiaiDau);
            this.Name = "frmCreGroup";
            this.Text = "Tạo giải đấu";
            this.panGiaiDau.ResumeLayout(false);
            this.panGiaiDau.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGiaiDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTenGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLoai;
        private System.Windows.Forms.RadioButton radTron;
    }
}