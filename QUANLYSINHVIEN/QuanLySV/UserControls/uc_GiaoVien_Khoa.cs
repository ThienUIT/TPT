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
    public partial class uc_GiaoVien_Khoa : UserControl
    {
      
        QLSV_XGiaoVien qlsv_xlGiaoVien = new QLSV_XGiaoVien();
        QLSV_XKhoa qlsv_xlKhoa = new QLSV_XKhoa();
        c_XuLyChung cXLC = new c_XuLyChung();
        public uc_GiaoVien_Khoa()
        {
            InitializeComponent();
        }

        private void uc_GiaoVien_KhoaHoc_Khoa_He_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
            dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
            DisEnable_GiaoVien();
            DisEnable_khoa();
        }
        public void Enable_Giaovien()
        {
            txtMaGiaoVien.Enabled = true;
            txtTenGiaoVien.Enabled = true;
            cmbMaKhoa.Enabled = true;
            txtGhiChu.Enabled = true;
            btnLuuGV.Visible = true;
        }
        public void DisEnable_GiaoVien()
        {
            txtMaGiaoVien.Enabled = false;
            txtTenGiaoVien.Enabled = false;
            cmbMaKhoa.Enabled = false;
            txtGhiChu.Enabled = false;
            btnLuuGV.Visible = false;
        }
        public void Enable_khoa()
        {
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
            txtGhiChu_Khoa.Enabled = true;
            btnLuuKhoa.Enabled = true;
        }
        public void DisEnable_khoa()
        {
            txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;
            txtGhiChu_Khoa.Enabled = false;
            btnLuuKhoa.Enabled = false;
        }


        #region giáo viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable_Giaovien();
            cXLC.ClearAllTextBox(groupboxGV);  
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            cXLC.ClearAllTextBox(groupboxGV);
        }


        private void btnLuuGV_Click(object sender, EventArgs e)
        {
            txtMaGiaoVien.Text = qlsv_xlGiaoVien.TaoMaGV();

            qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
            qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
            qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;
            qlsv_xlGiaoVien.MAKHOA = cmbMaKhoa.SelectedValue.ToString();

            qlsv_xlGiaoVien.ThemGiaoVien();
            dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
            cXLC.ClearAllTextBox(groupboxGV);

            qlsv_xlGiaoVien.TXT = txtThongTinTimKiem_GV;
            qlsv_xlGiaoVien.GoiYGiaoVien();
            DisEnable_GiaoVien();
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
            else
            {
                cmbMaKhoa.SelectedValue = "";
            }



            txtGhiChu.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();

            qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
            qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
            qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;

           
            if (e.ColumnIndex == 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    qlsv_xlGiaoVien.CapNhatGiaoVien();
                    dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
                   
                }                 
            }
            if (e.ColumnIndex == 1)
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    qlsv_xlGiaoVien.XoaGiaoVien();
                    dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
                    cXLC.ClearAllTextBox(groupboxGV);
                }
            }
        }

        #endregion

        #region Khoa
      

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            Enable_khoa();
            cXLC.ClearAllTextBox(groupboxKhoa);
            txtTenKhoa.Focus();

        }

        private void btnNhaplaiKhoa_Click(object sender, EventArgs e)
        {
            cXLC.ClearAllTextBox(groupboxKhoa);
        }
        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = qlsv_xlKhoa.TaoMaKhoa();

            qlsv_xlKhoa.MAKHOA = txtMaKhoa.Text;
            qlsv_xlKhoa.TENKHOA = txtTenKhoa.Text;
            qlsv_xlKhoa.GHICHU = txtGhiChu_Khoa.Text;

            qlsv_xlKhoa.ThemKhoa();
            dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
            

            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
            DisEnable_khoa();
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
                DialogResult dlr = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    qlsv_xlKhoa.CapNhatKhoa();
                    dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
                    cXLC.ClearAllTextBox(groupboxKhoa);

                    qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
                    qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
                }
               
            }

            if (e.ColumnIndex == 1)
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    qlsv_xlKhoa.XoaKhoa();
                    dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
                    cXLC.ClearAllTextBox(groupboxKhoa);

                    qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
                    qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
                }

               
            }
        }
        #endregion

  
    }
}
