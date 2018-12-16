using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
namespace QLSV_Database
{
    public class c_ThaoTacChung
    {
        c_DataProvider conn = new c_DataProvider();

        //dung de lay danh sach vao datagridview
        public DataTable LayDanhSach(string strSQL)
        {
            DataTable dt = new DataTable();

            SqlConnection cn = conn.OpenCN();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                da.Fill(dt);
                conn.CloseCN(cn);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }
            return dt;
        }


        //hàm kiểm tra ten them vao đã tồn tại trong csdl hay chua
        public string LayTen(string strSQL)
        {
            SqlConnection cn = conn.OpenCN();
            string ten = "";
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    // cb.Text = dr[col].ToString();
                    ten = dr[0].ToString();
                }
                dr.Close();
                cmd.Dispose();
                conn.CloseCN(cn);
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi khi truy vấn dữ liệu " + ex.ToString());
            }
            return ten;
        }

        //load du lieu len combobox
        public void LoadDLVaoCombobox(string strSQL, ComboBox cmb, string DisplayMember, string ValueMember)
        {
           // SqlConnection cn = conn.OpenCN();
            try
            {
                cmb.DataSource = LayDanhSach(strSQL);
                cmb.DisplayMember = DisplayMember;
                cmb.ValueMember = ValueMember;

               // conn.CloseCN(cn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi Load dữ liệu! \n" + ex.ToString() );
            }
        }


        //ham tao ma so tu dong
        public string SinhMaTuDong(string KyTuBatDau, string strSQL)
        {
            string maso = "";
            int n = 0;
            SqlConnection cn = conn.OpenCN();
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maso = dr[0].ToString();
            }
            dr.Close();
            conn.CloseCN(cn);

            if (maso == "")
            {
                return maso = KyTuBatDau + "0000000";
            }
            else
            {
                maso = maso.Substring(2, maso.Length - 2);
                n = int.Parse(maso);
                n = n + 1;//tang len 1 don vi
                maso = n.ToString();
                //them so 0 vao ma
                while (maso.Length < 7)
                {
                    maso = "0" + maso;
                }
                maso = KyTuBatDau + maso;
                return maso;
            }

        }

        //hàm tạo gợi ý khi nhập từ khóa vào textbox
        public void TextBox_AutoComplete(TextBox txt, string table, int column)//giá trị nhập, table, cột
        {
            
            txt.AutoCompleteCustomSource.Clear() ;
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //gán nguồn cấp dữ liệu cho text box autocomplete
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            string strSql = "Select * from " + table + "";
            SqlConnection cn = conn.OpenCN();
            try
            {
                SqlCommand cmd = new SqlCommand(strSql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt.AutoCompleteCustomSource.Add(dr[column].ToString()).ToString();
                    //load du lieu len CustomSource cua textbox autocomplete
                    //txt.Text = txt.AutoCompleteCustomSource.Add(dr.GetValue(column).ToString()).ToString();

                }
                dr.Close();
            }
            catch
            {
                throw;
            }

            conn.CloseCN(cn);
        }

        //hàm thao tác với csdl(them, xoa, sua, cap nhat.)
        public void ThaoTacDuLieu(string strSQL, CommandType cmdT, params SqlParameter[] param)// params SqlParameter[] param)
        {
          
           SqlConnection cn =  conn.OpenCN();
           SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;//truyen vao ten cua storeprocedure
            cmd.CommandType = cmdT;
            cmd.Connection = cn;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                        cmd.Parameters.Add(p);
                }
            }
            try
            {
                cmd.ExecuteNonQuery();
                param = null;
                cmd.Parameters.Clear();
                cmd.Dispose();
                conn.CloseCN(cn);
               
            }
            catch (SqlException se)
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                throw new Exception(se.ToString());
            }
        
        }

        public DataTable Reports(string strSQL, string table)
        {
            SqlConnection cn = conn.OpenCN();
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
               
                da.Fill(ds, table);
                //return ds.Tables[table];
            }
            catch (SqlException se)
            {
                //throw new Exception(se.ToString());
                MessageBox.Show(se.ToString());
            }
            finally
            {
                conn.CloseCN(cn);
            }
            return ds.Tables[table];
           
        
        }

        public string ChuanHoaString(string str)
        {
            string FullName = str;
            string result = "";
            if (str!="")
            { 
                FullName = FullName.Trim();//cắt khoảng trắng dư ở 2 đầu
                while (FullName.IndexOf("  ") != -1)// tìm không thấy return -1
                {
                    FullName = FullName.Replace("  ", " ");
                }
                string[] SubName = FullName.Split(' ');//chuỗi cắt khi gặp khoẳng trắng, thành mảng chuỗi
                for (int i = 0; i < SubName.Length; i++)
                {
                    string FirstChar = SubName[i].Substring(0, 1);
                    string OtherChar = SubName[i].Substring(1);
                    SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                    result += SubName[i] + " ";
                }
            }
            return result;
        }


    }
}
