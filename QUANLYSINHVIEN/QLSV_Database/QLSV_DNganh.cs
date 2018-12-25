using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
    public class QLSV_DNganh
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();

        SqlParameter _MaNganh = new SqlParameter();
        SqlParameter _TenNganh = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();

        public void ThemNganh(string manganh, string tennganh, string ghichu)
        {
            _MaNganh.SqlValue = manganh;
            _MaNganh.ParameterName = "@MaNganh";

            _TenNganh.SqlValue = tennganh;
            _TenNganh.ParameterName = "@TenNganh";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@Ghichu";

            cThaotacchung.ThaoTacDuLieu("qlsv_ThemNganh", CommandType.StoredProcedure, _MaNganh,  _TenNganh, _Ghichu);
            
        }
        public void CapNhatNganh(string manganh, string tennganh, string ghichu)
        {
            _MaNganh.SqlValue = manganh;
            _MaNganh.ParameterName = "@MaNganh";

            _TenNganh.SqlValue = tennganh;
            _TenNganh.ParameterName = "@TenNganh";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@Ghichu";

            cThaotacchung.ThaoTacDuLieu("qlsv_CapNhatNganh", CommandType.StoredProcedure, _MaNganh, _TenNganh, _Ghichu);

        }

        public void XoaNganh(string manganh)
        {
            _MaNganh.SqlValue = manganh;
            _MaNganh.ParameterName = "@MaNganh";

            cThaotacchung.ThaoTacDuLieu("qlsv_XoaNganh", CommandType.StoredProcedure, _MaNganh);
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from Nganh");
            
            return dt;
        }

        public string TaoMaNganh()
        {
            string maNG = "";
            maNG = cThaotacchung.SinhMaTuDong("NG", "Select * from Nganh");
            return maNG;
        }
    }
}
