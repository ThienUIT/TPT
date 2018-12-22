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
        string flag = "";
        int index;
        QLSV_XGiaoVien qlsv_xlGiaoVien = new QLSV_XGiaoVien();
        QLSV_XKhoa qlsv_xlKhoa = new QLSV_XKhoa();
        c_XuLyChung cXLC = new c_XuLyChung();
        public uc_GiaoVien_Khoa()
        {
            InitializeComponent();
        }
        #region hide and show 
        public void Enable_Giaovien()
        {
           
            txtTenGiaoVien.Enabled = true;
            cmbMaKhoa.Enabled = true;
            txtGhiChu.Enabled = true;
            btnLuuGV.Visible = true;
            
        }
        public void DisEnable_GiaoVien()
        {
           
            txtTenGiaoVien.Enabled = false;
            cmbMaKhoa.Enabled = false;
            txtGhiChu.Enabled = false;
            btnLuuGV.Visible = false;
            
        }
        public void Enable_khoa()
        {
          
            txtTenKhoa.Enabled = true;
            txtGhiChu_Khoa.Enabled = true;
            btnLuuKhoa.Enabled = true;
        }
        public void DisEnable_khoa()
        {

            txtTenKhoa.Enabled = false;
            txtGhiChu_Khoa.Enabled = false;
            btnLuuKhoa.Enabled = false;
        }
        #endregion
        private void uc_GiaoVien_KhoaHoc_Khoa_He_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
            dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
            //khoá thao tác txt
            DisEnable_GiaoVien();
            DisEnable_khoa();
          
        }
      


        #region giáo viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            Enable_Giaovien();
            txtTenGiaoVien.Focus();
            cXLC.ClearAllTextBox(groupboxGV);

            btnLamlai.Enabled = false;
            btnXoa_GV.Enabled = false;
            dgvGiaoVien.Enabled = false;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            Enable_Giaovien();
            txtTenGiaoVien.Focus();

            btnLamlai.Enabled = false;
            btnXoa_GV.Enabled = false;
            dgvGiaoVien.Enabled = false;
        }

        private void btnXoa_GV_Click(object sender, EventArgs e)
        {
            qlsv_xlGiaoVien.XoaGiaoVien();
            dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
            cXLC.ClearAllTextBox(groupboxGV);

            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
        }

        private void btnLuuGV_Click(object sender, EventArgs e)
        {
            if ( flag == "thêm")
            {
                txtMaGiaoVien.Text = qlsv_xlGiaoVien.TaoMaGV();

                qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
                qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
                qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;
                if (cmbMaKhoa.Text.ToString() == "")
                {
                    MessageBox.Show("Bạn chưa chọn Khoa");
                    DisEnable_GiaoVien();
                    dgvGiaoVien.Enabled = true;
                    btnLamlai.Enabled = true;
                    btnXoa_GV.Enabled = true;
                    return;
                }
                else
                {
                    qlsv_xlGiaoVien.MAKHOA = cmbMaKhoa.SelectedValue.ToString();
                }
                qlsv_xlGiaoVien.ThemGiaoVien();
                dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
                cXLC.ClearAllTextBox(groupboxGV);

                qlsv_xlGiaoVien.TXT = txtThongTinTimKiem_GV;
                qlsv_xlGiaoVien.GoiYGiaoVien();


                int i;
                for (i = 0; i < dgvGiaoVien.RowCount - 1; i++)
                {
                    if (dgvGiaoVien.Rows[i].Cells[1].Value.ToString() == dgvGiaoVien.Text)
                        break;
                }
                dgvGiaoVien.CurrentCell = dgvGiaoVien[0, i];


                DisEnable_GiaoVien();
                dgvGiaoVien.Enabled = true;
                btnLamlai.Enabled = true;
                btnXoa_GV.Enabled = true;
            }
            else if(flag=="sửa")
            {
               
                qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
                qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
                qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;
                qlsv_xlGiaoVien.MAKHOA = cmbMaKhoa.SelectedValue.ToString();

                qlsv_xlGiaoVien.CapNhatGiaoVien();
                dgvGiaoVien.DataSource = qlsv_xlGiaoVien.LoadDLGiaoVien();
                cXLC.ClearAllTextBox(groupboxGV);

                qlsv_xlGiaoVien.TXT = txtThongTinTimKiem_GV;
                qlsv_xlGiaoVien.GoiYGiaoVien();

                dgvGiaoVien.CurrentCell = dgvGiaoVien[0, index];

                DisEnable_GiaoVien();
                dgvGiaoVien.Enabled = true;
                btnLamlai.Enabled = true;
                btnXoa_GV.Enabled = true;
            }
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
            index = e.RowIndex;

            txtMaGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            txtTenGiaoVien.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            if (dgvGiaoVien.CurrentRow.Cells[2].Value.ToString() != "")
            {
                cmbMaKhoa.SelectedValue = dgvGiaoVien.CurrentRow.Cells[2].Value;
                qlsv_xlGiaoVien.MAKHOA = cmbMaKhoa.SelectedValue.ToString();
            }
            else
            {
                cmbMaKhoa.SelectedValue = "";
            }

            txtGhiChu.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            qlsv_xlGiaoVien.MAGIAOVIEN = txtMaGiaoVien.Text;
            qlsv_xlGiaoVien.TENGIAOVIEN = txtTenGiaoVien.Text;
            qlsv_xlGiaoVien.GHICHU = txtGhiChu.Text;

           
           

        }

        #endregion

        #region Khoa
      

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            Enable_khoa();
            cXLC.ClearAllTextBox(groupboxKhoa);
            txtTenKhoa.Focus();
            btnNhaplaiKhoa.Enabled = false;
            btndelete_K.Enabled = false;

        }

        private void btnNhaplaiKhoa_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            Enable_khoa(); 
            txtTenKhoa.Focus();
            btnNhaplaiKhoa.Enabled = false;
            btndelete_K.Enabled = false;
        }
        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {
                txtMaKhoa.Text = qlsv_xlKhoa.TaoMaKhoa();

                qlsv_xlKhoa.MAKHOA = txtMaKhoa.Text;
                qlsv_xlKhoa.TENKHOA = txtTenKhoa.Text;
                qlsv_xlKhoa.GHICHU = txtGhiChu_Khoa.Text;

                qlsv_xlKhoa.ThemKhoa();
                dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();


                qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
                qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();

                int i;
                for (i = 0; i < dgvKhoa.RowCount - 1; i++)
                {
                    if (dgvKhoa.Rows[i].Cells[1].Value.ToString() == dgvKhoa.Text)
                        break;
                }
                dgvKhoa.CurrentCell = dgvKhoa[0, i];


                DisEnable_khoa();
                btnNhaplaiKhoa.Enabled = true;
                btndelete_K.Enabled = true;
            }
            else if(flag=="sửa")
            {
                qlsv_xlKhoa.MAKHOA = txtMaKhoa.Text;
                qlsv_xlKhoa.TENKHOA = txtTenKhoa.Text;
                qlsv_xlKhoa.GHICHU = txtGhiChu_Khoa.Text;

                qlsv_xlKhoa.CapNhatKhoa();
                dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
                cXLC.ClearAllTextBox(groupboxKhoa);

                qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
                qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();

                dgvKhoa.CurrentCell = dgvKhoa[0, index];

                DisEnable_khoa();
                btnNhaplaiKhoa.Enabled = true;
                btndelete_K.Enabled = true;
            }
        }
        private void btndelete_K_Click(object sender, EventArgs e)
        {
            qlsv_xlKhoa.XoaKhoa();
            dgvKhoa.DataSource = qlsv_xlKhoa.LoadDLKhoa();
            cXLC.ClearAllTextBox(groupboxKhoa);

            qlsv_xlGiaoVien.cmbMAKHOA = cmbMaKhoa;
            qlsv_xlGiaoVien.LoadDLVao_cmbMaKhoa();
   
            
        }
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu_Khoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString();

            qlsv_xlKhoa.MAKHOA = txtMaKhoa.Text;
            qlsv_xlKhoa.TENKHOA = txtTenKhoa.Text;
            qlsv_xlKhoa.GHICHU = txtGhiChu_Khoa.Text;
 
        }

        #endregion
        #region chuẩn hoá
        private void txtTenGiaoVien_TextChanged(object sender, EventArgs e)
        {
            txtTenGiaoVien.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtTenGiaoVien.Text);
            txtTenGiaoVien.Select(txtTenGiaoVien.Text.Length, 0);
        }

        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {
            txtTenKhoa.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtTenKhoa.Text);
            txtTenKhoa.Select(txtTenKhoa.Text.Length, 0);
        }
        #endregion


    }
}
