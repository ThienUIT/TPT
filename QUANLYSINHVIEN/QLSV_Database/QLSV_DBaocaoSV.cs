using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace QLSV_Database
{
   public class QLSV_DBaocaoSV
    {
       c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

       //Xuất ds sinh viên theo lớp
       public DataTable BaoCaoSV(string malop, string makhoa)
       {
           DataTable dt = new DataTable();
           string strSQL = "SELECT KhoaHoc.TenKhoaHoc, Lop.TenLop, SinhVien.Hoten, SinhVien.MaSinhVien, SinhVien.QueQuan, SinhVien.NgaySinh, SinhVien.NoiSinh, SinhVien.GioiTinh ";
                  strSQL +="FROM  KhoaHoc INNER JOIN ";
                  strSQL +="Lop ON KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc and Lop.MaKhoaHoc = '" + makhoa + "' INNER JOIN ";
                  strSQL += "SinhVien ON Lop.MaLop = SinhVien.MaLop and SinhVien.MaLop = '" + malop + "'";
           dt = cThaotacchung.Reports(strSQL,"SinhVien");
           return dt;
       }

        //lấy dữ liệu vào combobox cmbLop để xuất danh sách sinh viên
       public void LayDLLencmbLop(ComboBox cmb, string makhoahoc)
       {
           cThaotacchung.LoadDLVaoCombobox("Select * from Lop Where Makhoahoc = '" + makhoahoc + "'", cmb, "TenLop", "MaLop");
       }
    }
}
