using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
    public class QLSV_DKhoa
    {
        c_ThaoTacChung cThaoTacchung = new c_ThaoTacChung();

        SqlParameter _MaKhoa = new SqlParameter();
        SqlParameter _TenKhoa = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();

        public void ThemKhoa(string makhoa, string tenkhoa, string ghichu)
        {
            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            _TenKhoa.SqlValue = tenkhoa;
            _TenKhoa.ParameterName = "@TenKhoa";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            cThaoTacchung.ThaoTacDuLieu("qlsv_ThemKhoa", CommandType.StoredProcedure, _MaKhoa, _TenKhoa, _Ghichu);
        }

       

        public void CapNhatKhoa(string makhoa, string tenkhoa, string ghichu)
        {
            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            _TenKhoa.SqlValue = tenkhoa;
            _TenKhoa.ParameterName = "@TenKhoa";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            cThaoTacchung.ThaoTacDuLieu("qlsv_CapNhatKhoa", CommandType.StoredProcedure, _MaKhoa, _TenKhoa, _Ghichu);
        }

        public void XoaKhoa(string makhoa)
        {
            _MaKhoa.SqlValue = makhoa;
            _MaKhoa.ParameterName = "@MaKhoa";

            cThaoTacchung.ThaoTacDuLieu("qlsv_XoaKhoa", CommandType.StoredProcedure, _MaKhoa);
        }

        public DataTable LoadDLKhoa()
        {
            DataTable dt = new DataTable();
            dt = cThaoTacchung.LayDanhSach("Select * from Khoa");
            return dt;
        }

        public string TaoMaKhoa()
        {
            string ma;
            ma = cThaoTacchung.SinhMaTuDong("KA", "Select * from Khoa");
            return ma;
        }
    }
}
