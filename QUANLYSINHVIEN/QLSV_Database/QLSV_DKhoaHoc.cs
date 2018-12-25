using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
  public class QLSV_DKhoaHoc
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

        SqlParameter _MaKhoaHoc = new SqlParameter();
        SqlParameter _TenKhoaHoc = new SqlParameter();
        SqlParameter _NgayBatDau = new SqlParameter();
        SqlParameter _NgayKetThuc = new SqlParameter();
        SqlParameter _GhiChu = new SqlParameter();

        public void ThemKhoaHoc(string MaKH, string TenKH, DateTime ngaybatdau, DateTime ngayketthuc, string ghichu)
        {
            _MaKhoaHoc.SqlValue = MaKH;
            _TenKhoaHoc.SqlValue = TenKH;
            _NgayBatDau.SqlValue = ngaybatdau;
            _NgayKetThuc.SqlValue = ngayketthuc;
            _GhiChu.SqlValue = ghichu;

            _MaKhoaHoc.ParameterName = "@MaKhoaHoc";
            _TenKhoaHoc.ParameterName = "@TenKhoaHoc";
            _NgayBatDau.ParameterName = "@NgayBatDau";
            _NgayKetThuc.ParameterName = "@NgayKetThuc";
            _GhiChu.ParameterName = "@GhiChu";

            cThaotacchung.ThaoTacDuLieu("qlsv_ThemKhoaHoc", CommandType.StoredProcedure, _MaKhoaHoc, _TenKhoaHoc, _NgayBatDau, _NgayKetThuc, _GhiChu);
        }

        public void CapNhatKhoaHoc(string MaKH, string TenKH, DateTime ngaybatdau, DateTime ngayketthuc, string ghichu)
        {
            _MaKhoaHoc.SqlValue = MaKH;
            _TenKhoaHoc.SqlValue = TenKH;
            _NgayBatDau.SqlValue = ngaybatdau;
            _NgayKetThuc.SqlValue = ngayketthuc;
            _GhiChu.SqlValue = ghichu;

            _MaKhoaHoc.ParameterName = "@MaKhoaHoc";
            _TenKhoaHoc.ParameterName = "@TenKhoaHoc";
            _NgayBatDau.ParameterName = "@NgayBatDau";
            _NgayKetThuc.ParameterName = "@NgayKetThuc";
            _GhiChu.ParameterName = "@GhiChu";

            cThaotacchung.ThaoTacDuLieu("qlsv_CapNhatKhoaHoc", CommandType.StoredProcedure, _MaKhoaHoc, _TenKhoaHoc, _NgayBatDau, _NgayKetThuc, _GhiChu);
        }

        public void XoaKhoaHoc(string MaKH)
        {
            _MaKhoaHoc.SqlValue = MaKH;
            _MaKhoaHoc.ParameterName = "@MaKhoaHoc";

            cThaotacchung.ThaoTacDuLieu("qlsv_XoaKhoaHoc", CommandType.StoredProcedure, _MaKhoaHoc);
        }

      //Hàm load dl vao datagridview
        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from KhoaHoc");
            return dt;
        }

        public string TaoMaKhoaHoc()
        {
            string ma = "";
            ma = cThaotacchung.SinhMaTuDong("KH", "Select * from KhoaHoc");
            return ma;
        }

      

    }
}
