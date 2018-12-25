using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSV_Database;
using System.Data;
using System.Windows.Forms;
namespace QLSV_Xuly
{
   public class QLSV_XDiem
    {
        QLSV_DDiem qlsv_dDiem = new QLSV_DDiem();

        #region Properties
        private string Makhoa;
        private string MaMH;
        private float DiemLI;
        private float DiemLII;
        private int Lanthi;
        private DateTime Ngaythi;
        private string ghichu;
        private string MaSV;
        private ListBox lb;
        private TextBox txtMSV;
        private TextBox txtTimMsv;

        public TextBox txtTIMMSV
        {
            get { return txtTimMsv; }
            set { txtTimMsv = value; }
        }
        public TextBox TXTMSV
        {
            get { return txtMSV; }
            set { txtMSV = value; }
        }

        public ListBox LISTBOX
        {
            get { return lb; }
            set { lb = value; }
        }
        public string MAMH
        {
            get { return MaMH; }
            set { MaMH = value; }
        }
       

        public string MASV
        {
            get { return MaSV; }
            set 
            { 
               
              
                MaSV = value;
            }
        }
       
        public float DIEMLANI
        {
            get { return DiemLI; }
            set 
            { 
                DiemLI = value;
               
            }
        }
       
        public float DIEMLANII
        {
            get { return DiemLII; }
            set { DiemLII = value; }
        }
        
        public int LANTHI
        {
            get { return Lanthi; }
            set { Lanthi = value; }
        }
        
        public DateTime NGAYTHI
        {
            get { return Ngaythi; }
            set { Ngaythi = value; }
        }
        

        public string GHICHU
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public string MAKHOA
        {
            get { return Makhoa; }
            set { Makhoa = value; }
        }

#endregion

        public DataTable LayDuLieuKhoa()
        {
            DataTable dt = new DataTable();
           
            dt = qlsv_dDiem.LayDuLieuKhoa();
            return dt;
        }

        //public DataTable LayDSMonHoc()
        //{
        //    DataTable dt = new DataTable();

        //    dt = qlsv_dDiem.LayDSMonHoc();
        //    return dt;
        //}

        public void NhapDiem()
        {
            try
            {
                if (MASV == "")
                {

                    MessageBox.Show("Vui lòng nhập mã số sinh viên ! ");
                    return;
                }
                qlsv_dDiem.NhapDiem(MAMH, MASV, DIEMLANI, DIEMLANII, LANTHI, NGAYTHI, GHICHU);
            }
            catch
            {
                
                MessageBox.Show("Không tồn tại sinh viên có mã số: " + MASV + ".\n Hoặc Sinh viên này đã có trong danh sách cho điểm. Vui lòng thử lại! ");
                return;
            }
           
        }

        public DataTable LayDLDiem()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dDiem.LayDLDiem();
            return dt;
        }

        public void XoaDiem()
        {
            try
            {
                qlsv_dDiem.XoaDiem(MAMH, MASV);
                MessageBox.Show("Xóa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa \n " + ex.ToString() );
            }
        }

        public void CapNhatDiem()
        {
            try
            {
                qlsv_dDiem.CapNhatDiem(MAMH, MASV, DIEMLANI, DIEMLANII, LANTHI, NGAYTHI, GHICHU);
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        public DataTable TracuuDiem()
        {
            DataTable dt = new DataTable();
            dt = qlsv_dDiem.TimKiemDiem(MASV);
            return dt;
        }

        public void LayDanhSachMonHocVaoListBox()
        {
            qlsv_dDiem.LoadDLVaoListBox(LISTBOX, MAKHOA);
        }

        public void GoiYMaSinhVien()
        {
            qlsv_dDiem.GoiYMaSinhVien(TXTMSV);
        }

       //gợi ý tìm kiếm msv
        public void GoiYTimMSV()
        {
            qlsv_dDiem.GoiYMaSinhVien(txtTIMMSV);
        }
    }
}
