using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
   public class QLSV_DGiaoVien
    {
       c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

       SqlParameter _Magiaovien = new SqlParameter();
       SqlParameter _Tengiaovien = new SqlParameter();
       SqlParameter _Makhoa = new SqlParameter();
       SqlParameter _Ghichu = new SqlParameter();

       public void ThemGiaoVien(string magv, string tengv, string makhoa, string ghichu)
       {
           _Magiaovien.SqlValue = magv;
           _Magiaovien.ParameterName = "@Magiaovien";

           _Tengiaovien.SqlValue = tengv;
           _Tengiaovien.ParameterName = "@TenGiaoVien";

           _Makhoa.SqlValue = makhoa;
           _Makhoa.ParameterName = "@MaKhoa";

           _Ghichu.SqlValue = ghichu;
           _Ghichu.ParameterName = "@GhiChu";

           cThaotacchung.ThaoTacDuLieu("qlsv_ThemGiaoVien", CommandType.StoredProcedure, _Magiaovien, _Tengiaovien, _Makhoa, _Ghichu);
       }

       public void CapNhatGiaoVien(string magv, string tengv, string makhoa, string ghichu)
       {
           _Magiaovien.SqlValue = magv;
           _Magiaovien.ParameterName = "@Magiaovien";

           _Tengiaovien.SqlValue = tengv;
           _Tengiaovien.ParameterName = "@TenGiaoVien";

           _Makhoa.SqlValue = makhoa;
           _Makhoa.ParameterName = "@MaKhoa";

           _Ghichu.SqlValue = ghichu;
           _Ghichu.ParameterName = "@GhiChu";

           cThaotacchung.ThaoTacDuLieu("qlsv_CapNhatGiaoVien", CommandType.StoredProcedure, _Magiaovien, _Tengiaovien, _Makhoa, _Ghichu);
       }

       public void XoaGiaoVien(string magv)
       {
           _Magiaovien.SqlValue = magv;
           _Magiaovien.ParameterName = "@Magiaovien";

           cThaotacchung.ThaoTacDuLieu("qlsv_XoaGiaoVien", CommandType.StoredProcedure, _Magiaovien);
       }

       public DataTable LoadDL_GiaoVien()
       {
           DataTable dt = new DataTable();
           dt = cThaotacchung.LayDanhSach("Select * from GiaoVien");
           return dt;
       }

       public string TaoMaGiaoVien()
       {
           string ma = "";
           ma = cThaotacchung.SinhMaTuDong("GV", "Select * from GiaoVien");
           return ma;
       }

       public void LayDLVaoCombobox_MaKhoa(ComboBox cmb)
       {
           cThaotacchung.LoadDLVaoCombobox("Select * from Khoa", cmb, "TenKhoa", "MaKhoa");

       }

       public DataTable TimKiemGiaoVien(string columnName,string DuLieuTim)
       {
           DataTable dt = new DataTable();
           dt = cThaotacchung.LayDanhSach("Select * from GiaoVien where " + columnName + " = N'" + DuLieuTim +"'");
           return dt;
       }

       public void GoiYTimKiem(TextBox txt, int column)
       {
           cThaotacchung.TextBox_AutoComplete(txt, "GiaoVien", column);
       }
    }
}
