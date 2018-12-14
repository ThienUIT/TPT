using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Windows.Forms;
namespace QLSV_Database
{
    public class QLSV_DUser
    {
        public QLSV_DUser()
        { 
        }

        c_DataProvider conn = new c_DataProvider();
        c_ThaoTacChung cc = new c_ThaoTacChung();
        //Kiểm tra xem user đã tồn tại trong csdl hay chưa
        public bool isExist(string User)
        {
            bool kq = false;
            string strSQL = "Select * from tb_User where Username = @Username";
            SqlConnection cn = conn.OpenCN();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.Add(new SqlParameter("@Username", User));
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (User == dr[0].ToString())
                    {
                        return kq = true; ;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra" + ex.ToString());
            }
            return kq;

        }

        public void CreateUser(string User, string pass)
        {
            SqlParameter u = new SqlParameter();//user
            SqlParameter p = new SqlParameter();//pass
            if(User==""||pass=="")
            {
                MessageBox.Show("Mời nhập user và pass ");
            }
            else
            {
                u.SqlValue = User;
                p.SqlValue = pass;
                u.ParameterName = "@Username";
                p.ParameterName = "@Pass";

                cc.ThaoTacDuLieu("qlsv_AddNewUser", CommandType.StoredProcedure, u, p);
            }
           
          
            
        }

        public void DeleteUser(string User)
        {
            SqlParameter u = new SqlParameter();
            u.SqlValue = User;
            u.ParameterName = "@Username";
            cc.ThaoTacDuLieu("qlsv_DeleteUser", CommandType.StoredProcedure, u);
        }

        public void UpdateUser(String User, string Pass)
        {
            SqlParameter u = new SqlParameter();
            SqlParameter p = new SqlParameter();
            u.SqlValue = User;
            p.SqlValue = Pass;
            u.ParameterName = "@Username";
            p.ParameterName = "@Pass";
            cc.ThaoTacDuLieu("qlsv_UpdateUser", CommandType.StoredProcedure, u, p);
        }

        public DataTable GetOldPass(string User)
        {
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select Pass from tb_user where Username = '" + User + "'");
            return dt;
        }

        public DataTable LoadDL(string tableName)
        {
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select * from " + tableName + "");
            return dt;
        }

        public DataTable TimKiem( string User)
        {
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select * from  tb_User where Username ='" + User + "'");
            return dt;
        }
        //checkuser để đăng nhập
        public bool CheckUser(string User,string pass )
        {
            bool kq = false;
            DataTable dt = new DataTable();
            try
            {
                dt = cc.LayDanhSach("Select * from tb_User Where Username ='" + User + "' and pass ='" + pass + "'");
                int n = dt.Rows.Count;
                if (n > 0)
                {
                    return kq = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return kq;
        }
    }
}
