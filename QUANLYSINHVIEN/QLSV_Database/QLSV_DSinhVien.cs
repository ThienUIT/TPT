using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSV_Database;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QLSV_Database
{
    
   public class QLSV_DSinhVien
    {
        c_DataProvider conn = new c_DataProvider();
        c_ThaoTacChung ctc = new c_ThaoTacChung();


            SqlParameter _Msv = new SqlParameter();
            SqlParameter _tensv = new SqlParameter();
            SqlParameter _quequan = new SqlParameter();
            SqlParameter _ngaysinh = new SqlParameter();
            SqlParameter _NoiSinh = new SqlParameter();
            SqlParameter _GioiTinh = new SqlParameter();
            SqlParameter _MaLop = new SqlParameter();
            SqlParameter _Hinh = new SqlParameter();
            SqlParameter _GhiChu = new SqlParameter();


        public void ThemSinhVien(String MaSv, String Hoten, String Quequan, DateTime Ngaysinh, string noisinh, string gioitinh, string malop, string hinh, string ghichu)
        {
           

            _Msv.SqlValue = MaSv;
            _Msv.ParameterName = "@MaSinhVien";

            _tensv.SqlValue = Hoten;
            _tensv.ParameterName = "@Hoten";

            _quequan.SqlValue = Quequan;
            _quequan.ParameterName = "@QueQuan";

            _ngaysinh.SqlValue = Ngaysinh;
            _ngaysinh.ParameterName = "@Ngaysinh";

            _NoiSinh.SqlValue = noisinh;
            _NoiSinh.ParameterName = "@Noisinh";

            _GioiTinh.SqlValue = gioitinh;
            _GioiTinh.ParameterName = "@Gioitinh";

            _MaLop.SqlValue = malop;
            _MaLop.ParameterName = "@Malop";

            _Hinh.SqlValue = hinh;
            _Hinh.ParameterName = "@Hinh";

            _GhiChu.SqlValue = ghichu;
            _GhiChu.ParameterName = "@Ghichu";

            ctc.ThaoTacDuLieu("qlsv_ThemSinhVien", CommandType.StoredProcedure, _Msv, _tensv, _quequan, _ngaysinh, _NoiSinh, _GioiTinh, _MaLop, _Hinh, _GhiChu);
        }

        public void CapNhatSinhVien(String MaSv, String Hoten, String Quequan, DateTime Ngaysinh, string noisinh, string gioitinh, string malop, string hinh, string ghichu)
        {
            
            _Msv.SqlValue = MaSv;
            _Msv.ParameterName = "@MaSinhVien";

            _tensv.SqlValue = Hoten;
            _tensv.ParameterName = "@Hoten";

            _quequan.SqlValue = Quequan;
            _quequan.ParameterName = "@QueQuan";

            _ngaysinh.SqlValue = Ngaysinh;
            _ngaysinh.ParameterName = "@Ngaysinh";

            _NoiSinh.SqlValue = noisinh;
            _NoiSinh.ParameterName = "@Noisinh";

            _GioiTinh.SqlValue = gioitinh;
            _GioiTinh.ParameterName = "@Gioitinh";

            _MaLop.SqlValue = malop;
            _MaLop.ParameterName = "@Malop";

            _Hinh.SqlValue = hinh;
            _Hinh.ParameterName = "@Hinh";

            _GhiChu.SqlValue = ghichu;
            _GhiChu.ParameterName = "@Ghichu";

            ctc.ThaoTacDuLieu("qlsv_CapNhatSinhVien", CommandType.StoredProcedure, _Msv, _tensv, _quequan, _ngaysinh, _NoiSinh, _GioiTinh, _MaLop, _Hinh, _GhiChu);
        }

        public void XoaSinhVien(String MaSv)
        {
            
            _Msv.SqlValue = MaSv;
            _Msv.ParameterName = "@MaSinhVien";

            ctc.ThaoTacDuLieu("qlsv_XoaSinhVien", CommandType.StoredProcedure, _Msv);
        }

        public string TaoMaSinhVien()
        {
            string msv;
           msv = ctc.SinhMaTuDong("SV", "Select * from SinhVien");
           return msv;
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = ctc.LayDanhSach("Select * from SinhVien");
            return dt;
        }
       
        public DataTable TimKiemSV(string field, string DKTim)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = ctc.LayDanhSach("Select * from  SinhVien where " + field + " = N'" + DKTim + "'");
            return dt;
        }
       
        public void LayMaLopVaoComBoboxMaLop(ComboBox cmb)
        {
            ctc.LoadDLVaoCombobox("Select * from Lop", cmb, "TenLop", "MaLop");
        }

       
     
    }
}
