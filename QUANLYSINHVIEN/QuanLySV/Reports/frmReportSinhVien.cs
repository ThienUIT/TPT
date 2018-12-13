using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLSV_Database;
using QLSV_Xuly;
namespace QLSV_GiaoDien.Reports
{
    public partial class frmReportSinhVien : Form
    {
        QLSV_XBaocaoSV xlBaocao = new QLSV_XBaocaoSV();
        QLSV_XLop xlLop = new QLSV_XLop();
        public frmReportSinhVien()
        {
            InitializeComponent();
        }


        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (cmbLop.SelectedValue != null)
            {
                xlBaocao.MALOP = cmbLop.SelectedValue.ToString();
                dgvSinhVien.DataSource=xlBaocao.BaoCaoSV();              
            }
            else
            {
                cmbLop.DisplayMember = "";
                MessageBox.Show("Không có môn học nào trong khóa này");
            }

        }


        private void cmbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {

            xlBaocao.MAKHOAHOC = cmbKhoaHoc.SelectedValue.ToString();
            xlBaocao.CMB = cmbLop;
            xlBaocao.LayDLVaocmbLop();

            cmbLop.Enabled = true;
        }

        private void frmLoad(object sender, EventArgs e)
        {
            xlLop.cmbMAKHOAHOC = cmbKhoaHoc;
            xlLop.LoadDLVaoCombobox_MaKhoaHoc();
            cmbKhoaHoc.Text = "-- Chọn khóa học --";
        }

    }
}
