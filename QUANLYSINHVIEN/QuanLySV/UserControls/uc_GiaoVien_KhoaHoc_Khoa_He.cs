using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_Xuly;
namespace QLSV_GiaoDien.UserControls
{
    public partial class uc_GiaoVien_KhoaHoc_Khoa_He : UserControl
    {
      
        QLSV_XGiaoVien qlsv_xlGiaoVien = new QLSV_XGiaoVien();
        QLSV_XKhoa qlsv_xlKhoa = new QLSV_XKhoa();
        c_XuLyChung cXLC = new c_XuLyChung();
        public uc_GiaoVien_KhoaHoc_Khoa_He()
        {
            InitializeComponent();
        }

        private void uc_GiaoVien_KhoaHoc_Khoa_He_Load(object sender, EventArgs e)
        {
           
            dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();

            dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();

            dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();

            
        }



      

        #region Quản lý Khóa Học
        QLSV_XKhoaHoc qlsv_xKhoaHoc = new QLSV_XKhoaHoc();
        c_XuLyChung XLC = new c_XuLyChung();
        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            txtMaKhoaHoc.Text = qlsv_xKhoaHoc.TaoMaKhoaHoc();
            qlsv_xKhoaHoc.MAKHOAHOC = txtMaKhoaHoc.Text;
            qlsv_xKhoaHoc.TENKHOAHOC = txtTenKhoaHoc.Text;
            qlsv_xKhoaHoc.NGAYBATDAU = dtpNgayBatDau.Value;
            qlsv_xKhoaHoc.NGAYKETTHUC = dtpNgayKetThuc.Value;
            qlsv_xKhoaHoc.GHICHU = txtGhichu_KhoaHoc.Text;
            qlsv_xKhoaHoc.ThemKhoaHoc();
           dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
           XLC.ClearAllTextBox(groupBox7);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



       

        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvKhoaHoc.SelectedRows.Count;
           
           
            
                for (int i = 0; i < n; i++)
                {
                    txtMaKhoaHoc.Text = dgvKhoaHoc.SelectedRows[i].Cells[2].Value.ToString();
                    txtTenKhoaHoc.Text = dgvKhoaHoc.SelectedRows[i].Cells[3].Value.ToString();
                    if (dgvKhoaHoc.SelectedRows[i].Cells[4].Value.ToString() != "")
                    {
                        dtpNgayBatDau.Value = (DateTime)dgvKhoaHoc.SelectedRows[i].Cells[4].Value;
                    }
                    if (dgvKhoaHoc.SelectedRows[i].Cells[5].Value.ToString() != "")
                    {
                        dtpNgayKetThuc.Value = (DateTime)dgvKhoaHoc.SelectedRows[i].Cells[5].Value;
                    }
                   
                    txtGhichu_KhoaHoc.Text = dgvKhoaHoc.SelectedRows[i].Cells[6].Value.ToString();

                }
                qlsv_xKhoaHoc.MAKHOAHOC = txtMaKhoaHoc.Text;
                qlsv_xKhoaHoc.TENKHOAHOC = txtTenKhoaHoc.Text;
                qlsv_xKhoaHoc.NGAYBATDAU = dtpNgayBatDau.Value;
                qlsv_xKhoaHoc.NGAYKETTHUC = dtpNgayKetThuc.Value;
                qlsv_xKhoaHoc.GHICHU = txtGhichu_KhoaHoc.Text;

                
            if (e.ColumnIndex == 0)
            {
              
                qlsv_xKhoaHoc.CapNhatKhoaHoc();
                dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
                XLC.ClearAllTextBox(groupBox7);
            }
            if (e.ColumnIndex == 1)
            {
               
                qlsv_xKhoaHoc.XoaKhoaHoc();
                dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
                XLC.ClearAllTextBox(groupBox7);
            }
        }

        private void btnNhapLaiKhoahoc_Click(object sender, EventArgs e)
        {
            XLC.ClearAllTextBox(groupBox7);
        }

        private void btnThoatKhoaHoc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region Quản lý giáo viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGiaoVien.Text = qlsv_xlGiaoVien.TaoMaGV();

            qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
            qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
            qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;
            qlsv_xlGiaoVien.MAKHOA = cmbMaKhoa.SelectedValue.ToString();

