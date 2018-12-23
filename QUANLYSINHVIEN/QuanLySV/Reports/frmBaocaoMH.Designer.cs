namespace QLSV_GiaoDien.Reports
{
    partial class frmBaocaoMH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietLyThuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDongY);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(108, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xuất danh sách môn học";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(313, 24);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(65, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(155, 26);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xuất danh sách theo Khoa:";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToOrderColumns = true;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonHoc,
            this.SoTinChi,
            this.HinhThuc,
            this.TongSoTiet,
            this.SoTietLyThuyet,
            this.SoTietThucHanh,
            this.GhiChu});
            this.dgvMonHoc.Location = new System.Drawing.Point(13, 83);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.Size = new System.Drawing.Size(604, 328);
            this.dgvMonHoc.TabIndex = 4;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.FillWeight = 57.43292F;
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.ReadOnly = true;
            // 
            // SoTinChi
            // 
            this.SoTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.FillWeight = 57.43292F;
            this.SoTinChi.HeaderText = "Số Tín Chỉ";
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            // 
            // HinhThuc
            // 
            this.HinhThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HinhThuc.DataPropertyName = "HinhThuc";
            this.HinhThuc.FillWeight = 40F;
            this.HinhThuc.HeaderText = "Hình Thức";
            this.HinhThuc.Name = "HinhThuc";
            this.HinhThuc.ReadOnly = true;
            // 
            // TongSoTiet
            // 
            this.TongSoTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSoTiet.DataPropertyName = "TongSoTiet";
            this.TongSoTiet.FillWeight = 57.43292F;
            this.TongSoTiet.HeaderText = "Tổng Số Tiết";
            this.TongSoTiet.Name = "TongSoTiet";
            this.TongSoTiet.ReadOnly = true;
            // 
            // SoTietLyThuyet
            // 
            this.SoTietLyThuyet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTietLyThuyet.DataPropertyName = "SoTietLyThuyet";
            this.SoTietLyThuyet.FillWeight = 57.43292F;
            this.SoTietLyThuyet.HeaderText = "Số Tiết Lý Thuyết";
            this.SoTietLyThuyet.Name = "SoTietLyThuyet";
            this.SoTietLyThuyet.ReadOnly = true;
            // 
            // SoTietThucHanh
            // 
            this.SoTietThucHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTietThucHanh.DataPropertyName = "SoTietThucHanh";
            this.SoTietThucHanh.FillWeight = 57.43292F;
            this.SoTietThucHanh.HeaderText = "Số Tiết Thực Hành";
            this.SoTietThucHanh.Name = "SoTietThucHanh";
            this.SoTietThucHanh.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // frmBaocaoMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmBaocaoMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất danh sách môn học";
            this.Load += new System.EventHandler(this.frmBaocaoMH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTietLyThuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTietThucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvMonHoc;
        public System.Windows.Forms.Button btnDongY;
    }
}