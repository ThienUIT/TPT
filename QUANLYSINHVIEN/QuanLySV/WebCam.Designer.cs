namespace QLSV_GiaoDien
{
    partial class WebCam
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
            this.txtSave = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.ptxWebCam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "OutPut:";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(83, 370);
            this.txtSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(265, 22);
            this.txtSave.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(357, 368);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(357, 412);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 48);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.button_exit2;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(184, 414);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 46);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.BackgroundImage = global::QLSV_GiaoDien.Properties.Resources.take_a_photo;
            this.btnTakePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakePhoto.Enabled = false;
            this.btnTakePhoto.Location = new System.Drawing.Point(33, 415);
            this.btnTakePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(100, 45);
            this.btnTakePhoto.TabIndex = 4;
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // ptxWebCam
            // 
            this.ptxWebCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxWebCam.Location = new System.Drawing.Point(16, 26);
            this.ptxWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.ptxWebCam.Name = "ptxWebCam";
            this.ptxWebCam.Size = new System.Drawing.Size(440, 326);
            this.ptxWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxWebCam.TabIndex = 0;
            this.ptxWebCam.TabStop = false;
            // 
            // WebCam
            // 
            this.AcceptButton = this.btnTakePhoto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 473);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptxWebCam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WebCam";
            this.Text = "WebCam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebCam_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.ptxWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxWebCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}