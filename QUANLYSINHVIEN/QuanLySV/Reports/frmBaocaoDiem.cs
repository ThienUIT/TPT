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
        QLSV_XXemDiem xxDiem = new QLSV_XXemDiem();
        QLSV_XDiem qlsv_xlDiem = new QLSV_XDiem();

        public frmBaocaoDiem()
        {
            InitializeComponent();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            xxDiem.MASV = txtMSSV.Text;
            dgvDiem.DataSource=xxDiem.xemdiem();            
        }

        private void frmBaocaoDiem_Load(object sender, EventArgs e)
        {

            qlsv_xlDiem.txtTIMMSV = txtMSSV;
            qlsv_xlDiem.GoiYTimMSV();
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            xxDiem.MASV = txtMSSV.Text;
            XemDiem excel = new XemDiem();
            excel.Export(xxDiem.xemdiem(), "Danh sach", "Bảng Điểm");
        }
    }
}
