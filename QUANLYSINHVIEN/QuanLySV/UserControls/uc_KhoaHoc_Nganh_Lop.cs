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
    public partial class uc_KhoaHoc_Nganh_Lop : UserControl
    {
        public uc_KhoaHoc_Nganh_Lop()
        {
            InitializeComponent();
        }

        string flag = "";// dùng để thêm hoặc sửa
        int index;

        QLSV_XNganh qlsv_xlNganh = new QLSV_XNganh();
        QLSV_XLop qlsv_xlLop = new QLSV_XLop();
        QLSV_XKhoaHoc qlsv_xKhoaHoc = new QLSV_XKhoaHoc();
       
        c_XuLyChung xlc = new c_XuLyChung();
        c_ThaoTacChung ctc = new c_ThaoTacChung();
        #region hide and show txt
        public void Enable_KhoaHoc()
        {
            
            txtTenKhoaHoc.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            txtGhichu_KhoaHoc.Enabled = true;
            btnLuuKhoa.Visible = true;
        }
        public void DisEnable_KhoaHoc()
        {
            txtMaKhoaHoc.Enabled = false;
            txtTenKhoaHoc.Enabled = false;
            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
            txtGhichu_KhoaHoc.Enabled = false;
            btnLuuKhoa.Visible = false;
        }


        public void DisEnable_LOP()
        {
            btnLuu_Lop.Visible = false;
            txtMaLop.Enabled = false;
            txtTenLop.Enabled = false;
            txtGhichu_Lop.Enabled = false;
            cmbMaNganh.Enabled = false;
            cmbMaKhoaHoc.Enabled = false;

        }
        public void Enable_LOP()
        {
            btnLuu_Lop.Visible = true;
            txtTenLop.Enabled = true;
            txtGhichu_Lop.Enabled = true;
            cmbMaNganh.Enabled = true;
            cmbMaKhoaHoc.Enabled = true;
            btnCancel_LOP.Visible = true;
        }
        public void Enable_NGANH()
        {
            btnLuu_NGANH.Visible = true;
            txtTenNganh.Enabled = true;

            txtGhiChu_Nganh.Enabled = true;
            btnCancel_NGANH.Visible = true;
        }
        public void DisEnable_NGANH()
        {
            btnLuu_NGANH.Visible = false;
            txtTenNganh.Enabled = false;
            txtMaNganh.Enabled = false;
            txtGhiChu_Nganh.Enabled = false;
        }
        #endregion
        //load Uc_
        private void uc_KhoaHoc_Nganh_Lop_Load_1(object sender, EventArgs e)
        {
            #region Lop
            qlsv_xlLop.cmbMAKHOAHOC = cmbMaKhoaHoc;
            qlsv_xlLop.LoadDLVaoCombobox_MaKhoaHoc();

            qlsv_xlLop.cmbMANGANH = cmbMaNganh;
            qlsv_xlLop.LoadDLVaoCombobox_MaNganh();

            dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();

            #endregion

            dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
            dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
            //ko cho thao tác 
            DisEnable_LOP();
            DisEnable_NGANH();
            DisEnable_KhoaHoc();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); 

        }

        #region LOP
        private void btnLuu_Lop_Click(object sender, EventArgs e)
        {

            if (flag == "thêm")
            {
                txtMaLop.Text = qlsv_xlLop.TaoMaLop();
                qlsv_xlLop.MALOP = txtMaLop.Text;
                qlsv_xlLop.MAKHOAHOC = cmbMaKhoaHoc.SelectedValue.ToString();
                qlsv_xlLop.MANGANH = cmbMaNganh.SelectedValue.ToString();
                qlsv_xlLop.TENLOP = txtTenLop.Text;
                qlsv_xlLop.GHICHU = txtGhichu_Lop.Text;
                qlsv_xlLop.ThemLop();
                dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
                xlc.ClearAllTextBox(groupboxLOP);

                DisEnable_LOP();

                btnThemLop.Visible = true;
                btnLamlai_Lop.Enabled = true;
                btnCancel_LOP.Enabled = true;
                dgvLop.Enabled = true;

                int i;
                for (i = 0; i < dgvLop.RowCount - 1; i++)
                {
                    if (dgvLop.Rows[i].Cells[1].Value.ToString() == txtMaLop.Text)
                        break;
                }
                dgvLop.CurrentCell = dgvLop[0, i];

            }
            else if (flag == "sửa")
            {

                qlsv_xlLop.MALOP = txtMaLop.Text;
                qlsv_xlLop.MAKHOAHOC = cmbMaKhoaHoc.SelectedValue.ToString();
                qlsv_xlLop.MANGANH = cmbMaNganh.SelectedValue.ToString();
                qlsv_xlLop.TENLOP = txtTenLop.Text;
                qlsv_xlLop.GHICHU = txtGhichu_Lop.Text;
                qlsv_xlLop.CapNhatLop();
                dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
                xlc.ClearAllTextBox(groupboxLOP);
                DisEnable_LOP();

                btnThemLop.Visible = true;
                btnLamlai_Lop.Enabled = true;
                btnCancel_LOP.Enabled = true;
                dgvLop.Enabled = true;

                //focus
                dgvLop.CurrentCell = dgvLop[0, index];
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            //button
            btnThemLop.Visible = false;
            btnLamlai_Lop.Enabled = false;
            btnCancel_LOP.Enabled = false;
            dgvLop.Enabled = false;

            xlc.ClearAllTextBox(groupboxLOP);

            Enable_LOP();
        }

        private void btnLamlai_Lop_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            //button
            btnThemLop.Visible = false;
            btnCancel_LOP.Enabled = false;
            dgvLop.Enabled = false;

            Enable_LOP();
        }

        private void btnCancel_LOP_Click(object sender, EventArgs e)
        {
            qlsv_xlLop.XoaLop();
            dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
            xlc.ClearAllTextBox(groupboxLOP);
            DisEnable_LOP();

        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            if (cmbTimLop.Text == "-- Chọn điều kiện --")
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm ! ");
                return;
            }
            else
            {
                if (txtTimLop.Text == "")
                {
                    dgvLop.DataSource = qlsv_xlLop.LoadDL_dgvLop();
                }
                else
                {
                    qlsv_xlLop.DKTIM = txtTimLop.Text;
                    dgvLop.DataSource = qlsv_xlLop.TimKiemLop();
                    int n = qlsv_xlLop.TimKiemLop().Rows.Count;
                    MessageBox.Show("Tìm thấy " + n + " kết quả");
                }
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtMaLop.Text = dgvLop.CurrentRow.Cells[0].Value.ToString();
            cmbMaKhoaHoc.SelectedValue = dgvLop.CurrentRow.Cells[1].Value;
            cmbMaNganh.SelectedValue = dgvLop.CurrentRow.Cells[2].Value;
            txtTenLop.Text = dgvLop.CurrentRow.Cells[3].Value.ToString();
            txtGhichu_Lop.Text = dgvLop.CurrentRow.Cells[4].Value.ToString();
            qlsv_xlLop.MALOP = txtMaLop.Text;
            if ((dgvLop.CurrentRow.Cells[1].Value.ToString() != "") && (dgvLop.CurrentRow.Cells[2].Value.ToString() != ""))
            {
                qlsv_xlLop.MAKHOAHOC = cmbMaKhoaHoc.SelectedValue.ToString();
                qlsv_xlLop.MANGANH = cmbMaNganh.SelectedValue.ToString();
            }
            qlsv_xlLop.TENLOP = txtTenLop.Text;
            qlsv_xlLop.GHICHU = txtGhichu_Lop.Text;

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

        #endregion

        #region NGANH
        private void btnLuu_NGANH_Click(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {
                txtMaNganh.Text = qlsv_xlNganh.TaoMaNganh();
                qlsv_xlNganh.MANGANH = txtMaNganh.Text;
                qlsv_xlNganh.TENNGANH = txtTenNganh.Text;
                qlsv_xlNganh.GHICHU = txtGhiChu_Nganh.Text;

                qlsv_xlNganh.ThemNganh();
                dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
                xlc.ClearAllTextBox(groupBox7);

                DisEnable_NGANH();
                btnThem_Nganh.Visible = true;
                btnLamlai_Nganh.Enabled = true;
                btnCancel_NGANH.Enabled = true;
                dgvNganh.Enabled = true;
                int i;
                for (i = 0; i < dgvNganh.RowCount - 1; i++)
                {
                    if (dgvNganh.Rows[i].Cells[1].Value.ToString() == txtMaNganh.Text)
                        break;
                }
                dgvNganh.CurrentCell = dgvNganh[0, i];

            }
            else if (flag == "sửa")
            {

                qlsv_xlNganh.MANGANH = txtMaNganh.Text;
                qlsv_xlNganh.TENNGANH = txtTenNganh.Text;
                qlsv_xlNganh.GHICHU = txtGhiChu_Nganh.Text;

                qlsv_xlNganh.CapNhatNganh();
                dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
                xlc.ClearAllTextBox(groupBox7);

                DisEnable_NGANH();
                btnThem_Nganh.Visible = true;
                btnLamlai_Nganh.Enabled = true;
                btnCancel_NGANH.Enabled = true;
                dgvNganh.Enabled = true;
                //focus
                dgvNganh.CurrentCell = dgvNganh[0, index];
            }
        }

        private void btnThem_Nganh_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            //button
            btnThem_Nganh.Visible = false;
            btnLamlai_Nganh.Enabled = false;
            btnCancel_NGANH.Enabled = false;
            dgvNganh.Enabled = false;

            xlc.ClearAllTextBox(groupBox7);

            Enable_NGANH();
        }

        private void btnLamlai_Nganh_Click(object sender, EventArgs e)
        {

            flag = "sửa";
            //button
            btnThem_Nganh.Visible = false;
            btnCancel_NGANH.Enabled = false;
            dgvNganh.Enabled = false;

            Enable_NGANH();
        }

        private void btnCancel_NGANH_Click(object sender, EventArgs e)
        {
            qlsv_xlNganh.XoaNganh();
            dgvNganh.DataSource = qlsv_xlNganh.LoadDL();
            xlc.ClearAllTextBox(groupBox7);
            //xlc.ClearAllTextBox(groupBox7);
            DisEnable_NGANH();
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtMaNganh.Text = dgvNganh.CurrentRow.Cells[0].Value.ToString();
            txtTenNganh.Text = dgvNganh.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu_Nganh.Text = dgvNganh.CurrentRow.Cells[2].Value.ToString();
            //
            qlsv_xlNganh.MANGANH = txtMaNganh.Text;
            qlsv_xlNganh.TENNGANH = txtTenNganh.Text;
            qlsv_xlNganh.GHICHU = txtGhiChu_Nganh.Text;
        }

        #endregion

        #region KHOÁ HỌC
        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            flag = "thêm";
            btnCancel_KhoaHoc.Enabled = false;
            btnNhapLaiKhoahoc.Enabled = false;
            xlc.ClearAllTextBox(groupBox1);
            Enable_KhoaHoc();
        }
        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
            if (flag == "thêm")
            {
                txtMaKhoaHoc.Text = qlsv_xKhoaHoc.TaoMaKhoaHoc();
                qlsv_xKhoaHoc.MAKHOAHOC = txtMaKhoaHoc.Text;
                qlsv_xKhoaHoc.TENKHOAHOC = txtTenKhoaHoc.Text;

                if ((int)dtpNgayKetThuc.Value.Year - (int)dtpNgayBatDau.Value.Year > 0)
                {
                    qlsv_xKhoaHoc.NGAYBATDAU = dtpNgayBatDau.Value;
                    qlsv_xKhoaHoc.NGAYKETTHUC = dtpNgayKetThuc.Value;
                }
                else
                {
                    MessageBox.Show("Không được nhập ngày kết thúc nhỏ hơn ngày bắt đầu của khoá học","Thông báo");
                    dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
                    txtMaKhoaHoc.Text = "";
                    DisEnable_KhoaHoc();
                    btnCancel_KhoaHoc.Enabled = true;
                    btnNhapLaiKhoahoc.Enabled = true;
                    return;
                }

                qlsv_xKhoaHoc.GHICHU = txtGhichu_KhoaHoc.Text;
                qlsv_xKhoaHoc.ThemKhoaHoc();
                dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
                DisEnable_KhoaHoc();
                btnCancel_KhoaHoc.Enabled = true;
                btnNhapLaiKhoahoc.Enabled = true;
                int i;
                for (i = 0; i < dgvNganh.RowCount - 1; i++)
                {
                    if (dgvNganh.Rows[i].Cells[1].Value.ToString() == txtMaNganh.Text)
                        break;
                }
                dgvNganh.CurrentCell = dgvNganh[0, i];
            }
            else if (flag == "sửa")
            {
                
                qlsv_xKhoaHoc.MAKHOAHOC = txtMaKhoaHoc.Text;
                qlsv_xKhoaHoc.TENKHOAHOC = txtTenKhoaHoc.Text;
                qlsv_xKhoaHoc.NGAYBATDAU = dtpNgayBatDau.Value;
                qlsv_xKhoaHoc.NGAYKETTHUC = dtpNgayKetThuc.Value;
                qlsv_xKhoaHoc.GHICHU = txtGhichu_KhoaHoc.Text;
                qlsv_xKhoaHoc.CapNhatKhoaHoc();
                dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
                DisEnable_KhoaHoc();
                btnCancel_KhoaHoc.Enabled = true;
                btnNhapLaiKhoahoc.Enabled = true;
                dgvNganh.CurrentCell = dgvNganh[0, index];
            }
        }

        private void btnNhapLaiKhoahoc_Click(object sender, EventArgs e)
        {
            flag = "sửa";
            btnCancel_KhoaHoc.Enabled = false;
            btnNhapLaiKhoahoc.Enabled = false;
            Enable_KhoaHoc();
        }

        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
                txtMaKhoaHoc.Text = dgvKhoaHoc.CurrentRow.Cells[0].Value.ToString();
                txtTenKhoaHoc.Text = dgvKhoaHoc.CurrentRow.Cells[1].Value.ToString();
                if (dgvKhoaHoc.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    dtpNgayBatDau.Value = (DateTime)dgvKhoaHoc.CurrentRow.Cells[2].Value;
                }
                if (dgvKhoaHoc.CurrentRow.Cells[3].Value.ToString() != "")
                {
                    dtpNgayKetThuc.Value = (DateTime)dgvKhoaHoc.CurrentRow.Cells[3].Value;
                }

                txtGhichu_KhoaHoc.Text = dgvKhoaHoc.CurrentRow.Cells[4].Value.ToString();

            
            qlsv_xKhoaHoc.MAKHOAHOC = txtMaKhoaHoc.Text;
            qlsv_xKhoaHoc.TENKHOAHOC = txtTenKhoaHoc.Text;
            qlsv_xKhoaHoc.NGAYBATDAU = dtpNgayBatDau.Value;
            qlsv_xKhoaHoc.NGAYKETTHUC = dtpNgayKetThuc.Value;
            qlsv_xKhoaHoc.GHICHU = txtGhichu_KhoaHoc.Text;

        }
        private void btnCancel_KhoaHoc_Click(object sender, EventArgs e)
        {
            qlsv_xKhoaHoc.XoaKhoaHoc();
            dgvKhoaHoc.DataSource = qlsv_xKhoaHoc.LoadDLKhoaHoc();
            xlc.ClearAllTextBox(groupBox1);
        }







        #endregion

        private void tabKhoaHoc_Nganh_Lop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ha");
        }
    }
}
