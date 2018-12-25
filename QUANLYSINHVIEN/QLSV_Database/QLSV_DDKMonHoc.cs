using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV_Database
{
    public class QLSV_DDKMonHoc
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

        SqlParameter _MaMH = new SqlParameter();
        SqlParameter _MaSV = new SqlParameter();
        SqlParameter _NgayDK = new SqlParameter();
        SqlParameter _SoTC = new SqlParameter();
        SqlParameter _Hocky = new SqlParameter();
        

        public void ThemDKMonHoc(string mamh, string masv, DateTime ndk, int sotc, int hocky)
        {
            _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _MaSV.SqlValue = masv;
            _MaSV.ParameterName = "@MaSinhVien";

            _NgayDK.SqlValue = ndk;
            _NgayDK.ParameterName = "@NgayDangKy";

            _SoTC.SqlValue = sotc;
            _SoTC.ParameterName = "@SoTinChi";

            _Hocky.SqlValue = hocky;
            _Hocky.ParameterName = "@HocKy";

            
            cThaotacchung.ThaoTacDuLieu("qlsv_ThemDKMonHoc", CommandType.StoredProcedure, _MaMH, _MaSV, _NgayDK, _SoTC, _Hocky);
           
        }

        public void CapNhatDKMonHoc(string mamh, string masv, DateTime ndk, int sotc, int hocky)
        {
            _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _MaSV.SqlValue = masv;
            _MaSV.ParameterName = "@MaSinhVien";

            _NgayDK.SqlValue = ndk;
            _NgayDK.ParameterName = "@NgayDangKy";

            _SoTC.SqlValue = sotc;
            _SoTC.ParameterName = "@SoTinChi";

            _Hocky.SqlValue = hocky;
            _Hocky.ParameterName = "@HocKy";


            cThaotacchung.ThaoTacDuLieu("qlsv_CapNhatDKMonHoc", CommandType.StoredProcedure, _MaMH, _MaSV, _NgayDK, _SoTC, _Hocky);

        }

        public void XoaDKMonHoc(string mamh, string masv)
        {
            _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _MaSV.SqlValue = masv;
            _MaSV.ParameterName = "@MaSinhVien";

            cThaotacchung.ThaoTacDuLieu("qlsv_XoaDKMonHoc", CommandType.StoredProcedure, _MaMH, _MaSV);
        }

        public DataTable LoadDL_DKMonHoc()
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from DK_MonHoc");
            return dt;
        }

        public DataTable TimKiemMHDK(string MaSV)
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from DK_MonHoc where MaSinhVien = '" + MaSV + "'");
            return dt;
        }

        public void LoadDLVaoCombobox(ComboBox cmb)
        {
            cThaotacchung.LoadDLVaoCombobox("Select * from MonHoc", cmb, "TenMonHoc", "MaMonHoc");
        }

        public void GoiYTimKiem(TextBox txt)
        {
            cThaotacchung.TextBox_AutoComplete(txt, "DK_MonHoc", 1);
        }

        public void GoiYTimMSSV(TextBox txt)
        {
            cThaotacchung.TextBox_AutoComplete(txt, "SinhVien", 0);    
        }

         public string LayTenSV(string Masv)
       {
           string ten = "";
           ten = cThaotacchung.LayTen("Select Hoten from SinhVien Where MaSinhVien = '" + Masv + "'");
           return ten;
       }
    }
}
