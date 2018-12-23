namespace QLSV_GiaoDien
{
    partial class frmQuanLiMonHoc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSoTinChi = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvMonhoc = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdMonbatbuoc = new System.Windows.Forms.RadioButton();
            this.rdMontuchon = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.numSoTietLT = new System.Windows.Forms.NumericUpDown();
            this.numSoTietTH = new System.Windows.Forms.NumericUpDown();
            this.numTongsotiet = new System.Windows.Forms.NumericUpDown();
            this.cmbMaKhoa_MH = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGhichu_MH = new System.Windows.Forms.TextBox();
            this.txtTenMh = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongsotiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnback);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.numSoTinChi);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.dgvMonhoc);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numSoTietLT);
            this.groupBox3.Controls.Add(this.numSoTietTH);
            this.groupBox3.Controls.Add(this.numTongsotiet);
            this.groupBox3.Controls.Add(this.cmbMaKhoa_MH);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtGhichu_MH);
            this.groupBox3.Controls.Add(this.txtTenMh);
            this.groupBox3.Controls.Add(this.txtMaMH);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 510);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập Môn Học";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.button_tick;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(548, 404);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(609, 6);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 20);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTimMH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 69);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Môn Học";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Transparent;
            this.btnTim.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.Magnify;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Location = new System.Drawing.Point(591, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 36);
            this.btnTim.TabIndex = 4;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimMH
            // 
            this.txtTimMH.Location = new System.Drawing.Point(393, 34);
            this.txtTimMH.Name = "txtTimMH";
            this.txtTimMH.Size = new System.Drawing.Size(181, 20);
            this.txtTimMH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập từ khóa:";
            // 
            // cmbTimMH
            // 
            this.cmbTimMH.FormattingEnabled = true;
            this.cmbTimMH.Items.AddRange(new object[] {
            "Mã môn học",
            "Tên môn học"});
            this.cmbTimMH.Location = new System.Drawing.Point(157, 34);
            this.cmbTimMH.Name = "cmbTimMH";
            this.cmbTimMH.Size = new System.Drawing.Size(135, 21);
            this.cmbTimMH.TabIndex = 1;
            this.cmbTimMH.Text = "-- Chọn điều kiện --";
            this.cmbTimMH.SelectedIndexChanged += new System.EventHandler(this.cmbTimMH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Theo:";
            // 
            // numSoTinChi
            // 
            this.numSoTinChi.Location = new System.Drawing.Point(419, 309);
            this.numSoTinChi.Name = "numSoTinChi";
            this.numSoTinChi.Size = new System.Drawing.Size(48, 20);
            this.numSoTinChi.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.button_delete;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(548, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.edit;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Location = new System.Drawing.Point(548, 404);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 33);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvMonhoc
            // 
            this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhoc.Location = new System.Drawing.Point(18, 94);
            this.dgvMonhoc.Name = "dgvMonhoc";
            this.dgvMonhoc.ReadOnly = true;
            this.dgvMonhoc.Size = new System.Drawing.Size(683, 160);
            this.dgvMonhoc.TabIndex = 25;
            this.dgvMonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonhoc_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdMonbatbuoc);
            this.groupBox5.Controls.Add(this.rdMontuchon);
            this.groupBox5.Location = new System.Drawing.Point(104, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 36);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // rdMonbatbuoc
            // 
            this.rdMonbatbuoc.AutoSize = true;
            this.rdMonbatbuoc.Checked = true;
            this.rdMonbatbuoc.Location = new System.Drawing.Point(13, 13);
            this.rdMonbatbuoc.Name = "rdMonbatbuoc";
            this.rdMonbatbuoc.Size = new System.Drawing.Size(91, 17);
            this.rdMonbatbuoc.TabIndex = 18;
            this.rdMonbatbuoc.TabStop = true;
            this.rdMonbatbuoc.Text = "Môn bắt buộc";
            this.rdMonbatbuoc.UseVisualStyleBackColor = true;
            // 
            // rdMontuchon
            // 
            this.rdMontuchon.AutoSize = true;
            this.rdMontuchon.Location = new System.Drawing.Point(121, 13);
            this.rdMontuchon.Name = "rdMontuchon";
            this.rdMontuchon.Size = new System.Drawing.Size(85, 17);
            this.rdMontuchon.TabIndex = 19;
            this.rdMontuchon.TabStop = true;
            this.rdMontuchon.Text = "Môn tự chọn";
            this.rdMontuchon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hình thức:";
            // 
            // numSoTietLT
            // 
            this.numSoTietLT.Location = new System.Drawing.Point(276, 385);
            this.numSoTietLT.Name = "numSoTietLT";
            this.numSoTietLT.Size = new System.Drawing.Size(42, 20);
            this.numSoTietLT.TabIndex = 22;
            // 
            // numSoTietTH
            // 
            this.numSoTietTH.Location = new System.Drawing.Point(453, 385);
            this.numSoTietTH.Name = "numSoTietTH";
            this.numSoTietTH.Size = new System.Drawing.Size(43, 20);
            this.numSoTietTH.TabIndex = 21;
            // 
            // numTongsotiet
            // 
            this.numTongsotiet.Location = new System.Drawing.Point(104, 385);
            this.numTongsotiet.Name = "numTongsotiet";
            this.numTongsotiet.Size = new System.Drawing.Size(53, 20);
            this.numTongsotiet.TabIndex = 20;
            // 
            // cmbMaKhoa_MH
            // 
            this.cmbMaKhoa_MH.FormattingEnabled = true;
            this.cmbMaKhoa_MH.Location = new System.Drawing.Point(419, 272);
            this.cmbMaKhoa_MH.Name = "cmbMaKhoa_MH";
            this.cmbMaKhoa_MH.Size = new System.Drawing.Size(173, 21);
            this.cmbMaKhoa_MH.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ghi chú";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Số tiết thực hành:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Thuộc Khoa:";
            // 
            // txtGhichu_MH
            // 
            this.txtGhichu_MH.Location = new System.Drawing.Point(104, 423);
            this.txtGhichu_MH.Multiline = true;
            this.txtGhichu_MH.Name = "txtGhichu_MH";
            this.txtGhichu_MH.Size = new System.Drawing.Size(392, 69);
            this.txtGhichu_MH.TabIndex = 10;
            // 
            // txtTenMh
            // 
            this.txtTenMh.Location = new System.Drawing.Point(104, 309);
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.Size = new System.Drawing.Size(225, 20);
            this.txtTenMh.TabIndex = 9;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(104, 272);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(225, 20);
            this.txtMaMH.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tên môn học:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(344, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Số tín chỉ:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tổng số tiết:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(179, 387);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Số tiết lý thuyết:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mã môn học:";
            // 
            // frmQuanLiMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.backgroup;
            this.ClientSize = new System.Drawing.Size(717, 513);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Name = "frmQuanLiMonHoc";
            this.Text = "frmQuanLiMonHoc";
            this.Load += new System.EventHandler(this.frmQuanLiMonHoc_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTietTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongsotiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numSoTinChi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvMonhoc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdMonbatbuoc;
        private System.Windows.Forms.RadioButton rdMontuchon;
        private System.Windows.Forms.NumericUpDown numSoTietLT;
        private System.Windows.Forms.NumericUpDown numSoTietTH;
        private System.Windows.Forms.NumericUpDown numTongsotiet;
        private System.Windows.Forms.ComboBox cmbMaKhoa_MH;
        private System.Windows.Forms.TextBox txtGhichu_MH;
        private System.Windows.Forms.TextBox txtTenMh;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMH;
        private System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbTimMH;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnback;
    }
}