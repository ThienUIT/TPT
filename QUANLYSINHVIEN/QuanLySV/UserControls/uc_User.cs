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

namespace QLSV_GiaoDien
{
    public partial class uc_User : UserControl
    {
        QLSV_Xuly.QLSV_XUser xl_user = new QLSV_XUser();
        c_ThaoTacChung ctc = new c_ThaoTacChung();
        public uc_User()
        {
            InitializeComponent();
        }
       
   
        

        private void btnThem_Click(object sender, EventArgs e)
        {
           
                xl_user.USER = txtUserName.Text;
                xl_user.PASS = txtPass.Text;
                xl_user.CreateUser();
                dgvUser.DataSource = xl_user.LoadDL();
                xl_user.TXT = txtTenTimKiem;
                xl_user.TextBoxAutoComplete();
           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenTimKiem.Text != "")
            {

                xl_user.USER = txtTenTimKiem.Text;
                dgvUser.DataSource = xl_user.TimKiem();
                int n = xl_user.TimKiem().Rows.Count;

                MessageBox.Show("Tìm thấy " + n + " kết quả");

            }
            else
            {
                MessageBox.Show("Không có đủ dữ kiện tìm kiếm. Vui lòng thử lại!");
                txtTenTimKiem.Focus();
            }
        }
        private void uc_User_Load(object sender, EventArgs e)
        {
            if (rdTaoUser.Checked)
            {
                lblTacvu.Text = "Thêm mới người dùng";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                lblMatkhaumoi.Visible = false;
                txtNewPass.Visible = false;
                txtTenTimKiem.Text = "";
            }
            dgvUser.DataSource = xl_user.LoadDL();
            xl_user.TXT = txtTenTimKiem;
            xl_user.TextBoxAutoComplete();
           
        }

        #region radio button

        private void rdTaoUser_CheckedChanged(object sender, EventArgs e)
        {
            lblTacvu.Text = "Thêm mới người dùng";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblMatkhaumoi.Visible = false;
            txtNewPass.Visible = false;
            btnThem.Enabled = true;
            lblPassword.Visible = true;
            txtPass.Visible = true;
            lblPassword.Text = "Password:";
        }

       

        private void rdDoiMatkhau_CheckedChanged(object sender, EventArgs e)
        {
            lblTacvu.Text = "Đổi mật khẩu";
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            lblMatkhaumoi.Visible = true;
            txtNewPass.Visible = true;
            lblPassword.Text = "Nhập mật khẩu cũ:";
            lblPassword.Visible = true;
            txtPass.Visible = true;
            txtPass.Text = "";
        }

        private void rdXoa_CheckedChanged(object sender, EventArgs e)
        {
            lblTacvu.Text = "Xóa tài khoản";
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            lblMatkhaumoi.Visible = false;
            txtNewPass.Visible = false;
            lblPassword.Visible = false;
            txtPass.Visible = false;
        }
        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {
                xl_user.USER = txtUserName.Text;
                xl_user.NEWPASS = txtNewPass.Text;
                xl_user.PASS = txtPass.Text;
                xl_user.UpdateUser();
                dgvUser.DataSource = xl_user.LoadDL();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
                xl_user.USER = txtUserName.Text;
                xl_user.DeleteUser();
                dgvUser.DataSource = xl_user.LoadDL();
      
        }

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = xl_user.LoadDL();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