            qlsv_xlGiaoVien.ThemGiaoVien();
            dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
            XLC.ClearAllTextBox(groupboxGV_GV);

            qlsv_xlGiaoVien.TXT = txtThongTinTimKiem_GV;
            qlsv_xlGiaoVien.GoiYGiaoVien();
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            XLC.ClearAllTextBox(groupboxGV_GV);
        }

       
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbDieuKienTim.Text == "-- Chọn điều kiện --")
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm");
                return;
            }
            else
            {
                qlsv_xlGiaoVien.TENTIMKIEM = txtThongTinTimKiem_GV.Text;
                qlsv_xlGiaoVien.TimKiemGV();
                dgvGiaoVien.DataSource = qlsv_xlGiaoVien.TimKiemGV() ;
                int n = dgvGiaoVien.Rows.Count - 1;
                MessageBox.Show("Tìm thấy " + n + " kết quả! ");
            }
        }
        int col = 0;
        private void cmbDieuKienTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            qlsv_xlGiaoVien.TXT = txtThongTinTimKiem_GV;
            
           
            if (cmbDieuKienTim.SelectedItem.ToString() == "Mã Giáo Viên")
            {
                qlsv_xlGiaoVien.COTTIMKIEM = "MaGiaoVien";
                col = 0;
                qlsv_xlGiaoVien.COLUMN = col;
                qlsv_xlGiaoVien.GoiYGiaoVien();
            }
            if (cmbDieuKienTim.SelectedItem.ToString() == "Tên Giáo Viên") 
            {
                qlsv_xlGiaoVien.COTTIMKIEM = "TenGiaoVien";

                col = 1;
                qlsv_xlGiaoVien.COLUMN = col;
                qlsv_xlGiaoVien.GoiYGiaoVien();
            }
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            txtTenGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            if (dgvGiaoVien.CurrentRow.Cells[4].Value.ToString() != "")
            {
                cmbMaKhoa.SelectedValue = dgvGiaoVien.CurrentRow.Cells[4].Value;
                qlsv_xlGiaoVien.MAKHOA = cmbMaKhoa.SelectedValue.ToString();
               
            }
            txtGhiChu.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();

            qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
            qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
            qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;
           
           
            if (e.ColumnIndex == 0)
            {
                qlsv_xlGiaoVien.CapNhatGiaoVien();
                dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
                XLC.ClearAllTextBox(groupboxGV_GV);
            }
            if (e.ColumnIndex == 1)
            {
                qlsv_xlGiaoVien.XoaGiaoVien();
                dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
                XLC.ClearAllTextBox(groupboxGV_GV);
            }
        }

        #endregion

        #region Quản lý Khoa
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = qlsv_xlKhoa.TaoMaKhoa();

            qlsv_xlKhoa.MAKHOA = txtMaKhoa.Text;
            qlsv_xlKhoa.TENKHOA = txtTenKhoa.Text;
            qlsv_xlKhoa.GHICHU = txtGhiChu_Khoa.Text;

            qlsv_xlKhoa.ThemKhoa();
            dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
            XLC.ClearAllTextBox(groupboxKhoa);

            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();

        }

        private void btnNhaplaiKhoa_Click(object sender, EventArgs e)
        {
            XLC.ClearAllTextBox(groupboxKhoa);
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells[3].Value.ToString();
            txtGhiChu_Khoa.Text = dgvKhoa.CurrentRow.Cells[4].Value.ToString();

            qlsv_xlKhoa.MAKHOA = txtMaKhoa.Text;
            qlsv_xlKhoa.TENKHOA = txtTenKhoa.Text;
            qlsv_xlKhoa.GHICHU = txtGhiChu_Khoa.Text;

            if (e.ColumnIndex == 0)
            {
                qlsv_xlKhoa.CapNhatKhoa();
                dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
                XLC.ClearAllTextBox(groupboxKhoa);

                qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
                qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
               
            }

            if (e.ColumnIndex == 1)
            {
                qlsv_xlKhoa.XoaKhoa();
                dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
                XLC.ClearAllTextBox(groupboxKhoa);

                qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
                qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
               
            }
        }

        #endregion

        
    

      
    }
}
