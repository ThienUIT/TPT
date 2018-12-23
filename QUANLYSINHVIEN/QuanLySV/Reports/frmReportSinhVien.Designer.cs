namespace QLSV_GiaoDien.Reports
{
    partial class frmReportSinhVien
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOISINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToOrderColumns = true;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOTEN,
            this.MSSV,
            this.QUEQUAN,
            this.NGAYSINH,
            this.NOISINH,
            this.GIOITINH});
            this.dgvSinhVien.Location = new System.Drawing.Point(20, 77);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.Size = new System.Drawing.Size(795, 328);
            this.dgvSinhVien.TabIndex = 3;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.FillWeight = 57.43292F;
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSSV.DataPropertyName = "MaSinhVien";
            this.MSSV.FillWeight = 57.43292F;
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUEQUAN.DataPropertyName = "QueQuan";
            this.QUEQUAN.FillWeight = 40F;
            this.QUEQUAN.HeaderText = "Quê Quán";
            this.QUEQUAN.Name = "QUEQUAN";
            this.QUEQUAN.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSINH.DataPropertyName = "NgaySinh";
            this.NGAYSINH.FillWeight = 57.43292F;
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // NOISINH
            // 
            this.NOISINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOISINH.DataPropertyName = "NoiSinh";
            this.NOISINH.FillWeight = 57.43292F;
            this.NOISINH.HeaderText = "Nơi Sinh";
            this.NOISINH.Name = "NOISINH";
            this.NOISINH.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.DataPropertyName = "GioiTinh";
            this.GIOITINH.FillWeight = 57.43292F;
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Controls.Add(this.cmbKhoaHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDongY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(108, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất Danh Sách Sinh Viên";
            // 
            // cmbLop
            // 
            this.cmbLop.Enabled = false;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(373, 25);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 7;
            // 
            // cmbKhoaHoc
            // 
            this.cmbKhoaHoc.FormattingEnabled = true;
            this.cmbKhoaHoc.Location = new System.Drawing.Point(129, 25);
            this.cmbKhoaHoc.Name = "cmbKhoaHoc";
            this.cmbKhoaHoc.Size = new System.Drawing.Size(142, 21);
            this.cmbKhoaHoc.TabIndex = 6;
            this.cmbKhoaHoc.SelectedValueChanged += new System.EventHandler(this.cmbKhoa_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn Khóa học:";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(524, 25);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(65, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Lớp:";
            // 
            // frmReportSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(835, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmReportSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.frmLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUEQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOISINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.ComboBox cmbKhoaHoc;
        private System.Windows.Forms.ComboBox cmbLop;
        public System.Windows.Forms.DataGridView dgvSinhVien;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnDongY;
        public System.Windows.Forms.Label label2;
    }
}