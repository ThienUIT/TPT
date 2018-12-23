namespace QLSV_GiaoDien.UserControls
{
    partial class uc_NhapDiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem_MSSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.txtDiemLanII = new System.Windows.Forms.TextBox();
            this.txtDiemLanI = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.ListBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.backgroup;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTimKiem_MSSV);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnTim);
            this.groupBox4.Location = new System.Drawing.Point(256, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 53);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tra cứu điểm Sinh viên";
            // 
            // txtTimKiem_MSSV
            // 
            this.txtTimKiem_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem_MSSV.Location = new System.Drawing.Point(113, 23);
            this.txtTimKiem_MSSV.Name = "txtTimKiem_MSSV";
            this.txtTimKiem_MSSV.Size = new System.Drawing.Size(188, 19);
            this.txtTimKiem_MSSV.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhập mã Sinh Viên:";
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.Magnify;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.ForeColor = System.Drawing.Color.Transparent;
            this.btnTim.Location = new System.Drawing.Point(333, 10);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 34);
            this.btnTim.TabIndex = 2;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.dgvDiem);
            this.groupBox3.Controls.Add(this.dtpNgayThi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Controls.Add(this.txtLanThi);
            this.groupBox3.Controls.Add(this.txtDiemLanII);
            this.groupBox3.Controls.Add(this.txtDiemLanI);
            this.groupBox3.Controls.Add(this.txtMaSV);
            this.groupBox3.Controls.Add(this.txtMaMH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(256, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 445);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập điểm";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(292, 391);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 17;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.button_delete;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(168, 391);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.button_add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(53, 391);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 15;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(6, 217);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.Size = new System.Drawing.Size(413, 141);
            this.dgvDiem.TabIndex = 14;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThi.Location = new System.Drawing.Point(259, 110);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(109, 19);
            this.dtpNgayThi.TabIndex = 13;
            this.dtpNgayThi.Value = new System.DateTime(2010, 1, 22, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(24, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(183, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày thi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(24, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lần thi:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(100, 138);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(293, 62);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLanThi.Location = new System.Drawing.Point(100, 112);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(67, 19);
            this.txtLanThi.TabIndex = 8;
            this.txtLanThi.Text = "0";
            this.txtLanThi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLanThi_KeyPress);
            // 
            // txtDiemLanII
            // 
            this.txtDiemLanII.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemLanII.Location = new System.Drawing.Point(258, 85);
            this.txtDiemLanII.Name = "txtDiemLanII";
            this.txtDiemLanII.Size = new System.Drawing.Size(67, 19);
            this.txtDiemLanII.TabIndex = 7;
            this.txtDiemLanII.Text = "0";
            this.txtDiemLanII.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemLanII_KeyPress);
            // 
            // txtDiemLanI
            // 
            this.txtDiemLanI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemLanI.Location = new System.Drawing.Point(100, 86);
            this.txtDiemLanI.Name = "txtDiemLanI";
            this.txtDiemLanI.Size = new System.Drawing.Size(67, 19);
            this.txtDiemLanI.TabIndex = 6;
            this.txtDiemLanI.Text = "0";
            this.txtDiemLanI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemLanI_KeyPress);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSV.Location = new System.Drawing.Point(100, 59);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(144, 19);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMH.Location = new System.Drawing.Point(99, 33);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(144, 19);
            this.txtMaMH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(183, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm lần II:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(24, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm lần I:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbMonHoc);
            this.groupBox2.Controls.Add(this.cmbKhoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 489);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập điểm cho môn học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Chọn môn học";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMonHoc.FormattingEnabled = true;
            this.lbMonHoc.Location = new System.Drawing.Point(6, 75);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(210, 405);
            this.lbMonHoc.TabIndex = 2;
            this.lbMonHoc.SelectedValueChanged += new System.EventHandler(this.lbMonHoc_SelectedValueChanged);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(81, 16);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(135, 21);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn khoa:";
            // 
            // uc_NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "uc_NhapDiem";
            this.Size = new System.Drawing.Size(690, 520);
            this.Load += new System.EventHandler(this.uc_NhapDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.TextBox txtDiemLanII;
        private System.Windows.Forms.TextBox txtDiemLanI;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem_MSSV;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvDiem;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListBox lbMonHoc;
        public System.Windows.Forms.Label label10;
    }
}
