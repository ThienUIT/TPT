using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
   public class QLSV_XMonHoc
    {

       QLSV_DMonHoc qlsv_dMonHoc = new QLSV_DMonHoc();

       private string Mamonhoc;
       private ComboBox cmb;
       private string Tenmonhoc;
       private string Makhoa;
       private int Sotinchi;
       private string HinhThuc;
       private int TongSotiet;
       private int Sotietlythuyet;
       private int Sotietthuchanh;
       private string Ghichu;
       private string CotTimKiem;
       private TextBox txtTimKiem;
       private int Column;
       private string Dktim;

       public string DKTIm
       {
           get { return Dktim; }
           set { Dktim = value; }
       }

       public string COTTIMKIEM
       {
           get { return CotTimKiem; }
           set { CotTimKiem = value; }
       }
      

       public int COLUMN
       {
           get { return Column; }
           set { Column = value; }
       }
      

       public TextBox TXTTIMKIEM
       {
           get { return txtTimKiem; }
           set { txtTimKiem = value; }
       }

       public string MAMONHOC
       {
           get { return Mamonhoc; }
           set { Mamonhoc = value; }
       }
      

       public string TENMONHOC
       {
           get { return Tenmonhoc; }
           set { Tenmonhoc = value; }
       }
       
       public string MAKHOA
       {
           get { return Makhoa; }
           set { Makhoa = value; }
       }
      

       public int SOTINCHI
       {
           get { return Sotinchi; }
           set { Sotinchi = value; }
       }
      
       public string HINHTHUC
       {
           get { return HinhThuc; }
           set { HinhThuc = value; }
       }
      
       public int TONGSOTIET
       {
           get { return TongSotiet; }
           set { TongSotiet = value; }
       }
       
       public int SOTIETLYTHUYET
       {
           get { return Sotietlythuyet; }
           set { Sotietlythuyet = value; }
       }
     

       public int SOTIETTHUCHANH
       {
           get { return Sotietthuchanh; }
           set { Sotietthuchanh = value; }
       }
      
       public string GHICHU
       {
           get { return Ghichu; }
           set { Ghichu = value; }
       }
     
       public ComboBox CMB
       {
           get { return cmb; }
           set { cmb = value; }
       }

       public void ThemMonHoc()
       {
           try
           {
               if (KiemTraTenMonHoc(TENMONHOC) == false && (KiemTraSoTietHoc() == true))
               {
                   qlsv_dMonHoc.ThemMonHoc(MAMONHOC, TENMONHOC, MAKHOA, SOTINCHI, HINHTHUC, TONGSOTIET, SOTIETLYTHUYET, SOTIETTHUCHANH, GHICHU);
               }
               
                   
           }
           catch(Exception ex)
           {
               MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
           }
       }

       public void CapNhatMonHoc()
       {
           try
           {
               if (KiemTraTenMonHoc(TENMONHOC) == false && (KiemTraSoTietHoc() == true))
               {
                   qlsv_dMonHoc.CapNhatMonHoc(MAMONHOC, TENMONHOC, MAKHOA, SOTINCHI, HINHTHUC, TONGSOTIET, SOTIETLYTHUYET, SOTIETTHUCHANH, GHICHU);
               }
              
           }
           catch (Exception ex)
           {
               MessageBox.Show("Có lỗi khi thực hiện!\n " + ex.ToString() );
           }
       }

       public void XoaMonHoc()
       {
           try
           {
               qlsv_dMonHoc.XoaMonHoc(MAMONHOC);
           }
           catch(Exception ex)
           {
               MessageBox.Show("Có lỗi khi thực hiện! \n" + ex.ToString());
           }
       }

       public DataTable LoadDLMonHoc()
       {
           DataTable dt = new DataTable();
           dt = qlsv_dMonHoc.LoadDLMonHoc();
           return dt;
       }

       public string TaoMaMonHoc()
       {
           string ma = "";
           ma = qlsv_dMonHoc.TaoMaMonHoc();
           return ma;
       }

       public void LoadDLVaoCombobox_cmbMaKhoa_MH()
       {
           qlsv_dMonHoc.LoadDLVaoComboboxMaKhoa_MH(CMB);
       }

       //hàm kiểm tra tên mon hoc đã tồn tai trong csdl hay chua
       private bool KiemTraTenMonHoc(string tenmonhoc)
       {
           bool kq = false;
           try
           {
               if (tenmonhoc == qlsv_dMonHoc.LayTenMonHoc(TENMONHOC))
               {
                   kq = true;
                   MessageBox.Show("Môn học này đã có trong danh sách");
               }
               else
                   kq = false;
           }
           catch
           {
               MessageBox.Show("Có lỗi khi thực hiện");
           }
           return kq;
       }

       private bool KiemTraSoTietHoc()
       {
           bool kq = false;
           if(TONGSOTIET == SOTIETLYTHUYET + SOTIETTHUCHANH) 
           {
                 kq = true;
                 
           }
           else
           {
                kq = false;
                MessageBox.Show("Phân bố tiết học không hợp lý! Vui lòng kiểm tra lại");
           }
           return kq;
       }

       public void GoiYTimMH()
       {
           qlsv_dMonHoc.GoiYTimKiemMH(TXTTIMKIEM, COLUMN);
       }

       public DataTable TimKiemMH()
       {
           DataTable dt = new DataTable();
           dt = qlsv_dMonHoc.TimKiemMonHoc(COTTIMKIEM, DKTIm);
           return dt;
       }
    }
}
