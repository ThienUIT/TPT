using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;
namespace QLSV_Xuly
{
    public class QLSV_XNganh
    {
        QLSV_DNganh qlsv_dNganh = new QLSV_DNganh();

        private string Manganh;
        private string Tennganh;
        private string Ghichu;

        public string MANGANH
        {
            get { return Manganh; }
            set { Manganh = value; }
        }

        public string TENNGANH
        {
            get { return Tennganh; }
            set { Tennganh = value; }
        }
        

        public string GHICHU
        {
            get { return Ghichu; }
            set { Ghichu = value; }
        }
        

        public void ThemNganh()
        {
            try
            {
                qlsv_dNganh.ThemNganh(MANGANH, TENNGANH, GHICHU);
            }
            catch
            { 
                
            }
        }

        public void CapNhatNganh()
        {
            try
            {
                qlsv_dNganh.CapNhatNganh(MANGANH, TENNGANH, GHICHU);
            }
            catch
            {

            }
        }

        public void XoaNganh()
        {
            try
            {
                qlsv_dNganh.XoaNganh(MANGANH);
            }
            catch
            {

            }
        }

        public DataTable LoadDL()
        {
            DataTable dt = new DataTable();
            try
            {
                
                dt = qlsv_dNganh.LoadDL();
            }
            catch

            { 
            
            }
            return dt;
        }

        public string TaoMaNganh()
        { 
         
            string maNG = "";
            maNG = qlsv_dNganh.TaoMaNganh();
            return maNG;
      
        }
    }
}
