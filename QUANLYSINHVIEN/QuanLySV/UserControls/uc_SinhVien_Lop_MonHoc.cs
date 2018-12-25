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
    public partial class uc_SinhVien_Lop_MonHoc : UserControl
    {
        QLSV_XSinhVien qlsv_xlSV = new QLSV_XSinhVien();
        QLSV_XLop qlsv_xlLop = new QLSV_XLop();
        QLSV_XMonHoc qlsv_slMonHoc = new QLSV_XMonHoc();
        QLSV_XDKMonHoc qlsv_xlDKMonHoc = new QLSV_XDKMonHoc();
        c_XuLyChung xlc = new c_XuLyChung();
        c_ThaoTacChung ctc = new c_ThaoTacChung();
        public uc_SinhVien_Lop_MonHoc()
        {
            InitializeComponent();
        }
        #region uc_Load
        private void uc_SinhVien_Lop_MonHoc_Load(object sender, EventArgs e)
        {
            #region SinhVien
            dataGridView1.DataSource = qlsv_xlSV.LoadDL();
            qlsv_xlSV.CMB = cbMaLop;
            qlsv_xlSV.LayDLVaoComboboxMaLop();

            dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
            qlsv_xlNganh.CMB = cmbTenHe;
            qlsv_xlNganh.LoadDLVaoCombobox();
#endregion

            #region Lop
            qlsv_xlLop.cmbMAKHOAHOC = cmbMaKhoaHoc;
            qlsv_xlLop.LoadDLVaoCombobox_MaKhoaHoc();

            qlsv_xlLop.cmbMANGANH = cmbMaNganh;
            qlsv_xlLop.LoadDLVaoCombobox_MaNganh();

            dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();

            #endregion

            #region Monhoc
            qlsv_slMonHoc.CMB = cmbMaKhoa_MH;
            qlsv_slMonHoc.LoadDLVaoCombobox_cmbMaKhoa_MH();
            dgvMonhoc.DataSource = qlsv_slMonHoc.LoadDLMonHoc();
            #endregion 

            #region DK môn học
            qlsv_xlDKMonHoc.CMB = cmbMonHocDK;
           qlsv_xlDKMonHoc.LoadDLVao_cmbMaMonHoc_DK();
            dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.LoadDL_DKMonHoc();

            qlsv_xlDKMonHoc.TXTTIM = txtTim_MSSV;
           qlsv_xlDKMonHoc.GoiYTimKiem();
            qlsv_xlDKMonHoc.TXTMSV = txtMSV_DKMH;
            qlsv_xlDKMonHoc.GoiYMSSV();
            #endregion
        }
        #endregion

        
        #region ThemSinhVien
        private void btnDongy_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if(rdNam.Checked == true)
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
          dataGridView1.DataSource =  qlsv_xlSV.LoadDL();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
            
           

        }

        private void tabSinhVien_Click(object sender, EventArgs e)
        {
            groupThongTinSinhVien.Focus();
        }

        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            frmQuanLySV frmQLSV = new frmQuanLySV();
            frmQLSV.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(groupThongTinSinhVien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region quản lý ngành
        QLSV_XNganh qlsv_xlNganh = new QLSV_XNganh();

        private void tabNganh_Click(object sender, EventArgs e)
        {

        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNganh.Text = dgvNganh.CurrentRow.Cells[2].Value.ToString();
            if (dgvNganh.CurrentRow.Cells[3].Value.ToString() != "")
            {
                cmbTenHe.SelectedValue = dgvNganh.CurrentRow.Cells[3].Value;
                qlsv_xlNganh.MAHE = cmbTenHe.SelectedValue.ToString();
            }
          
            
            txtTenNganh.Text = dgvNganh.CurrentRow.Cells[4].Value.ToString();
            txtGhiChu_Nganh.Text = dgvNganh.CurrentRow.Cells[5].Value.ToString();

            qlsv_xlNganh.MANGANH = txtMaNganh.Text;
            
            qlsv_xlNganh.TENNGANH = txtTenNganh.Text;
            qlsv_xlNganh.GHICHU = txtGhiChu_Nganh.Text;

            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show("column " + e.ColumnIndex);
                qlsv_xlNganh.CapNhatNganh();
                dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
                xlc.ClearAllTextBox(grpThemNganhHoc);
            }
            if (e.ColumnIndex == 1)
            {
                //MessageBox.Show("column " + e.ColumnIndex);
                qlsv_xlNganh.XoaNganh();
                dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
                xlc.ClearAllTextBox(grpThemNganhHoc);
            }
           
        }

        private void btnThem_Nganh_Click(object sender, EventArgs e)
        {
            txtMaNganh.Text = qlsv_xlNganh.TaoMaNganh();

            qlsv_xlNganh.MANGANH = txtMaNganh.Text;
            qlsv_xlNganh.MAHE = cmbTenHe.SelectedValue.ToString();
            qlsv_xlNganh.TENNGANH = txtTenNganh.Text;
            qlsv_xlNganh.GHICHU = txtGhiChu_Nganh.Text;

            qlsv_xlNganh.ThemNganh();
            dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
            xlc.ClearAllTextBox(grpThemNganhHoc);
        }

       

        private void cmbTenHe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label31.Text = cmbTenHe.SelectedValue.ToString();
        }

        private void btnThoat_Nganh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLamlai_Nganh_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(grpThemNganhHoc);
        }
        #endregion

       
