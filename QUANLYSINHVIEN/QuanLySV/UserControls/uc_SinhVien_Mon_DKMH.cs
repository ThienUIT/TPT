using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_Xuly;
using QLSV_Database;
using QLSV_GiaoDien.UserControls;
namespace QLSV_GiaoDien.UserControls
{
    public partial class uc_SinhVien_Mon_DKMH : UserControl
    {
        string flag = "";// dùng để thêm hoặc sửa
        int index;

        QLSV_XSinhVien qlsv_xlSV = new QLSV_XSinhVien();
        QLSV_XMonHoc qlsv_slMonHoc = new QLSV_XMonHoc();
        QLSV_XDKMonHoc qlsv_xlDKMonHoc = new QLSV_XDKMonHoc();
        QLSV_XLop qlsv_xlop = new QLSV_XLop();

        c_XuLyChung xlc = new c_XuLyChung();
        c_ThaoTacChung ctc = new c_ThaoTacChung();
        #region hide and show txt
        public void DisEnable_SV()
        {
            btnLuu_SV.Visible = false;
            txtHotenSv.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtQueQuan.Enabled = false;
            txtGhichu.Enabled = false;
            cbMaLop.Enabled = false;
            btnBrowseHinh.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
            
         
        }
        public void Enable_SV()
        {
            btnLuu_SV.Visible = true;
            txtHotenSv.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtGhichu.Enabled = true;
            cbMaLop.Enabled = true;
            btnBrowseHinh.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
            btnCancel_SV.Visible = true;
 
        }
        public void DisEnable_MH()
        {
            txtTenMh.Enabled = false;
            cmbMaKhoa_MH.Enabled = false;
            rdMonbatbuoc.Enabled = false;
            rdMontuchon.Enabled = false;
            numSoTinChi.Enabled = false;
            txtGhichu_MH.Enabled = false;
            numSoTietLT.Enabled = false;
            numSoTietTH.Enabled = false;
            numTongsotiet.Enabled = false;
            btnLuu_MH.Visible = false;
          
        }
        public void Enable_MH()
        {
            txtTenMh.Enabled = true;
            cmbMaKhoa_MH.Enabled = true;
            rdMonbatbuoc.Enabled = true;
            rdMontuchon.Enabled = true;
            numSoTinChi.Enabled = true;
            txtGhichu_MH.Enabled = true;
            numSoTietLT.Enabled = true;
            numSoTietTH.Enabled = true;
            numTongsotiet.Enabled = true;
            btnLuu_MH.Visible = true;
            btnCancel_MH.Visible = true;
        }
        public void DisEnable_DKMH()
        {
            btnLuu_DKMH.Visible = false;
            txtMSV_DKMH.Enabled = false;
            dtp_NgayDKMH.Enabled = false;
            txtHocky.Enabled = false;
            numSoTCDK.Enabled = false;
            cmbMonHocDK.Enabled = false;
           
        }
        public void Enable_DKMH()
        {
            btnLuu_DKMH.Visible = true;
            txtMSV_DKMH.Enabled = true;
            dtp_NgayDKMH.Enabled = true;
            txtHocky.Enabled = true;
            numSoTCDK.Enabled = true;
            cmbMonHocDK.Enabled = true;
            btnCancel_DKMH.Visible = true;
        }

        #endregion
        public uc_SinhVien_Mon_DKMH()
        {
            InitializeComponent();
        }
        #region uc_Load
 
