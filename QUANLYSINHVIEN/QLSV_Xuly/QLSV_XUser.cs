using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSV_Database;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;
namespace QLSV_Xuly
{
   public class QLSV_XUser
    {   
        private QLSV_Database.QLSV_DUser qlsv_dUser = new QLSV_DUser();
        c_ThaoTacChung ctc = new c_ThaoTacChung();
        //public QLSV_XUser()
        //{
        //    qlsv_dUser = new QLSV_DUser(this);
        //}
        private string User;
        private string Pass;
        private string newPass;
        private bool Id;

        //sử dụng để gọi ý tìm kiếm
        private TextBox txt = new TextBox();
        private string table = "tb_User";
        private int column = 0;


        public TextBox TXT
        {
            get { return txt; }
            set { txt = value; }
        }

        public string NEWPASS
        {
            get { return newPass; }
            set 
            { 
                newPass = value;
                if (this.newPass == "")
                {
                    
                    MessageBox.Show("Vui lòng nhập mật khẩu mới");
                }
            }
        }
        public string PASS
        {
            get { return Pass; }
            set 
            { 
                Pass = value;
                if (this.PASS == "")
                {
                  
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                }
            }
        }
        public string USER
        {
            get { return User; }
            set 
            { 
                User = value;
                if (this.USER == "")
                {
                   
                    MessageBox.Show("Chưa nhập Username");
                }
            }
        }
        public bool ID
        {
            get { return Id; }
            set { Id = value; }
        
        }

        //mã hóa password ,using System.Security.Cryptography
        public string MahoaPass(string pass)
        {
            UnicodeEncoding uc = new UnicodeEncoding();
            byte[] hash = uc.GetBytes(pass);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            hash = md5.ComputeHash(hash);
            return Convert.ToBase64String(hash);
        }
        //tạo tài khoản
        public void CreateUser()
        {
            if (this.USER == "")
            {
                
            }
            else
            {
                if (qlsv_dUser.isExist(USER) == true)
                {

                    // throw new Exception("User này đã tồn tại");
                    MessageBox.Show("User này đã tồn tại");
                }

                else
                {
                    qlsv_dUser.CreateUser(USER, MahoaPass(PASS),ID);
                    MessageBox.Show("Tạo tài khoản mới thành công");
                }
            }
            

        }
        //xoá tài khoản
        public void DeleteUser()
        {
            if (qlsv_dUser.isExist(USER) == true)
            {
                
                qlsv_dUser.DeleteUser(USER);
            }
            else
                //throw new Exception("Không tồn tại User này");
                  MessageBox.Show("Không tồn tại User này");
        }
        //đổi mật khẩu
        public void UpdateUser()
        {
            if (qlsv_dUser.isExist(USER) == true)
            {
                string oldpass = qlsv_dUser.GetOldPass(USER).Rows[0][0].ToString();
                if (MahoaPass(PASS) != oldpass)
                {
                    //throw new Exception("Mật khẩu nhập vào không trùng khớp");
                    MessageBox.Show("Mật khẩu nhập vào không trùng khớp");

                }
                else
                {
                    qlsv_dUser.UpdateUser(USER, MahoaPass(NEWPASS),ID);
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dUser.LoadDL("tb_User");
           
            return dt;
        }

        public DataTable TimKiem()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dUser.TimKiem(USER);
            return dt;
        }

        public void TextBoxAutoComplete()
        {
            ctc.TextBox_AutoComplete(TXT, table, column);
        }

     
        public string Login()
        {
            string kq="";

            if (qlsv_dUser.CheckUser(USER, MahoaPass(PASS)) == true)
            {
               
                if (qlsv_dUser.PQ(USER, MahoaPass(PASS))==true)
                {       
                    kq = "Admin";
                }
                else if(qlsv_dUser.PQ(USER, MahoaPass(PASS))==false)
                {                 
                    kq = "User";
                }   
            }
            else
            {               
                kq = "False";
            }
            return kq;
        }

    }
}
