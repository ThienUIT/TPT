using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSV_Xuly;
namespace QLSV_GiaoDien
{
    public partial class frmQuanLySV : Form
    {
        QLSV_XSinhVien qlsv_xlSV = new QLSV_XSinhVien();
        c_XuLyChung xlchung = new c_XuLyChung();
        
        int col = 0;
        string Field ="";
        
        public void Enable()
        {
            txtMSSV.Enabled = true;
            txtHotenSv.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtGhichu.Enabled = true;
            txtHinh.Enabled = true;
            btnBrowseHinh.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            cbMaLop.Enabled = true;
            rdNam.Enabled = true;
            rdNu.Enabled = true;
           


        }
        public void DisEnable()
        {
            txtMSSV.Enabled = false;
            txtHotenSv.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtQueQuan.Enabled = false;
            txtGhichu.Enabled = false;
            txtHinh.Enabled = false;
            btnBrowseHinh.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            cbMaLop.Enabled = false;
            rdNam.Enabled = false;
            rdNu.Enabled = false;
           
            btnLuu.Visible = false;
          
        }

        public frmQuanLySV()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmQuanLySV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlsv_xlSV.LoadDL();
            qlsv_xlSV.TXT = txtNoidungTimKiem;
            qlsv_xlSV.COLUMN = 0;
            qlsv_xlSV.TextBoxAutoComplete();

            qlsv_xlSV.CMB = cbMaLop;
            qlsv_xlSV.LayDLVaoComboboxMaLop();
            DisEnable();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbDKTimKiem.Text == "-- Nhập điều kiện --")
            {
                MessageBox.Show("Vui lòng chọn điều kiện tìm kiếm!");
                return;
            }
            else
            {
                qlsv_xlSV.FIELD = Field;
                if (txtNoidungTimKiem.Text == "")
                {
                    dataGridView1.DataSource = qlsv_xlSV.TimKiemSV();
                    int n = dataGridView1.Rows.Count - 1;
                    MessageBox.Show("Tìm thay " + n + " kết quả");
                }
                else
                {
                    qlsv_xlSV.DKTIM = txtNoidungTimKiem.Text.Trim();


                    dataGridView1.DataSource = qlsv_xlSV.TimKiemSV();
                    int n = dataGridView1.Rows.Count - 1;
                    MessageBox.Show("Tìm thay " + n + " kết quả");
                }
            }
           

        }

        private void cmbDKTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
             if (cmbDKTimKiem.SelectedItem.ToString() == "Mã số Sinh Viên")
            {
                col = 0;
                Field = "MaSinhVien";
                //Dktim = txtNoidungTimKiem.Text;
            }
            else if (cmbDKTimKiem.SelectedItem.ToString() == "Tên Sinh Viên")
            {
                col = 1;
                Field = "Hoten";
                //Dktim = txtNoidungTimKiem.Text;
            }
   

            qlsv_xlSV.COLUMN = col;
            qlsv_xlSV.TXT = txtNoidungTimKiem;
            qlsv_xlSV.TextBoxAutoComplete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grouptextBox.Enabled = true;
            txtMSSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHotenSv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtQueQuan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "")
            {
                dtp_NgaySinh.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            }
            
            txtNoiSinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
       
            txtHinh.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtGhichu.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string gioitinh = "";
            gioitinh = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (gioitinh == "Nam")
            {
                rdNam.Checked = true;
            }
            else
                rdNu.Checked = true;
            cbMaLop.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enable();
            groupBox2.Enabled = false;
            btnLuu.Visible = true;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            qlsv_xlSV.MASV = txtMSSV.Text;
            qlsv_xlSV.HOTEN = txtHotenSv.Text;
            qlsv_xlSV.QUEQUAN = txtQueQuan.Text;
            qlsv_xlSV.NGAYSINH = dtp_NgaySinh.Value;
            qlsv_xlSV.NOISINH = txtNoiSinh.Text;
            qlsv_xlSV.HINH = txtHinh.Text;
            qlsv_xlSV.GHICHU = txtGhichu.Text;
            qlsv_xlSV.MALOP = cbMaLop.SelectedValue.ToString();
            string gioitinh = "";
            if (rdNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
                gioitinh = "Nữ";
            qlsv_xlSV.GIOITINH = gioitinh;

            qlsv_xlSV.CapNhatSinhVien();
            dataGridView1.DataSource = qlsv_xlSV.LoadDL();
            xlchung.ClearAllTextBox(grouptextBox);
            DisEnable();
            groupBox2.Enabled = true;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            qlsv_xlSV.MASV = txtMSSV.Text;
            qlsv_xlSV.XoaSinhVien();
            dataGridView1.DataSource = qlsv_xlSV.LoadDL();
            xlchung.ClearAllTextBox(grouptextBox);

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlsv_xlSV.LoadDL();
        }

        private void btnBrowseHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtHinh.Text = openFileDialog1.FileName;
        }
        #region chuẩn hoá
        private void txtHotenSv_TextChanged(object sender, EventArgs e)
        {

            txtHotenSv.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtHotenSv.Text);
            txtHotenSv.Select(txtHotenSv.Text.Length, 0);

        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

            txtNoiSinh.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtNoiSinh.Text);
            txtNoiSinh.Select(txtNoiSinh.Text.Length, 0);

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

            txtQueQuan.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtQueQuan.Text);
            txtQueQuan.Select(txtQueQuan.Text.Length, 0);

        }

        private void txtNoidungTimKiem_TextChanged(object sender, EventArgs e)
        {

            txtNoidungTimKiem.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtNoidungTimKiem.Text);
            txtNoidungTimKiem.Select(txtNoidungTimKiem.Text.Length, 0);

        }
        #endregion

      
    }
}
