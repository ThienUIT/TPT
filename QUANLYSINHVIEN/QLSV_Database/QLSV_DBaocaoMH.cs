using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QLSV_Database
{
   public class QLSV_DBaocaoMH
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

        //Xuất ds Môn học theo Khoa
        public DataTable BaoCaoMH(string makhoa)
        {
            DataTable dt = new DataTable();
            string strSQL = "SELECT        MonHoc.TenMonHoc, MonHoc.SoTinChi, MonHoc.HinhThuc, MonHoc.TongSoTiet, MonHoc.SoTietLyThuyet, MonHoc.SoTietThucHanh, Khoa.TenKhoa,MonHoc.GhiChu ";
            strSQL += "FROM  MonHoc INNER JOIN Khoa ON MonHoc.MaKhoa = Khoa.MaKhoa and Khoa.MaKhoa = '" + makhoa + "'";
            dt = cThaotacchung.Reports(strSQL, "MonHoc");
            return dt;
        }
    }
}
