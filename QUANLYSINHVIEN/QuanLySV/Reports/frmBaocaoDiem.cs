using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_Xuly;
namespace QLSV_GiaoDien.Reports
{
    public partial class frmBaocaoDiem : Form
    {
        QLSV_XXemDiem xlDiem = new QLSV_XXemDiem();

        public frmBaocaoDiem()
        {
            InitializeComponent();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            xlDiem.MASV = txtMSSV.Text;
            dgvDiem.DataSource=xlDiem.xemdiem();            
        }

        private void frmBaocaoDiem_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            xlDiem.MASV = txtMSSV.Text;
            XemDiem excel = new XemDiem();
            excel.Export(xlDiem.xemdiem(), "Danh sach", "Bảng Điểm");
        }
    }
}
