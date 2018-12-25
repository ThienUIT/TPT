using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLSV_Database;
using QLSV_Xuly;
namespace QLSV_GiaoDien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        QLSV_XUser xl_user = new QLSV_XUser();// thao tác xử lý đăng nhập 
        public delegate void EnableGroupbox(bool kq);
        public EnableGroupbox setGroupbox;
        public string PQ;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {       
            xl_user.USER = txtUser.Text;
            xl_user.PASS = txtPass.Text;
            if (xl_user.Login() == "Admin")
            {
                PQ = "Admin";
                this.Close();
                txtPass.Text = "";
                txtUser.Text = "";
                setGroupbox(true);
                MessageBox.Show("Đăng nhập thành công");
                
            }
            else if (xl_user.Login() == "User")
            {
                PQ = "User";
                this.Close();
                txtPass.Text = "";
                txtUser.Text = "";
                setGroupbox(true);
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                PQ = "";
                MessageBox.Show("Đăng nhập thất bại");
                return;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }


    }
}
