using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QLSV_Database
{
    public class QLSV_DXemDiem
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

        public DataTable XemDiem(string masv)
        {
            DataTable dt = new DataTable();
          
            string strSQL;
            strSQL = "  SELECT        MonHoc.TenMonHoc,MonHoc.SoTinChi,SinhVien.Hoten, Diem.DiemLanI, Diem.DiemLanII, Diem.LanThi, Diem.NgayThi, Diem.GhiChu ";
                   strSQL +=" FROM  Diem INNER JOIN";
                   strSQL += " MonHoc ON Diem.MaMonHoc = MonHoc.MaMonHoc INNER JOIN SinhVien ON   Diem.MaSV = SinhVien.MaSinhVien and Sinhvien.MaSinhVien = '" + masv + "'";
            dt = cThaotacchung.Reports(strSQL,"Diem");

            
            return dt;
        }
    }
}
