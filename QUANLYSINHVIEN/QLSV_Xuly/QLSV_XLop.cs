using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
    public class QLSV_XLop
    {
        QLSV_DLop qlsv_dLop = new QLSV_DLop();

        private string Malop;
        private ComboBox cmbMaNganh;
        private string Makhoahoc;
        private string Manganh;
        private string Tenlop;
        private string Ghichu;
        private ComboBox cmbMaKhoaHoc;

        private string CotTimKiem;
        private string DKTim;
        private int cotGoiY;
        private TextBox txtGoiy;

        public TextBox TXTGOIY
        {
            get { return txtGoiy; }
            set { txtGoiy = value; }
        }

        public int COTGOIY
        {
            get { return cotGoiY; }
            set { cotGoiY = value; }
        }


        public string COTIMKIEM
        {
            get { return CotTimKiem; }
            set { CotTimKiem = value; }
        }
       

        public string DKTIM
        {
            get { return DKTim; }
            set { DKTim = value; }
        }
        public string MALOP
        {
            get { return Malop; }
            set { Malop = value; }
        }
        

        public string MAKHOAHOC
        {
            get { return Makhoahoc; }
            set { Makhoahoc = value; }
        }
        

        public string MANGANH
        {
            get { return Manganh; }
            set { Manganh = value; }
        }
        

        public string TENLOP
        {
            get { return Tenlop; }
            set { Tenlop = value; }
        }
        

        public string GHICHU
        {
            get { return Ghichu; }
            set { Ghichu = value; }
        }
        

        public ComboBox cmbMAKHOAHOC
        {
            get { return cmbMaKhoaHoc; }
            set { cmbMaKhoaHoc = value; }
        }
        

        public ComboBox cmbMANGANH
        {
            get { return cmbMaNganh; }
            set { cmbMaNganh = value; }
        }

        public void ThemLop()
        {
            try
            {
                qlsv_dLop.ThemLop(MALOP, MAKHOAHOC, MANGANH, TENLOP, GHICHU);
            }
            catch

            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }
            
        }
        public void CapNhatLop()
        {
            try
            {
                qlsv_dLop.CapNhatLop(MALOP, MAKHOAHOC, MANGANH, TENLOP, GHICHU);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public void XoaLop()
        {
            try
            {
                qlsv_dLop.XoaLop(MALOP);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thực hiện! ");
            }

        }

        public DataTable LoadDL_dgvLop()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dLop.LoadDL();
            return dt;
        }

        public string TaoMaLop()
        {
            string ma = "";
            ma = qlsv_dLop.TaoMaLop();
            return ma;
        }

        public void LoadDLVaoCombobox_MaKhoaHoc()
        {
            qlsv_dLop.LayDLVaoCombobox_MaKhoaHoa(cmbMAKHOAHOC);
        }

        public void LoadDLVaoCombobox_MaNganh()
        {
            qlsv_dLop.LayDLVaoCombobox_MaNganh(cmbMANGANH);
        }

        public DataTable TimKiemLop()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dLop.TimKiemLop(COTIMKIEM, DKTIM);
            return dt;
        }

        public void GoiYTimKiem()
        {
            qlsv_dLop.GoiYTimKiem(TXTGOIY, COTGOIY);
        }
    }
}