        private void uc_SinhVien_Lop_MonHoc_Load(object sender, EventArgs e)
        {
          

            #region SinhVien
            dgv_SV.DataSource = qlsv_xlSV.LoadDL();
            qlsv_xlSV.CMB = cbMaLop;
            qlsv_xlSV.LayDLVaoComboboxMaLop();
            DisEnable_SV();
            #endregion

            #region Monhoc
            qlsv_slMonHoc.CMB = cmbMaKhoa_MH;
            qlsv_slMonHoc.LoadDLVaoCombobox_cmbMaKhoa_MH();
            dgvMonhoc.DataSource = qlsv_slMonHoc.LoadDLMonHoc();
            DisEnable_MH();
            #endregion 

            #region DK môn học
            qlsv_xlDKMonHoc.CMB = cmbMonHocDK;
           qlsv_xlDKMonHoc.LoadDLVao_cmbMaMonHoc_DK();
            dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.LoadDL_DKMonHoc();

            qlsv_xlDKMonHoc.TXTTIM = txtTim_MSSV;
           qlsv_xlDKMonHoc.GoiYTimKiem();
            qlsv_xlDKMonHoc.TXTMSV = txtMSV_DKMH;
            qlsv_xlDKMonHoc.GoiYMSSV();

            DisEnable_DKMH();
            #endregion
        }
        #endregion

        
        #region ThemSinhVien
        private void btnDongy_Click(object sender, EventArgs e)
        {
            Enable_SV();
            btnTakePhoto.Enabled = true;
            xlc.ClearAllTextBox(groupBox1);
            qlsv_xlSV.CMB = cbMaLop;
            btnLamlai.Visible = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (rdNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
                gioitinh = "Nữ";
            txtMSSV.Text = qlsv_xlSV.TaoMaSinhVien();
            qlsv_xlSV.MASV = txtMSSV.Text;
            qlsv_xlSV.HOTEN = txtHotenSv.Text;
            qlsv_xlSV.QUEQUAN = txtQueQuan.Text;
            qlsv_xlSV.NGAYSINH = dtp_NgaySinh.Value;
            qlsv_xlSV.NOISINH = txtNoiSinh.Text;
            qlsv_xlSV.MALOP = cbMaLop.SelectedValue.ToString();
            qlsv_xlSV.HINH = txtHinh.Text;
            qlsv_xlSV.GIOITINH = gioitinh;
            qlsv_xlSV.GHICHU = txtGhichu.Text;

            qlsv_xlSV.ThemSinhVien();
            dgv_SV.DataSource = qlsv_xlSV.LoadDL();

            DisEnable_SV();
            btnThem_SV.Visible = true;
            btnLamlai.Visible = true;

        }
        private void btnCancel_SV_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(groupBox1);
            DisEnable_SV();
            btnThem_SV.Visible = true;
            
        }
        private void tabSinhVien_Click(object sender, EventArgs e)
        {
            groupBox1.Focus();
        }

        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            frmQuanLySV frmQLSV = new frmQuanLySV();
            frmQLSV.ShowDialog();

        }


        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.Text = dgv_SV.CurrentRow.Cells[0].Value.ToString();
            txtHotenSv.Text = dgv_SV.CurrentRow.Cells[1].Value.ToString();
            txtQueQuan.Text = dgv_SV.CurrentRow.Cells[2].Value.ToString();
            cbMaLop.SelectedValue = dgv_SV.CurrentRow.Cells[6].Value.ToString();
            if((dgv_SV.CurrentRow.Cells[3].Value.ToString()==""))
                { dtp_NgaySinh.Value = DateTime.Now; }
            else
                dtp_NgaySinh.Value = (DateTime)dgv_SV.CurrentRow.Cells[3].Value;
            txtNoiSinh.Text = dgv_SV.CurrentRow.Cells[4].Value.ToString();
            txtHinh.Text = dgv_SV.CurrentRow.Cells[7].Value.ToString();

            txtGhichu.Text = dgv_SV.CurrentRow.Cells[8].Value.ToString();
            pcHinhSV.ImageLocation = txtHinh.Text;
            pcHinhSV.SizeMode = PictureBoxSizeMode.StretchImage;

