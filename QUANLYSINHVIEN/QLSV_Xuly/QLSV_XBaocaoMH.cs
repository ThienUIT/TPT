using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLSV_Database;
namespace QLSV_Xuly
{
   public class QLSV_XBaocaoMH
    {
       QLSV_DBaocaoMH baocaomh = new QLSV_DBaocaoMH();

       private string makhoa;

       public string MAKHOA
       {
           get { return makhoa; }
           set { makhoa = value; }
       }


       public DataTable BaoCaoMH()
       {
           DataTable dt = new DataTable();
           dt = baocaomh.BaoCaoMH(MAKHOA);
           return dt;
       }

    }
}
