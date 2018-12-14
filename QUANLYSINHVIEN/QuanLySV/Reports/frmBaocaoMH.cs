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
    public partial class frmBaocaoMH : Form
    {
        QLSV_XBaocaoMH xlBaocaoMH = new QLSV_XBaocaoMH();
        QLSV_XMonHoc xlMonHoc = new QLSV_XMonHoc();
        public frmBaocaoMH()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            xlBaocaoMH.MAKHOA = cmbKhoa.SelectedValue.ToString();
            dgvMonHoc.DataSource = xlBaocaoMH.BaoCaoMH();

        }

        private void frmBaocaoMH_Load(object sender, EventArgs e)
        {
            xlMonHoc.CMB = cmbKhoa;
            xlMonHoc.LoadDLVaoCombobox_cmbMaKhoa_MH();
        }
    }
}
