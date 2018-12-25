using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
    public class QLSV_XKhoa
    {
        QLSV_DKhoa qlsv_dKhoa = new QLSV_DKhoa();

        private string Makhoa;
        private string Ghichu;
        private string Tenkhoa;

        public string MAKHOA
        {
            get { return Makhoa; }
            set { Makhoa = value; }
        }
       

        public string TENKHOA
        {
            get { return Tenkhoa; }
            set { Tenkhoa = value; }
        }
        
        public string GHICHU
        {
            get { return Ghichu; }
            set { Ghichu = value; }
        }

        public void ThemKhoa()
        {
            try
            {
                qlsv_dKhoa.ThemKhoa(MAKHOA, TENKHOA, GHICHU);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public void CapNhatKhoa()
        {
            try
            {
                qlsv_dKhoa.CapNhatKhoa(MAKHOA, TENKHOA, GHICHU);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public void XoaKhoa()
        {
            try
            {
                qlsv_dKhoa.XoaKhoa(MAKHOA);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện !");
            }
        }

        public DataTable LoadDLKhoa()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dKhoa.LoadDLKhoa();
            return dt;

        }
        public string TaoMaKhoa()
        {
            string ma;
            ma = qlsv_dKhoa.TaoMaKhoa();
            return ma;
        }
    }
}