#region Quản lý lớp
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = qlsv_xlLop.TaoMaLop();
            qlsv_xlLop.MALOP = txtMaLop.Text;
            qlsv_xlLop.MAKHOAHOC = cmbMaKhoaHoc.SelectedValue.ToString();
            qlsv_xlLop.MANGANH = cmbMaNganh.SelectedValue.ToString();
            qlsv_xlLop.TENLOP = txtTenLop.Text;
            qlsv_xlLop.GHICHU = txtGhichu_Lop.Text;
            qlsv_xlLop.ThemLop();
            dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
            xlc.ClearAllTextBox(grpSV_AddLop);
        }

        private void btnLamlai_Lop_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(grpSV_AddLop);
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString();
            cmbMaKhoaHoc.SelectedValue = dgvLop.CurrentRow.Cells[3].Value;
            cmbMaNganh.SelectedValue = dgvLop.CurrentRow.Cells[4].Value;
            txtTenLop.Text = dgvLop.CurrentRow.Cells[5].Value.ToString();
            txtGhichu_Lop.Text = dgvLop.CurrentRow.Cells[6].Value.ToString();
            qlsv_xlLop.MALOP = txtMaLop.Text;
            if ((dgvLop.CurrentRow.Cells[3].Value.ToString() != "") && (dgvLop.CurrentRow.Cells[4].Value.ToString()!=""))
            {
                qlsv_xlLop.MAKHOAHOC = cmbMaKhoaHoc.SelectedValue.ToString();
                qlsv_xlLop.MANGANH = cmbMaNganh.SelectedValue.ToString();
            }
           
            
            qlsv_xlLop.TENLOP = txtTenLop.Text;
            qlsv_xlLop.GHICHU = txtGhichu_Lop.Text;

            if (e.ColumnIndex == 0)
            {
                qlsv_xlLop.CapNhatLop();
                dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
                xlc.ClearAllTextBox(grpSV_AddLop);
            }
            if (e.ColumnIndex == 1)
            {
                qlsv_xlLop.XoaLop();
                dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
                xlc.ClearAllTextBox(grpSV_AddLop);
            }
        }

        private void cmbTimLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cotgoiy = 0;
            if (cmbTimLop.SelectedItem.ToString() == "Tên Lớp")
            {
                cotgoiy = 3;
                qlsv_xlLop.COTGOIY = cotgoiy;
                qlsv_xlLop.COTIMKIEM = "TenLop";

                qlsv_xlLop.TXTGOIY = txtTimLop;
                qlsv_xlLop.GoiYTimKiem();
            }
            else if (cmbTimLop.SelectedItem.ToString() == "Mã Khóa Học")
            {
                cotgoiy = 1;
                qlsv_xlLop.COTGOIY = cotgoiy;
                qlsv_xlLop.COTIMKIEM = "MaKhoaHoc";

                qlsv_xlLop.TXTGOIY = txtTimLop;
                qlsv_xlLop.GoiYTimKiem();
            }
            else if (cmbTimLop.SelectedItem.ToString() == "Mã Ngành")
            {
                cotgoiy = 2;
                qlsv_xlLop.COTGOIY = cotgoiy;
                qlsv_xlLop.COTIMKIEM = "MaNganh";

                qlsv_xlLop.TXTGOIY = txtTimLop;
                qlsv_xlLop.GoiYTimKiem();
            }
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            if (cmbTimLop.Text == "-- Chọn điều kiện --")
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm ! ");
                return;
            }
            qlsv_xlLop.DKTIM = txtTimLop.Text;
            dgvLop.DataSource = qlsv_xlLop.TimKiemLop();
            int n = qlsv_xlLop.TimKiemLop().Rows.Count;
            MessageBox.Show("Tìm thấy " + n + " kết quả");
        }
