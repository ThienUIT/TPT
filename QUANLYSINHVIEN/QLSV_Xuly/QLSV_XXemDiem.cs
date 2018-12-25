using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLSV_Database;
namespace QLSV_Xuly
{
   public class QLSV_XXemDiem
    {
       QLSV_DXemDiem XemDiem = new QLSV_DXemDiem();

       private string Masv;

       public string MASV
       {
           get { return Masv; }
           set { Masv = value; }
       }

       public DataTable xemdiem()
       {
           DataTable dt = new DataTable();
           dt = XemDiem.XemDiem(MASV);
               return dt;
       }
    }
}
