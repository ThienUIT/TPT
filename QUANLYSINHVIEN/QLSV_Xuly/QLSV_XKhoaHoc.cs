using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
  public  class QLSV_XKhoaHoc
    {
        QLSV_DKhoaHoc qlsv_dKhoaHoc = new QLSV_DKhoaHoc();

        private string Makhoahoc;
        private string Ghichu;
        private string Tenkhoahoc;
        private DateTime Ngaybatdau;
        private DateTime Ngayketthuc;

        public string MAKHOAHOC
        {
            get { return Makhoahoc; }
            set { Makhoahoc = value; }
        }
        
        public string TENKHOAHOC
        {
            get { return Tenkhoahoc; }
            set { Tenkhoahoc = value; }
        }
       
        public DateTime NGAYBATDAU
        {
            get { return Ngaybatdau; }
            set { Ngaybatdau = value; }
        }
       
        public DateTime NGAYKETTHUC
        {
            get { return Ngayketthuc; }
            set { Ngayketthuc = value; }
        }
        public string GHICHU
        {
            get { return Ghichu; }
            set { Ghichu = value; }
        }

        public void ThemKhoaHoc()
        {
            try
            {
                qlsv_dKhoaHoc.ThemKhoaHoc(MAKHOAHOC, TENKHOAHOC, NGAYBATDAU, NGAYKETTHUC, GHICHU);
            }
            catch
            { 
                
            }
          
        }

        public void CapNhatKhoaHoc()
        {
            try
            {
                qlsv_dKhoaHoc.CapNhatKhoaHoc(MAKHOAHOC, TENKHOAHOC, NGAYBATDAU, NGAYKETTHUC, GHICHU);
            }
            catch
            {

            }

        }
        public void XoaKhoaHoc()
        {
            try
            {
                qlsv_dKhoaHoc.XoaKhoaHoc(MAKHOAHOC);
            }
            catch
            {

            }

        }

        public DataTable LoadDLKhoaHoc()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dKhoaHoc.LoadDL();
            return dt;
        }

        public string TaoMaKhoaHoc()
        {
            string ma = "";
            ma = qlsv_dKhoaHoc.TaoMaKhoaHoc();
            return ma;
        }
    }
}