#endregion


        #region Quản lý môn học
        private void btnThem_Click(object sender, EventArgs e)
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
            xlc.ClearAllTextBox(grpSinhVien_MonHoc);
        }
        private void btnLamlai_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(grpSinhVien_MonHoc);
        }

        #endregion


        #region Dăng ký môn học
        private void btnThem_DKMH_Click(object sender, EventArgs e)
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
            dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.TimKiemSVDK();
            //dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.LoadDL_DKMonHoc();
            xlc.ClearAllTextBox(groupboxSVDKMH);
            qlsv_xlDKMonHoc.TXTTIM = txtTim_MSSV;
            qlsv_xlDKMonHoc.GoiYTimKiem();
            lblTenSV.Text = qlsv_xlDKMonHoc.LayTenSV();
            groupboxSVDKMH.Visible = true;
        }

        private void btnLamlai_DKMH_Click(object sender, EventArgs e)
        {
            xlc.ClearAllTextBox(groupBoxDKMH);
        }

        private void btnTimDKMH_Click(object sender, EventArgs e)
        {
            qlsv_xlDKMonHoc.MASINHVIEN = txtTim_MSSV.Text;
            dgvDangkyMH.DataSource= qlsv_xlDKMonHoc.TimKiemSVDK();
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
            if (dgvDangkyMH.CurrentRow.Cells[2].Value.ToString() != "" && dgvDangkyMH.CurrentRow.Cells[4].Value.ToString() !="")
            {
                cmbMonHocDK.SelectedValue = dgvDangkyMH.CurrentRow.Cells[2].Value;
                txtMSV_DKMH.Text = dgvDangkyMH.CurrentRow.Cells[3].Value.ToString();
                dtp_NgayDKMH.Value = (DateTime)dgvDangkyMH.CurrentRow.Cells[4].Value;
                numSoTCDK.Value = (int)dgvDangkyMH.CurrentRow.Cells[5].Value;
                txtHocky.Text = dgvDangkyMH.CurrentRow.Cells[6].Value.ToString();

                qlsv_xlDKMonHoc.MAMONHOC = cmbMonHocDK.SelectedValue.ToString();
                qlsv_xlDKMonHoc.MASINHVIEN = txtMSV_DKMH.Text;
                qlsv_xlDKMonHoc.NGAYDANGKY = dtp_NgayDKMH.Value;
                qlsv_xlDKMonHoc.SOTINCHI = (int)numSoTCDK.Value;
                qlsv_xlDKMonHoc.HOCKY = int.Parse(txtHocky.Text);

                if (e.ColumnIndex == 0)
                {
                    qlsv_xlDKMonHoc.CapNhatDKMonHoc();
                   dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.TimKiemSVDK();
                    xlc.ClearAllTextBox(groupboxSVDKMH);
                }
                else if (e.ColumnIndex == 1)
                {
                    qlsv_xlDKMonHoc.XoaDKMonHoc();
                   dgvDangkyMH.DataSource = qlsv_xlDKMonHoc.TimKiemSVDK();
                    xlc.ClearAllTextBox(groupboxSVDKMH);
                }
            }


        }

        #endregion

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            frmQuanLiMonHoc frmQLMH = new frmQuanLiMonHoc();
            frmQLMH.ShowDialog();
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

        private void btnThoat_DKMH_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void lblSV_NgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblSV_Hinh_Click(object sender, EventArgs e)
        {

        }
    }
}
