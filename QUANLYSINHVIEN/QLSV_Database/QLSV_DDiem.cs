using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QLSV_Database
{
   public class QLSV_DDiem
    {

        c_ThaoTacChung cthaotacchung = new c_ThaoTacChung();
        SqlParameter _MaMH = new SqlParameter();
        SqlParameter _Masv = new SqlParameter();
        SqlParameter _DiemlanI = new SqlParameter();
        SqlParameter _DiemlanII = new SqlParameter();
        SqlParameter _Lanthi = new SqlParameter();
        SqlParameter _Ngaythi = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();
       
        public DataTable LayDuLieuKhoa()
        {
            DataTable dt = new DataTable();

            dt = cthaotacchung.LayDanhSach("Select * from Khoa");
            return dt;
        }

      

        public void NhapDiem(string mamh, string masv, float dlanI, float dlanII, int lanthi, DateTime ngaythi, string ghichu)
        {
            _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _Masv.SqlValue = masv;
            _Masv.ParameterName = "@MaSV";

            _DiemlanI.SqlValue = dlanI;
            _DiemlanI.ParameterName = "@DiemLanI";

            _DiemlanII.SqlValue = dlanII;
            _DiemlanII.ParameterName = "@DiemLanII";

            _Lanthi.SqlValue = lanthi;
            _Lanthi.ParameterName = "@LanThi";

            _Ngaythi.SqlValue = ngaythi;
            _Ngaythi.ParameterName = "@NgayThi";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            cthaotacchung.ThaoTacDuLieu("qlsv_NhapDiem", CommandType.StoredProcedure, _MaMH, _Masv, _DiemlanI, _DiemlanII, _Lanthi, _Ngaythi, _Ghichu);

        }

        public DataTable LayDLDiem()
        {
            DataTable dt = new DataTable();
            dt = cthaotacchung.LayDanhSach("Select * from Diem");
            return dt;
        }
        public void XoaDiem(string MaMH, String MaSV)
        { 
             _MaMH.SqlValue = MaMH;
            _MaMH.ParameterName = "@MaMonHoc";

            _Masv.SqlValue = MaSV;
            _Masv.ParameterName = "@MaSV";

            cthaotacchung.ThaoTacDuLieu("qlsv_XoaDiem", CommandType.StoredProcedure, _MaMH, _Masv);
        }

        public void CapNhatDiem(string mamh, string masv, float dlanI, float dlanII, int lanthi, DateTime ngaythi, string ghichu)
        {
            _MaMH.SqlValue = mamh;
            _MaMH.ParameterName = "@MaMonHoc";

            _Masv.SqlValue = masv;
            _Masv.ParameterName = "@MaSV";

            _DiemlanI.SqlValue = dlanI;
            _DiemlanI.ParameterName = "@DiemLanI";

            _DiemlanII.SqlValue = dlanII;
            _DiemlanII.ParameterName = "@DiemLanII";

            _Lanthi.SqlValue = lanthi;
            _Lanthi.ParameterName = "@LanThi";

            _Ngaythi.SqlValue = ngaythi;
            _Ngaythi.ParameterName = "@NgayThi";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            cthaotacchung.ThaoTacDuLieu("qlsv_CapNhatDiem", CommandType.StoredProcedure, _MaMH, _Masv, _DiemlanI, _DiemlanII, _Lanthi, _Ngaythi, _Ghichu);
        }

        public DataTable TimKiemDiem(string masv)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt = cthaotacchung.LayDanhSach("Select * from Diem where MaSv = '" + masv + "'");
            return dt;
        }

       //lấy danh sách môn học vào listbox
        public void LoadDLVaoListBox(ListBox lb, string makhoa)
        {
            
            try
            {
                lb.DataSource = cthaotacchung.LayDanhSach("Select * from MonHoc where MaKhoa = '" + makhoa + "'");
                lb.DisplayMember = "TenMonHoc";
                lb.ValueMember = "MaMonHoc";
            }
            catch
            {
                MessageBox.Show("Có lỗi khi lấy danh sách môn học");
            }
        }

       //Tạo từ gợi ý khi tìm kiếm
        public void GoiYMaSinhVien(TextBox txt)
        {
            cthaotacchung.TextBox_AutoComplete(txt, "SinhVien", 0);
        }
        //public DataTable LayDanhSachMonHoc(string MaKhoa)
        //{
        //    DataTable dt = new DataTable();

        //    dt = cthaotacchung.LayDanhSach("Select * from MonHoc where MaKhoa = '" + MaKhoa + "'");
        //    return dt;
        //}
    }

}
