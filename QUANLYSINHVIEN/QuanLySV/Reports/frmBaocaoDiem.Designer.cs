namespace QLSV_GiaoDien.Reports
{
    partial class frmBaocaoDiem
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
            this.btnExel = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLanI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLanII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExel);
            this.groupBox1.Controls.Add(this.btnXemDiem);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu điểm";
            // 
            // btnExel
            // 
            this.btnExel.Location = new System.Drawing.Point(439, 22);
            this.btnExel.Name = "btnExel";
            this.btnExel.Size = new System.Drawing.Size(75, 23);
            this.btnExel.TabIndex = 3;
            this.btnExel.Text = "Exel";
            this.btnExel.UseVisualStyleBackColor = true;
            this.btnExel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(348, 22);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(75, 23);
            this.btnXemDiem.TabIndex = 2;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(153, 24);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(174, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã số Sinh Viên:";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToOrderColumns = true;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonHoc,
            this.SoTinChi,
            this.Hoten,
            this.DiemLanI,
            this.DiemLanII,
            this.LanThi,
            this.NgayThi,
            this.GhiChu});
            this.dgvDiem.Location = new System.Drawing.Point(12, 88);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.Size = new System.Drawing.Size(604, 328);
            this.dgvDiem.TabIndex = 5;
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
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.Name = "Hoten";
            this.Hoten.ReadOnly = true;
            // 
            // DiemLanI
            // 
            this.DiemLanI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemLanI.DataPropertyName = "DiemLanI";
            this.DiemLanI.FillWeight = 40F;
            this.DiemLanI.HeaderText = "Điểm Lần I";
            this.DiemLanI.Name = "DiemLanI";
            this.DiemLanI.ReadOnly = true;
            // 
            // DiemLanII
            // 
            this.DiemLanII.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemLanII.DataPropertyName = "DiemLanII";
            this.DiemLanII.FillWeight = 57.43292F;
            this.DiemLanII.HeaderText = "Điểm Lần II";
            this.DiemLanII.Name = "DiemLanII";
            this.DiemLanII.ReadOnly = true;
            // 
            // LanThi
            // 
            this.LanThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LanThi.DataPropertyName = "LanThi";
            this.LanThi.FillWeight = 57.43292F;
            this.LanThi.HeaderText = "Lần Thi";
            this.LanThi.Name = "LanThi";
            this.LanThi.ReadOnly = true;
            // 
            // NgayThi
            // 
            this.NgayThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayThi.DataPropertyName = "NgayThi";
            this.NgayThi.FillWeight = 57.43292F;
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // frmBaocaoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 593);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaocaoDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaocaoDiem";
            this.Load += new System.EventHandler(this.frmBaocaoDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLanI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLanII;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btnExel;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnXemDiem;
        public System.Windows.Forms.DataGridView dgvDiem;
    }
}