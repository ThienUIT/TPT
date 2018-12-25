using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
   public class QLSV_XGiaoVien
    {
       QLSV_DGiaoVien qlsv_dGiaoVien = new QLSV_DGiaoVien();

       private string Magiaovien;
       private string Cottimkiem;
       private string Tengiaovien;
       private string Makhoa;
       private string Ghichu;
       private ComboBox cmbMaKhoa;
       private string Tentimkiem;
       private TextBox txt;
       private int column;

       public int COLUMN
       {
           get { return column; }
           set { column = value; }
       }

       public TextBox TXT
       {
           get { return txt; }
           set { txt = value; }
       }

       public string MAGIAOVIEN
       {
           get { return Magiaovien; }
           set 
           {
             
               Magiaovien = value;
              
           }
       }
       
       public string TENGIAOVIEN
       {
           get { return Tengiaovien; }
           set { Tengiaovien = value; }
       }
       
       public string MAKHOA
       {
           get { return Makhoa; }
           set 
           
           {
               Makhoa = value; 
               if (value == null)
               {
                   MessageBox.Show("Chưa chọn khoa!");
                   return;
               }
               
           }
       }
       
       public string GHICHU
       {
           get { return Ghichu; }
           set { Ghichu = value; }
       }
       
       public ComboBox cmbMAKHOA
       {
           get { return cmbMaKhoa; }
           set { cmbMaKhoa = value; }
       }
       
       public string TENTIMKIEM
       {
           get { return Tentimkiem; }
           set { Tentimkiem = value; }
       }

       public string COTTIMKIEM
       {
           get { return Cottimkiem; }
           set { Cottimkiem = value; }
       }

       public void ThemGiaoVien()
       {
           try
           {
               qlsv_dGiaoVien.ThemGiaoVien(MAGIAOVIEN, TENGIAOVIEN, MAKHOA, GHICHU);
           }
           catch

           {
               MessageBox.Show("Có lỗi khi thực hiện! ");
           }

       }

       public void CapNhatGiaoVien()
       {
           try
           {
               qlsv_dGiaoVien.CapNhatGiaoVien(MAGIAOVIEN, TENGIAOVIEN, MAKHOA, GHICHU);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
           }

       }

       public void XoaGiaoVien()
       {
           try
           {
               qlsv_dGiaoVien.XoaGiaoVien(MAGIAOVIEN);
           }
           catch
           {
               MessageBox.Show("Có lỗi khi thực hiện! ");
           }

       }

       public DataTable LoadDLGiaoVien()
       {
           DataTable dt = new DataTable();
           dt = qlsv_dGiaoVien.LoadDL_GiaoVien();
           return dt;
       }

       public DataTable TimKiemGV()
       {
           DataTable dt = new DataTable();
           dt = qlsv_dGiaoVien.TimKiemGiaoVien(COTTIMKIEM,TENTIMKIEM);
           return dt;
       }

       public string TaoMaGV()
       {
           string ma;
           ma = qlsv_dGiaoVien.TaoMaGiaoVien();
           return ma;
       }

       public void LoadDLVao_cmbMaKhoa()
       {
           qlsv_dGiaoVien.LayDLVaoCombobox_MaKhoa(cmbMAKHOA);
       }

       public void GoiYGiaoVien()
       {
           qlsv_dGiaoVien.GoiYTimKiem(TXT,COLUMN);
       }
    }
}
