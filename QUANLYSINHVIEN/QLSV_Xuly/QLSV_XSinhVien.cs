using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSV_Database;
using System.Windows.Forms;
using System.Data;
namespace QLSV_Xuly
{
    public class QLSV_XSinhVien
    {
        QLSV_DSinhVien qlsv_dSV = new QLSV_DSinhVien();
        c_ThaoTacChung ctc = new c_ThaoTacChung();

        private string MaSV;
        private string hoten;
        private string quequan;
        private DateTime NgaySinh;
        private string noisinh;
        private string gioitinh;
        private string Malop;
        private string Hinh;
        private string Ghichu;

        private string table = "SinhVien";
        private int column;
        private TextBox txt;
        private string field;
        private string DKTim;
        private ComboBox cmb;

        public ComboBox CMB
        {
            get { return cmb; }
            set { cmb = value; }
        }

        public String FIELD
        {
            get { return field; }
            set { field = value; }
        }
       

        public string DKTIM
        {
            get { return DKTim; }
            set { DKTim = value; }
        }
        public int COLUMN
        {
            get { return column; }
            set { column = value; }
        }
       

        public TextBox TXT//tìm kiếm
        {
            get { return txt; }
            set { txt = value; }
        }
        public string MASV
        {
            get { return MaSV; }
            set 
            { 
                    
                MaSV = value;
                if (this.MASV == "")
                {
                    MessageBox.Show("Chưa nhập mã số sinh viên! ");
                    return;
                }
            }
        }
       
        public string HOTEN
        {
            get { return hoten; }
            set 
            {
                hoten = value;

                if (this.HOTEN == "")
                {
                    MessageBox.Show("Chưa nhập họ tên sinh viên! ");
                    return;
                }
                else { hoten = ctc.ChuanHoaString(hoten); }
            }
           
      
        }
       

        public string QUEQUAN
        {
            get { return quequan; }
            set
            {
                quequan = value;
               
                if (this.QUEQUAN == "")
                {
                    MessageBox.Show("Chưa nhập quê quán! ");
                    return;
                }
                else { ctc.ChuanHoaString(quequan); }
                
            }
          
        }
        public string NOISINH
        {
            get { return noisinh; }
            set
            {
                noisinh = value;
               
                if (this.NOISINH == "")
                {
                    MessageBox.Show("Chưa nhập nơi sinh! ");
                    return;
                }
                else { ctc.ChuanHoaString(noisinh); }
            }
        }

        public DateTime NGAYSINH
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
       

        public string GIOITINH
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
       

        public string MALOP
        {
            get { return Malop; }
            set 
            
            { 
                
                Malop = value;
                if (MALOP == "")
                {
                    MessageBox.Show("Vui lòng Chọn Mã lớp!");
                    return;
                }
            }
        }
        

        public string HINH
        {
            get { return Hinh; }
            set { Hinh = value; }
        }
       

        public string GHICHU
        {
            get { return Ghichu; }
            set { Ghichu = value; }
        }

        public void ThemSinhVien()
        {
            qlsv_dSV.ThemSinhVien(MASV, HOTEN, QUEQUAN, NGAYSINH, NOISINH, GIOITINH, MALOP, HINH, GHICHU);
        }

        public void CapNhatSinhVien()
        {
            qlsv_dSV.CapNhatSinhVien(MASV, HOTEN, QUEQUAN, NGAYSINH, NOISINH, GIOITINH, MALOP, HINH, GHICHU);
        }

        public void XoaSinhVien()
        {
            qlsv_dSV.XoaSinhVien(MASV);
        }

        public string TaoMaSinhVien()
        {
           string msv = qlsv_dSV.TaoMaSinhVien();
           return msv;
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dSV.LoadDL();
            return dt;
        }

        public void TextBoxAutoComplete()
        {
            ctc.TextBox_AutoComplete(TXT, table, COLUMN);
        }

        public DataTable TimKiemSV()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dSV.TimKiemSV(FIELD,DKTIM);
            return dt;
        }

        public void LayDLVaoComboboxMaLop()
        {
            qlsv_dSV.LayMaLopVaoComBoboxMaLop(cmb);
        }
    }
}