            if (dgv_SV.CurrentRow.Cells[5].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else if (dgv_SV.CurrentRow.Cells[5].Value.ToString() == "Nữ")
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = false;
            }
        }


        private void btnBrowseHinh_Click(object sender, EventArgs e)
        {
            oFD_Pic.ShowDialog();
        }

        private void oFD_Pic_FileOk(object sender, CancelEventArgs e)
        {
            txtHinh.Text = oFD_Pic.FileName.ToString();
            pcHinhSV.ImageLocation = txtHinh.Text;
            pcHinhSV.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion

        #region Quản lý môn học
        private void btnLuu_MH_Click(object sender, EventArgs e)
        {

            txtMaMH.Text = qlsv_slMonHoc.TaoMaMonHoc();
            qlsv_slMonHoc.MAMONHOC = txtMaMH.Text;
            qlsv_slMonHoc.TENMONHOC = txtTenMh.Text;
            qlsv_slMonHoc.MAKHOA = cmbMaKhoa_MH.SelectedValue.ToString();
            qlsv_slMonHoc.TONGSOTIET = (int)numTongsotiet.Value;
            qlsv_slMonHoc.SOTIETLYTHUYET = (int)numSoTietLT.Value;
            qlsv_slMonHoc.SOTIETTHUCHANH = (int)numSoTietTH.Value;
            qlsv_slMonHoc.SOTINCHI = (int)numSoTinChi.Value;
            qlsv_slMonHoc.GHICHU = txtGhichu_MH.Text;
            string hinhthuc = "";
            if (rdMonbatbuoc.Checked == true)
            {
                hinhthuc = "Bắt buộc";
            }
            else if (rdMontuchon.Checked == true)
            {
                hinhthuc = "Tự chọn";
            }
            qlsv_slMonHoc.HINHTHUC = hinhthuc;

            qlsv_slMonHoc.ThemMonHoc();
            dgvMonhoc.DataSource = qlsv_slMonHoc.LoadDLMonHoc();
            xlc.ClearAllTextBox(groupBox3);

            DisEnable_MH();
            btnThem_MH.Visible = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable_MH();
            xlc.ClearAllTextBox(groupBox3);
            btnThem_MH.Visible = false;
        }

        private void btnCancel_MH_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(groupBox3);
            DisEnable_MH();
        }
        private void dgvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvMonhoc.CurrentRow.Cells[0].Value.ToString();
            txtTenMh.Text = dgvMonhoc.CurrentRow.Cells[1].Value.ToString();
            cmbMaKhoa_MH.SelectedValue = dgvMonhoc.CurrentRow.Cells[2].Value.ToString();
            if (dgvMonhoc.CurrentRow.Cells[3].Value.ToString() == "")
            {
                numSoTinChi.Value = 0;
                numTongsotiet.Value = 0;
                numSoTietLT.Value = 0;
                numSoTietTH.Value = 0;
            }
            else
            {
                numSoTinChi.Value = (int)dgvMonhoc.CurrentRow.Cells[3].Value;
                numTongsotiet.Value = (int)dgvMonhoc.CurrentRow.Cells[5].Value;
                numSoTietLT.Value = (int)dgvMonhoc.CurrentRow.Cells[6].Value;
                numSoTietTH.Value = (int)dgvMonhoc.CurrentRow.Cells[7].Value;
            }
            if(dgvMonhoc.CurrentRow.Cells[4].Value.ToString()=="Bắt buộc")
            {
                rdMonbatbuoc.Checked = true;
            }
            else if(dgvMonhoc.CurrentRow.Cells[4].Value.ToString() == "Tự chọn")
            {
                rdMontuchon.Checked = true;
            }
            else
            {
                rdMontuchon.Checked = false;
                rdMonbatbuoc.Checked = false;
            }

        }
        #endregion

        #region Dăng ký môn học
        private void btnThem_DKMH_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            //button
            btnThem_DKMH.Visible = false;
            btnLamlai_DKMH.Enabled = false;
            btnCancel_DKMH.Enabled = false;
            dgvDangkyMH.Enabled = false;
            txtMSV_DKMH.Focus();
            xlc.ClearAllTextBox(groupBoxDKMH);
            Enable_DKMH();
        }
        private void btnLuu_DKMH_Click(object sender, EventArgs e)
        {      
            if (flag == "thêm")
            {
                qlsv_xlDKMonHoc.MAMONHOC = cmbMonHocDK.SelectedValue.ToString();
                qlsv_xlDKMonHoc.MASINHVIEN = txtMSV_DKMH.Text;
                qlsv_xlDKMonHoc.NGAYDANGKY = dtp_NgayDKMH.Value;
                qlsv_xlDKMonHoc.SOTINCHI = (int)numSoTCDK.Value;
                if (txtHocky.Text == "")
                {
                    MessageBox.Show("Chưa nhập học kỳ! ");
                    return;
                }
                else
                    qlsv_xlDKMonHoc.HOCKY = int.Parse(txtHocky.Text);


                qlsv_xlDKMonHoc.ThemDKMonHoc();
               // dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.TimKiemSVDK();
                dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.LoadDL_DKMonHoc();
                xlc.ClearAllTextBox(groupboxSVDKMH);

                qlsv_xlDKMonHoc.TXTTIM = txtTim_MSSV;
                qlsv_xlDKMonHoc.GoiYTimKiem();
                lblTenSV.Text = qlsv_xlDKMonHoc.LayTenSV();

                groupboxSVDKMH.Visible = true;

                DisEnable_DKMH();

                btnThem_DKMH.Visible = true;
                btnLamlai_DKMH.Enabled = true;
                btnCancel_DKMH.Enabled = true;
                dgvDangkyMH.Enabled = true;

                int i;
                for (i = 0; i < dgvDangkyMH.RowCount - 1; i++)
                {
                    if (dgvDangkyMH.Rows[i].Cells[1].Value.ToString() == txtMSV_DKMH.Text)
                        break;
                }
                dgvDangkyMH.CurrentCell = dgvDangkyMH[0, i];

            }
            else if (flag == "sửa")
            {

                qlsv_xlDKMonHoc.MAMONHOC = cmbMonHocDK.SelectedValue.ToString();
                qlsv_xlDKMonHoc.MASINHVIEN = txtMSV_DKMH.Text;
                qlsv_xlDKMonHoc.NGAYDANGKY = dtp_NgayDKMH.Value;
                qlsv_xlDKMonHoc.SOTINCHI = (int)numSoTCDK.Value;
                qlsv_xlDKMonHoc.HOCKY = int.Parse(txtHocky.Text);

                qlsv_xlDKMonHoc.CapNhatDKMonHoc();
                dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.TimKiemSVDK();
                xlc.ClearAllTextBox(groupboxSVDKMH);
                DisEnable_DKMH();

                btnThem_DKMH.Visible = true;
                btnLamlai_DKMH.Enabled = true;
                btnCancel_DKMH.Enabled = true;
                dgvDangkyMH.Enabled = true;
                //focus
                dgvDangkyMH.CurrentCell = dgvDangkyMH[0, index];


            }
        }

        private void btnCancel_DKMH_Click(object sender, EventArgs e)
        {
            qlsv_xlDKMonHoc.XoaDKMonHoc();
            dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.LoadDL_DKMonHoc();
            xlc.ClearAllTextBox(groupBoxDKMH);
            DisEnable_DKMH();


        }
        private void btnLamlai_DKMH_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            //button
            btnThem_DKMH.Visible = false;
            btnCancel_DKMH.Enabled = false;
            dgvDangkyMH.Enabled = false;
            txtMSV_DKMH.Focus();


            Enable_DKMH();
        }

        private void btnTimDKMH_Click(object sender, EventArgs e)
        {
            qlsv_xlDKMonHoc.MASINHVIEN = txtTim_MSSV.Text;
            dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.TimKiemSVDK();
            lblTenSV.Text = qlsv_xlDKMonHoc.LayTenSV();
            groupboxSVDKMH.Visible = true;


        }

        private void txtHocky_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
       
        private void dgvDangkyMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        

            cmbMonHocDK.SelectedValue = dgvDangkyMH.CurrentRow.Cells[0].Value.ToString();
            txtMSV_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[1].Value.ToString();
            dtp_NgayDKMH.Value = (DateTime)dgvDangkyMH.CurrentRow.Cells[2].Value;
            txtHocky.Text = dgvDangkyMH.CurrentRow.Cells[3].Value.ToString();
            numSoTCDK.Value = (int)dgvDangkyMH.CurrentRow.Cells[4].Value;


        }

        #endregion

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            frmQuanLiMonHoc frmQLMH = new frmQuanLiMonHoc();
            frmQLMH.ShowDialog();
        }

      


        #region chuẩn hoá
        private void txtHotenSv_TextChanged(object sender, EventArgs e)
        {
            txtHotenSv.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtHotenSv.Text);
            txtHotenSv.Select(txtHotenSv.Text.Length, 0);

        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {
            txtNoiSinh.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtNoiSinh.Text);
            txtNoiSinh.Select(txtNoiSinh.Text.Length, 0);
        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {
            txtQueQuan.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtQueQuan.Text);
            txtQueQuan.Select(txtQueQuan.Text.Length, 0);
        }



















        #endregion

        private void TakePhoto_Click(object sender, EventArgs e)
        {
            WebCam wb = new WebCam();
            wb.Show();
        }

        
    }
}
