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
    public partial class uc_NhapDiem : UserControl
    {
        public uc_NhapDiem()
        {
            InitializeComponent();
        }
        QLSV_XDiem qlsv_xlDiem = new QLSV_XDiem();
        c_XuLyChung XLC = new c_XuLyChung();

    

        private void uc_NhapDiem_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = qlsv_xlDiem.LayDuLieuKhoa();
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            dgvDiem.DataSource = qlsv_xlDiem.LayDLDiem();

            qlsv_xlDiem.txtTIMMSV = txtTimKiem_MSSV;
            qlsv_xlDiem.GoiYTimMSV();
           

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

          qlsv_xlDiem.MAKHOA = cmbKhoa.SelectedValue.ToString();
          qlsv_xlDiem.LISTBOX = lbMonHoc;
          qlsv_xlDiem.LayDanhSachMonHocVaoListBox();

          qlsv_xlDiem.TXTMSV = txtMaSV;
          qlsv_xlDiem.GoiYMaSinhVien();
        }

      

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            qlsv_xlDiem.MAMH = txtMaMH.Text;
            qlsv_xlDiem.MASV = txtMaSV.Text;
            if (txtDiemLanI.Text == "")
            {
                MessageBox.Show("Chưa nhập điểm !");
                return;
            }
            qlsv_xlDiem.DIEMLANI = float.Parse(txtDiemLanI.Text);
            if (txtDiemLanII.Text == "")
            {
                qlsv_xlDiem.DIEMLANII = 0;
            }
            else 
            {
                qlsv_xlDiem.DIEMLANII = float.Parse(txtDiemLanII.Text);
            }
            qlsv_xlDiem.LANTHI = int.Parse(txtLanThi.Text);
            qlsv_xlDiem.NGAYTHI = dtpNgayThi.Value;
            qlsv_xlDiem.GHICHU = txtGhiChu.Text;
            qlsv_xlDiem.NhapDiem();

            dgvDiem.DataSource = qlsv_xlDiem.LayDLDiem();
            XLC.ClearAllTextBox(groupBox3);
            qlsv_xlDiem.txtTIMMSV = txtTimKiem_MSSV;
            qlsv_xlDiem.GoiYTimMSV();
        }

        private void txtDiemLanI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true; 
        }

        private void txtDiemLanII_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                e.Handled = true; 
        }

        private void txtLanThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            qlsv_xlDiem.MAMH = txtMaMH.Text;
            qlsv_xlDiem.MASV = txtMaSV.Text;
            qlsv_xlDiem.XoaDiem();
            //refresh lai du lieu
            dgvDiem.DataSource = qlsv_xlDiem.LayDLDiem();
            XLC.ClearAllTextBox(groupBox3);
            qlsv_xlDiem.txtTIMMSV = txtTimKiem_MSSV;
            qlsv_xlDiem.GoiYTimMSV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            qlsv_xlDiem.MAMH = txtMaMH.Text;
            qlsv_xlDiem.MASV = txtMaSV.Text;
            if (txtDiemLanI.Text == "")
            {
                MessageBox.Show("Chưa nhập điểm !");
                return;
            }
            qlsv_xlDiem.DIEMLANI = float.Parse(txtDiemLanI.Text);
            if (txtDiemLanII.Text == "")
            {
                qlsv_xlDiem.DIEMLANII = 0;
            }
            else
            {
                qlsv_xlDiem.DIEMLANII = float.Parse(txtDiemLanII.Text);
            }
            if (txtLanThi.Text == "")
            {
                MessageBox.Show("Chưa nhập lần thi !");
                return;
            }
            qlsv_xlDiem.LANTHI = int.Parse(txtLanThi.Text);
            qlsv_xlDiem.NGAYTHI = dtpNgayThi.Value;
            qlsv_xlDiem.GHICHU = txtGhiChu.Text;
            qlsv_xlDiem.CapNhatDiem();

            dgvDiem.DataSource = qlsv_xlDiem.LayDLDiem();
            XLC.ClearAllTextBox(groupBox3);
            qlsv_xlDiem.txtTIMMSV = txtTimKiem_MSSV;
            qlsv_xlDiem.GoiYTimMSV();
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            txtMaSV.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            txtDiemLanI.Text = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            txtDiemLanII.Text = dgvDiem.CurrentRow.Cells[3].Value.ToString();
            txtLanThi.Text = dgvDiem.CurrentRow.Cells[4].Value.ToString();
            if(dgvDiem.CurrentRow.Cells[5].Value.ToString() != "")
            {
                 dtpNgayThi.Value = (DateTime)dgvDiem.CurrentRow.Cells[5].Value;
            }
           
            txtGhiChu.Text = dgvDiem.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            qlsv_xlDiem.MASV = txtTimKiem_MSSV.Text;
            dgvDiem.DataSource = qlsv_xlDiem.TracuuDiem();
        }

        private void lbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbMonHoc.SelectedValue != null)
            {
                txtMaMH.Text = lbMonHoc.SelectedValue.ToString();
                groupBox3.Enabled = true;
            }
        }

      

        
    }
}
