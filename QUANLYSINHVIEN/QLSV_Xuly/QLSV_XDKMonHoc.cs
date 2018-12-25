using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
   public class QLSV_XDKMonHoc
    {
       QLSV_DDKMonHoc qlsv_dDKMonHoc = new QLSV_DDKMonHoc();

       private string MaMh;
       private ComboBox cmb;
       private string Masv;
       private DateTime Ngaydk;
       private int Sotc;
       private int Hocky;
       private TextBox txtTim;
       private TextBox txtMsv;

       public TextBox TXTMSV
       {
           get { return txtMsv; }
           set { txtMsv = value; }
       }
       public TextBox TXTTIM
       {
           get { return txtTim; }
           set { txtTim = value; }
       }
       public string MAMONHOC
       {
           get { return MaMh; }
           set { MaMh = value; }
       }
     
       public string MASINHVIEN
       {
           get { return Masv; }
           set { Masv = value; }
       }
    
       public DateTime NGAYDANGKY
       {
           get { return Ngaydk; }
           set { Ngaydk = value; }
       }
      
       public int SOTINCHI
       {
           get { return Sotc; }
           set { Sotc = value; }
       }
     
       public int HOCKY
       {
           get { return Hocky; }
           set { Hocky = value; }
       }
      
       

       public ComboBox CMB
       {
           get { return cmb; }
           set { cmb = value; }
       }

       public void ThemDKMonHoc()
       {
           try
           {
               qlsv_dDKMonHoc.ThemDKMonHoc(MAMONHOC, MASINHVIEN, NGAYDANGKY, SOTINCHI, HOCKY);
           }
           catch

           {
               if (LayTenSV() != "")
               {
                   MessageBox.Show("Sinh Viên: " + LayTenSV() +" đã đăng ký môn học này!");
               }
               else
                   MessageBox.Show("Sinh Viên này không tồn tại." );
           }
       }

       public void CapNhatDKMonHoc()
       {
           try
           {
               qlsv_dDKMonHoc.CapNhatDKMonHoc(MAMONHOC, MASINHVIEN, NGAYDANGKY, SOTINCHI, HOCKY);
           }
           catch
           {
               MessageBox.Show("Có lỗi khi thực hiện !");
           }
       }

       public void XoaDKMonHoc()
       {
           try
           {
               qlsv_dDKMonHoc.XoaDKMonHoc(MAMONHOC,MASINHVIEN);
           }
           catch
           {
               MessageBox.Show("Có lỗi khi thực hiện !");
           }
       }

       public DataTable LoadDL_DKMonHoc()
       {
           DataTable dt = new DataTable();
           dt = qlsv_dDKMonHoc.LoadDL_DKMonHoc();
           return dt;
       }

       public DataTable TimKiemSVDK()
       {
           DataTable dt = new DataTable();
           dt = qlsv_dDKMonHoc.TimKiemMHDK(MASINHVIEN);
           return dt;
       }

       public void LoadDLVao_cmbMaMonHoc_DK()
       {
           qlsv_dDKMonHoc.LoadDLVaoCombobox(CMB);
       }


       public void GoiYTimKiem()
       {
           qlsv_dDKMonHoc.GoiYTimKiem(TXTTIM);
       }

       public void GoiYMSSV()
       {
           qlsv_dDKMonHoc.GoiYTimMSSV(TXTMSV);
       }

       public string LayTenSV()
       {
           string ten = "";
           ten = qlsv_dDKMonHoc.LayTenSV(MASINHVIEN);
           return ten;
       }
    }
}
