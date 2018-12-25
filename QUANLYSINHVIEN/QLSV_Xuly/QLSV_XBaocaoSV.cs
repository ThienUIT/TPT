using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLSV_Database;

namespace QLSV_Xuly
{
   public class QLSV_XBaocaoSV
    {

       QLSV_DBaocaoSV baocaosv = new QLSV_DBaocaoSV();

       private string malop;
       private string makhoahoc;
       private ComboBox cmb;

       public ComboBox CMB
       {
           get { return cmb; }
           set { cmb = value; }
       }
       public string MAKHOAHOC
       {
           get { return makhoahoc; }
           set { makhoahoc = value; }
       }
       public string MALOP
       {
           get { return malop; }
           set { malop = value; }
       }


       public DataTable BaoCaoSV()
       {
           DataTable dt = new DataTable();
           dt = baocaosv.BaoCaoSV(MALOP,MAKHOAHOC);
               return dt;
       }

       public void LayDLVaocmbLop()
       {
           baocaosv.LayDLLencmbLop(CMB, MAKHOAHOC);
       }
    }
}
