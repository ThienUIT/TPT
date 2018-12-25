using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_Xuly;
namespace QLSV_GiaoDien
{
    public partial class frmQuanLiMonHoc : Form
    {
        QLSV_XMonHoc qlsv_xlMonHoc = new QLSV_XMonHoc();
        c_XuLyChung xlc = new c_XuLyChung();
        public frmQuanLiMonHoc()
        {
            InitializeComponent();
        }

        public void enable()
        {
            txtMaMH.Enabled = true;
            txtGhichu_MH.Enabled = true;
            txtTenMh.Enabled = true;
            txtTimMH.Enabled = true;
            rdMonbatbuoc.Enabled = true;
            rdMontuchon.Enabled = true;
            numSoTietLT.Enabled = true;
            numSoTietTH.Enabled = true;
            numSoTinChi.Enabled = true;
            numTongsotiet.Enabled = true;
            cmbMaKhoa_MH.Enabled = true;
            btnLuu.Visible = true;
        }
        public void disenable()
        {
            txtMaMH.Enabled = false;
            txtGhichu_MH.Enabled = false;
            txtTenMh.Enabled = false;
            txtTimMH.Enabled = false;
            rdMonbatbuoc.Enabled = false;
            rdMontuchon.Enabled = false;
            numSoTietLT.Enabled = false;
            numSoTietTH.Enabled = false;
            numSoTinChi.Enabled = false;
            numTongsotiet.Enabled = false;
            cmbMaKhoa_MH.Enabled = false;
            btnLuu.Visible = false;
        }


        private void frmQuanLiMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonhoc.DataSource = qlsv_xlMonHoc.LoadDLMonHoc();
            qlsv_xlMonHoc.CMB = cmbMaKhoa_MH;
            qlsv_xlMonHoc.LoadDLVaoCombobox_cmbMaKhoa_MH();

            disenable();
            //qlsv_xlMonHoc.TXTTIMKIEM = txtTimMH;
            //qlsv_xlMonHoc.GoiYTimMH();
        }

        private void dgvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvMonhoc.CurrentRow.Cells[0].Value.ToString();
            txtTenMh.Text = dgvMonhoc.CurrentRow.Cells[1].Value.ToString();
            if (dgvMonhoc.CurrentRow.Cells[2].Value.ToString() != "")
            {
                cmbMaKhoa_MH.SelectedValue = dgvMonhoc.CurrentRow.Cells[2].Value;
            }
            if ((dgvMonhoc.CurrentRow.Cells[3].Value.ToString() != "") && (dgvMonhoc.CurrentRow.Cells[5].Value.ToString() != "") && (dgvMonhoc.CurrentRow.Cells[6].Value.ToString() != "") && (dgvMonhoc.CurrentRow.Cells[7].Value.ToString() != ""))
            {
                numSoTinChi.Value = (int)dgvMonhoc.CurrentRow.Cells[3].Value;
                numTongsotiet.Value = (int)dgvMonhoc.CurrentRow.Cells[5].Value;
                numSoTietLT.Value = (int)dgvMonhoc.CurrentRow.Cells[6].Value;
                numSoTietTH.Value = (int)dgvMonhoc.CurrentRow.Cells[7].Value;
            }
            txtGhichu_MH.Text = dgvMonhoc.CurrentRow.Cells[8].Value.ToString();

            if (dgvMonhoc.CurrentRow.Cells[4].Value.ToString() == "Bắt buộc")
            {
                rdMonbatbuoc.Checked = true;
            }
            else if (dgvMonhoc.CurrentRow.Cells[4].Value.ToString() == "Tự chọn")
            {
                rdMontuchon.Checked = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            enable();
            groupBox1.Enabled = false;
        }

        private void cmbTimMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int col = 0;
            qlsv_xlMonHoc.TXTTIMKIEM = txtTimMH;
            
            if (cmbTimMH.SelectedItem.ToString() == "Mã môn học")
            {
                col = 0;
                qlsv_xlMonHoc.COLUMN = col;
             
                qlsv_xlMonHoc.GoiYTimMH();
                qlsv_xlMonHoc.COTTIMKIEM = "MaMonHoc";
            }
            else if (cmbTimMH.SelectedItem.ToString() == "Tên môn học")
            {
                col = 1;
                qlsv_xlMonHoc.COLUMN = col;
                qlsv_xlMonHoc.GoiYTimMH();
                qlsv_xlMonHoc.COTTIMKIEM = "TenMonHoc";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbTimMH.Text == "-- Chọn điều kiện --")
            {
                MessageBox.Show("Chưa chọn điều kiện tìm kiếm!");
                return;
            }
            qlsv_xlMonHoc.DKTIm = txtTimMH.Text;
            dgvMonhoc.DataSource = qlsv_xlMonHoc.TimKiemMH();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            qlsv_xlMonHoc.MAMONHOC = txtMaMH.Text;
            qlsv_xlMonHoc.MAKHOA = cmbMaKhoa_MH.SelectedValue.ToString();
            qlsv_xlMonHoc.TENMONHOC = txtTenMh.Text;
            qlsv_xlMonHoc.SOTINCHI = (int)numSoTinChi.Value;
            qlsv_xlMonHoc.SOTIETLYTHUYET = (int)numSoTietLT.Value;
            qlsv_xlMonHoc.SOTIETTHUCHANH = (int)numSoTietTH.Value;
            qlsv_xlMonHoc.TONGSOTIET = (int)numTongsotiet.Value;
            qlsv_xlMonHoc.GHICHU = txtGhichu_MH.Text;
            string hinhthuc = "";
            if (rdMonbatbuoc.Checked == true)
            {
                hinhthuc = "Bắt buộc";
            }
            else
                hinhthuc = "Tự chọn";

            qlsv_xlMonHoc.HINHTHUC = hinhthuc;

            qlsv_xlMonHoc.CapNhatMonHoc();
            dgvMonhoc.DataSource = qlsv_xlMonHoc.LoadDLMonHoc();
            xlc.ClearAllTextBox(groupBox3);

            qlsv_xlMonHoc.TXTTIMKIEM = txtTimMH;
            qlsv_xlMonHoc.GoiYTimMH();
            disenable();
            groupBox1.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            qlsv_xlMonHoc.MAMONHOC = txtMaMH.Text;
            qlsv_xlMonHoc.XoaMonHoc();
            dgvMonhoc.DataSource = qlsv_xlMonHoc.LoadDLMonHoc();
            xlc.ClearAllTextBox(groupBox3);

            qlsv_xlMonHoc.TXTTIMKIEM = txtTimMH;
            qlsv_xlMonHoc.GoiYTimMH();
        }
    }
}
