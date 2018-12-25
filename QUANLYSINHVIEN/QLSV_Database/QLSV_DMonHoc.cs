using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
    public class QLSV_DMonHoc
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

        SqlParameter _MaMh = new SqlParameter();
        SqlParameter _TenMh = new SqlParameter();
        SqlParameter _MaKhoa = new SqlParameter();
        SqlParameter _SoTC = new SqlParameter();
        SqlParameter _HinhThuc = new SqlParameter();
        SqlParameter _Tongsotiet = new SqlParameter();
        SqlParameter _SotietLT = new SqlParameter();
        SqlParameter _SotietTH = new SqlParameter();
        SqlParameter _GhiChu = new SqlParameter();


        public void ThemMonHoc(string mamh, string tenmh, string makhoa, int sotc, string hinhthuc, int tongsotiet, int sotietLT, int sotietTH, string ghichu)
        {
            _MaMh.SqlValue = mamh;
            _MaMh.ParameterName = "@MaMonHoc";

            _TenMh.SqlValue = tenmh;
            _TenMh.ParameterName = "@TenMonHoc";

            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            _SoTC.SqlValue = sotc;
            _SoTC.ParameterName = "@SoTinChi";

            _HinhThuc.SqlValue = hinhthuc;
            _HinhThuc.ParameterName = "@HinhThuc";

            _Tongsotiet.SqlValue = tongsotiet;
            _Tongsotiet.ParameterName = "@TongSotiet";

            _SotietLT.SqlValue = sotietLT;
            _SotietLT.ParameterName = "@SoTietLyThuyet";

            _SotietTH.SqlValue = sotietTH;
            _SotietTH.ParameterName = "@SoTietThucHanh";

            _GhiChu.SqlValue = ghichu;
            _GhiChu.ParameterName = "@Ghichu";

            cThaotacchung.ThaoTacDuLieu("qlsv_ThemMonHoc", CommandType.StoredProcedure, _MaMh, _TenMh, _MaKhoa, _SoTC, _HinhThuc, _Tongsotiet, _SotietLT, _SotietTH, _GhiChu);
        }


        public void CapNhatMonHoc(string mamh, string tenmh, string makhoa, int sotc, string hinhthuc, int tongsotiet, int sotietLT, int sotietTH, string ghichu)
        {
            _MaMh.SqlValue = mamh;
            _MaMh.ParameterName = "@MaMonHoc";

            _TenMh.SqlValue = tenmh;
            _TenMh.ParameterName = "@TenMonHoc";

            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            _SoTC.SqlValue = sotc;
            _SoTC.ParameterName = "@SoTinChi";

            _HinhThuc.SqlValue = hinhthuc;
            _HinhThuc.ParameterName = "@HinhThuc";

            _Tongsotiet.SqlValue = tongsotiet;
            _Tongsotiet.ParameterName = "@TongSotiet";

            _SotietLT.SqlValue = sotietLT;
            _SotietLT.ParameterName = "@SoTietLyThuyet";

            _SotietTH.SqlValue = sotietTH;
            _SotietTH.ParameterName = "@SoTietThucHanh";

            _GhiChu.SqlValue = ghichu;
            _GhiChu.ParameterName = "@Ghichu";

            cThaotacchung.ThaoTacDuLieu("qlsv_CapNhatMonHoc", CommandType.StoredProcedure, _MaMh, _TenMh, _MaKhoa, _SoTC, _HinhThuc, _Tongsotiet, _SotietLT, _SotietTH, _GhiChu);
        }

        public void XoaMonHoc(string mamh)
        {
            _MaMh.SqlValue = mamh;
            _MaMh.ParameterName = "@MaMonHoc";

            cThaotacchung.ThaoTacDuLieu("qlsv_XoaMonHoc", CommandType.StoredProcedure, _MaMh);
        }

        public DataTable LoadDLMonHoc()
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from MonHoc");
            return dt;
        }

        public string TaoMaMonHoc()
        {
            string ma = "";
            ma = cThaotacchung.SinhMaTuDong("MH", "Select * from MonHoc");
            return ma;
        }

        public void LoadDLVaoComboboxMaKhoa_MH(ComboBox cmb)
        {
            cThaotacchung.LoadDLVaoCombobox("Select * from Khoa", cmb, "TenKhoa", "MaKhoa");
        }


        //sử dụng cho hàm kiểm tra tên môn học đã tồn tại hay chưa bên class qlsv_xMonhoc.cs
        public string LayTenMonHoc(string Tenmonhoc)
        {
            string ten = "";
          
            ten = cThaotacchung.LayTen("Select TenMonHoc From MonHoc Where TenMonHoc ='" + Tenmonhoc + "'");
            return ten;
        }

        // tìm kiếm môn học
        public DataTable TimKiemMonHoc(string CotTim, string DKTim)
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from MonHoc where " + CotTim + " = N'" + DKTim + "'");
            return dt;
        }

        public void GoiYTimKiemMH(TextBox txt, int column)
        {
            cThaotacchung.TextBox_AutoComplete(txt, "MonHoc", column);
        }


    }
}
