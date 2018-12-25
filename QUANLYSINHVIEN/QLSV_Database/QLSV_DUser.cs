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
            string strSQL = "Select Username,Pass from tb_User where Username = @Username";
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

        public void CreateUser(string User, string pass, bool ID)
        {
            SqlParameter u = new SqlParameter();//user
            SqlParameter p = new SqlParameter();//pass
            SqlParameter i = new SqlParameter();//ID check
            if (User == "" || pass == "")
            {
                MessageBox.Show("Mời nhập user và pass ");
            }
            else
            {
                u.SqlValue = User;
                p.SqlValue = pass;
                i.SqlValue = ID;
                u.ParameterName = "@Username";
                p.ParameterName = "@Pass";
                i.ParameterName = "@ID";

                cc.ThaoTacDuLieu("qlsv_AddNewUser", CommandType.StoredProcedure, u, p, i);
            }



        }

        public void DeleteUser(string User)
        {
            SqlParameter u = new SqlParameter();
            u.SqlValue = User;
            u.ParameterName = "@Username";
            cc.ThaoTacDuLieu("qlsv_DeleteUser", CommandType.StoredProcedure, u);
        }

        public void UpdateUser(String User, string Pass, bool ID)
        {
            SqlParameter u = new SqlParameter();
            SqlParameter p = new SqlParameter();
            SqlParameter i = new SqlParameter();//ID check
            u.SqlValue = User;
            p.SqlValue = Pass;
            i.SqlValue = ID;
            u.ParameterName = "@Username";
            p.ParameterName = "@Pass";
            i.ParameterName = "@ID";
            cc.ThaoTacDuLieu("qlsv_UpdateUser", CommandType.StoredProcedure, u, p, i);
        }

        public DataTable GetOldPass(string User)
        {
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select Pass from tb_user where Username = '" + User + "'");
            return dt;
        }

        public DataTable LoadDL(string tableName)//tableName = tb_User
        {
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select Username,Pass from " + tableName + "");
            return dt;
        }

        public DataTable TimKiem(string User)
        {
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select Username,Pass from  tb_User where Username ='" + User + "'");
            return dt;
        }
        //checkuser để đăng nhập
        public bool CheckUser(string User, string pass)
        {
            bool kq = false;
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select * from tb_User Where Username ='" + User + "' and pass ='" + pass + "'");
            try
            {
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
        public bool PQ(string User, string pass)
        {
            bool id=false;
            DataTable dt = new DataTable();
            dt = cc.LayDanhSach("Select * from tb_User Where Username ='" + User + "' and pass ='" + pass + "'");
            try
            {

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = (bool)dr[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id; //true là admin, false là thường 
        }
    }
}
