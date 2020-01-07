namespace QuanLyGiaiDau
{
    partial class frmKicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKicker));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtaNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSoAo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.cboDoi = new System.Windows.Forms.ComboBox();
            this.grpAddCauThu = new System.Windows.Forms.GroupBox();
            this.dtaCauThu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtaTK = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboXoa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpAddCauThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaCauThu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(86, 244);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(167, 244);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(64, 65);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(212, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // dtaNgaySinh
            // 
            this.dtaNgaySinh.Location = new System.Drawing.Point(64, 105);
            this.dtaNgaySinh.Name = "dtaNgaySinh";
            this.dtaNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtaNgaySinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số áo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đội:";
            // 
            // cboSoAo
            // 
            this.cboSoAo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoAo.FormattingEnabled = true;
            this.cboSoAo.Location = new System.Drawing.Point(64, 150);
            this.cboSoAo.Name = "cboSoAo";
            this.cboSoAo.Size = new System.Drawing.Size(126, 21);
            this.cboSoAo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vị trí:";
            // 
            // cboViTri
            // 
            this.cboViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(64, 196);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(132, 21);
            this.cboViTri.TabIndex = 4;
            // 
            // cboDoi
            // 
            this.cboDoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoi.FormattingEnabled = true;
            this.cboDoi.Location = new System.Drawing.Point(64, 19);
            this.cboDoi.Name = "cboDoi";
            this.cboDoi.Size = new System.Drawing.Size(225, 21);
            this.cboDoi.TabIndex = 6;
            // 
            // grpAddCauThu
            // 
            this.grpAddCauThu.Controls.Add(this.cboDoi);
            this.grpAddCauThu.Controls.Add(this.label5);
            this.grpAddCauThu.Controls.Add(this.btnThoat);
            this.grpAddCauThu.Controls.Add(this.cboSoAo);
            this.grpAddCauThu.Controls.Add(this.btnThem);
            this.grpAddCauThu.Controls.Add(this.label3);
            this.grpAddCauThu.Controls.Add(this.label1);
            this.grpAddCauThu.Controls.Add(this.label2);
            this.grpAddCauThu.Controls.Add(this.cboViTri);
            this.grpAddCauThu.Controls.Add(this.dtaNgaySinh);
            this.grpAddCauThu.Controls.Add(this.txtHoTen);
            this.grpAddCauThu.Controls.Add(this.label4);
            this.grpAddCauThu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpAddCauThu.Location = new System.Drawing.Point(833, 414);
            this.grpAddCauThu.Name = "grpAddCauThu";
            this.grpAddCauThu.Size = new System.Drawing.Size(305, 273);
            this.grpAddCauThu.TabIndex = 7;
            this.grpAddCauThu.TabStop = false;
            this.grpAddCauThu.Text = "Thêm cầu thủ:";
            // 
            // dtaCauThu
            // 
            this.dtaCauThu.BackgroundColor = System.Drawing.Color.White;
            this.dtaCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaCauThu.EnableHeadersVisualStyles = false;
            this.dtaCauThu.Location = new System.Drawing.Point(3, 29);
            this.dtaCauThu.Name = "dtaCauThu";
            this.dtaCauThu.RowHeadersVisible = false;
            this.dtaCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaCauThu.Size = new System.Drawing.Size(824, 658);
            this.dtaCauThu.TabIndex = 8;
            this.dtaCauThu.SelectionChanged += new System.EventHandler(this.dtaCauThu_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Danh sách các cầu thủ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtaTK);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtaCauThu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.grpAddCauThu);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 690);
            this.panel1.TabIndex = 10;
            // 
            // dtaTK
            // 
            this.dtaTK.BackgroundColor = System.Drawing.Color.White;
            this.dtaTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaTK.EnableHeadersVisualStyles = false;
            this.dtaTK.Location = new System.Drawing.Point(833, 104);
            this.dtaTK.Name = "dtaTK";
            this.dtaTK.ReadOnly = true;
            this.dtaTK.RowHeadersVisible = false;
            this.dtaTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaTK.Size = new System.Drawing.Size(305, 222);
            this.dtaTK.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboXoa);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(833, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 76);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xóa cầu thủ";
            // 
            // cboXoa
            // 
            this.cboXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboXoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoa.FormattingEnabled = true;
            this.cboXoa.Location = new System.Drawing.Point(7, 19);
            this.cboXoa.Name = "cboXoa";
            this.cboXoa.Size = new System.Drawing.Size(292, 21);
            this.cboXoa.TabIndex = 11;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(115, 46);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(826, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quản lý cầu thủ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(830, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thống kê cầu thủ:";
            // 
            // frmKicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDau.Properties.Resources.sanbong;
            this.ClientSize = new System.Drawing.Size(1168, 714);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKicker";
            this.Text = "Cầu thủ";
            this.Load += new System.EventHandler(this.frmKicker_Load);
            this.grpAddCauThu.ResumeLayout(false);
            this.grpAddCauThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaCauThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboDoi;
        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSoAo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtaNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAddCauThu;
        private System.Windows.Forms.DataGridView dtaCauThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboXoa;
        private System.Windows.Forms.DataGridView dtaTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}