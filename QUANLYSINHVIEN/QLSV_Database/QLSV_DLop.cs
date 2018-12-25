using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLSV_Database
{
    public class QLSV_DLop
    {
        c_ThaoTacChung cThaotacchung = new c_ThaoTacChung();


        SqlParameter _Malop = new SqlParameter();
        SqlParameter _Makhoahoc = new SqlParameter();
        SqlParameter _Manganh = new SqlParameter();
        SqlParameter _Tenlop = new SqlParameter();
        SqlParameter _Ghichu = new SqlParameter();

        public void ThemLop(string malop, string makhoahoc, string manganh, string tenlop, string ghichu)
        {
            _Malop.SqlValue = malop;
            _Malop.ParameterName = "@Malop";

            _Manganh.SqlValue = manganh;
            _Manganh.ParameterName = "@MaNganh";

            _Makhoahoc.SqlValue = makhoahoc;
            _Makhoahoc.ParameterName = "@MaKhoaHoc";

            _Tenlop.SqlValue = tenlop;
            _Tenlop.ParameterName = "@TenLop";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            cThaotacchung.ThaoTacDuLieu("qlsv_ThemLop", CommandType.StoredProcedure, _Malop, _Makhoahoc, _Manganh, _Tenlop, _Ghichu);


        }

        public void CapNhatLop(string malop, string makhoahoc, string manganh, string tenlop, string ghichu)
        {
            _Malop.SqlValue = malop;
            _Malop.ParameterName = "@Malop";

            _Manganh.SqlValue = manganh;
            _Manganh.ParameterName = "@MaNganh";

            _Makhoahoc.SqlValue = makhoahoc;
            _Makhoahoc.ParameterName = "@MaKhoaHoc";

            _Tenlop.SqlValue = tenlop;
            _Tenlop.ParameterName = "@TenLop";

            _Ghichu.SqlValue = ghichu;
            _Ghichu.ParameterName = "@GhiChu";

            cThaotacchung.ThaoTacDuLieu("qlsv_CapNhatLop", CommandType.StoredProcedure, _Malop, _Makhoahoc, _Manganh, _Tenlop, _Ghichu);


        }

        public void XoaLop(string malop)
        {
            _Malop.SqlValue = malop;
            _Malop.ParameterName = "@Malop";
            cThaotacchung.ThaoTacDuLieu("qlsv_XoaLop", CommandType.StoredProcedure, _Malop);

        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from Lop");
            return dt;
        }

        public string TaoMaLop()
        {
            string ma;
            ma = cThaotacchung.SinhMaTuDong("LP", "Select * from Lop");
            return ma;
        }

        public void LayDLVaoCombobox_MaKhoaHoa(ComboBox cmb)
        {
            cThaotacchung.LoadDLVaoCombobox("Select * from KhoaHoc", cmb, "TenKhoaHoc", "MaKhoaHoc");
        }

        public void LayDLVaoCombobox_MaNganh(ComboBox cmb)
        {
            cThaotacchung.LoadDLVaoCombobox("Select * from Nganh", cmb, "TenNganh", "MaNganh");
        }

        public DataTable TimKiemLop(string cotTim, string DKTim)
        {
            DataTable dt = new DataTable();
            dt = cThaotacchung.LayDanhSach("Select * from Lop Where " + cotTim + " = '" + DKTim + "'");
            return dt;
        }

        public void GoiYTimKiem(TextBox txt,int column)
        {
            cThaotacchung.TextBox_AutoComplete(txt, "Lop", column);
        }

    }
}
