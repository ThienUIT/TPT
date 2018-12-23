using System;
using System.Drawing;
using System.Windows.Forms;
using QLSV_Database;
using QLSV_Xuly;
using QLSV_GiaoDien;
using QLSV_GiaoDien.UserControls;
using QLSV_GiaoDien.Reports;
namespace QLSV_GiaoDien
{
  
    public partial class frmMain : Form
    {
        c_XuLyChung qlsv_xl = new c_XuLyChung();
        static frmBaocaoDiem frmDiem = new frmBaocaoDiem();
        static frmReportSinhVien frm = new frmReportSinhVien();
static        frmBaocaoMH frmMH = new frmBaocaoMH();
        static uc_User user = new uc_User();
       static uc_SinhVien_Mon_DKMH slv = new uc_SinhVien_Mon_DKMH();
        static uc_GiaoVien_Khoa gkh = new uc_GiaoVien_Khoa();
        static uc_KhoaHoc_Nganh_Lop KH_N_L = new uc_KhoaHoc_Nganh_Lop();
        static uc_NhapDiem nhapdiem = new uc_NhapDiem();
        static Login frmLogin = new Login();
        public frmMain()
        {
            InitializeComponent();
        }

        bool is_panQLSVExpand =true;//khoi tao 1 bien co de xet xem panel dang o che do expand hay collapse
        bool is_panQLMHExpand = true;
        int x_pnQlSV, y_pnQLSV, x_pnQLD, y_pnQLD, x_pnQLMH, y_pnQLMH;//ví trí

        private void Form1_Load(object sender, EventArgs e)
        {
         
            btnQLSV_collapse.Visible = true;
            btnQLSV_ex.Visible = false;

            btnQLMH_Collapse.Visible = true;
            btnQLMH_ex.Visible = false;

            btnQLDIEM_Collapse.Visible = true;
            btnQLDIEM_ex.Visible = false;

            //pan_MenuMH.Height = 0;
            //pan_MenuQLDIEM.Height = 0;

            x_pnQlSV = pan_QLSV.Location.X;
            y_pnQLSV = pan_QLSV.Location.Y;

            x_pnQLMH = pan_QLMH.Location.X;
            y_pnQLMH = pan_QLMH.Location.Y;

            x_pnQLD = pan_QLDIEM.Location.X;
            y_pnQLD = pan_QLDIEM.Location.Y;

          //  grB_leftMenu.Visible = false;
            grB_leftMenu.Enabled = false;
            menuStrip1.Visible = true;

            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;

            lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÍ SINH VIÊN";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);



        }

        #region grBox Left
        private void btnQLSV_collapse_Click(object sender, EventArgs e)
        {
            btnQLSV_ex.Visible = true;
            btnQLSV_collapse.Visible = false;
            do
            {
                pan_MenuQLSV.Height = pan_MenuQLSV.Height - 279;
                Application.DoEvents();
            } while (pan_MenuQLSV.Height > 0);
           
                pan_QLMH.BringToFront();
                pan_QLDIEM.BringToFront();
                int new_y_QLMH = pan_MenuQLSV.Location.Y + 10;
                int new_y_QLDiem = pan_MenuMH.Location.Y * 6;//pan_MenuMH.Location.Y*5 + 30;
                pan_QLMH.Location = new Point(x_pnQLMH, new_y_QLMH);
               
                is_panQLSVExpand = false;
                if (is_panQLMHExpand == false && is_panQLSVExpand == false)
                {
                    pan_QLDIEM.Location = new Point(x_pnQLMH, y_pnQLMH / 2);
                }
                else
                {
                    pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
                }
               
            
        }

        private void btnQLSV_ex_Click(object sender, EventArgs e)
        {
            do
            {
                pan_MenuQLSV.Height = pan_MenuQLSV.Height + 1;
                Application.DoEvents();
            } while (pan_MenuQLSV.Height <= 120);
            btnQLSV_ex.Visible = false;
            btnQLSV_collapse.Visible = true;
           
                pan_QLDIEM.Location = new Point(x_pnQLD, y_pnQLD);
                pan_QLMH.Location = new Point(x_pnQLMH, y_pnQLMH);
                is_panQLSVExpand = true;
                if (is_panQLMHExpand == false && is_panQLSVExpand == true)
                {
                    int new_y_QLDiem = pan_MenuMH.Location.Y * 6;
                    pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
                }
           
        }

        private void btnQLMH_ex_Click(object sender, EventArgs e)
        {
            
            do
            {
                pan_MenuMH.Height = pan_MenuMH.Height + 147;
                Application.DoEvents();
            } while (pan_MenuMH.Height <= 120);
            btnQLMH_ex.Visible = false;
            btnQLMH_Collapse.Visible = true;
          

            if (is_panQLSVExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, y_pnQLMH + 40);
            }
           
            else
            {
                pan_QLDIEM.Location = new Point(x_pnQLD, y_pnQLD);
            }
            is_panQLMHExpand = true;

        }

        private void btnQLMH_Collapse_Click(object sender, EventArgs e)
        {
            btnQLMH_ex.Visible = true;
            btnQLMH_Collapse.Visible = false ;
            do
            {
                pan_MenuMH.Height = pan_MenuMH.Height - 279;
                Application.DoEvents();
            } while (pan_MenuMH.Height >0);
            is_panQLMHExpand = false;
         
            if (is_panQLSVExpand == false && is_panQLMHExpand == false)
            {
                pan_QLDIEM.Location = new Point(x_pnQLMH, pan_MenuMH.Location.Y + 50);
            }
            else
            {
                int new_y_QLDiem = pan_MenuMH.Location.Y + pan_QLMH.Location.Y;
                pan_QLDIEM.Location = new Point(x_pnQLD, new_y_QLDiem);
            }
         
        }

        private void btnQLDIEM_ex_Click(object sender, EventArgs e)
        {
           
            do
            {
                pan_MenuQLDIEM.Height = pan_MenuQLDIEM.Height + 147;
                Application.DoEvents();
            } while (pan_MenuQLDIEM.Height <= 120);
            btnQLDIEM_ex.Visible = false;
            btnQLDIEM_Collapse.Visible = true;
        }

        private void btnQLDIEM_Collapse_Click(object sender, EventArgs e)
        {
            btnQLDIEM_ex.Visible = true;
            btnQLDIEM_Collapse.Visible = false ;
            do
            {
                pan_MenuQLDIEM.Height = pan_MenuQLDIEM.Height - 147;
                Application.DoEvents();
            } while (pan_MenuQLDIEM.Height >0);
        }

        #endregion

        #region Add User control
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý tài khoản";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

           

            qlsv_xl.AddControl(pan_Main, user);
        }
        private void lnkTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Quản lý tài khoản";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            

            qlsv_xl.AddControl(pan_Main, user);
        }
        //
        private void lnk_QuanlySv_lop_mh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Quản lí Sinh Viên - Môn Học - DKMH";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

           
            qlsv_xl.AddControl(pan_Main, slv);
        }
        private void quanliSV_L_MH_NGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lí Sinh Viên - Môn học - ĐKMH";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            
            qlsv_xl.AddControl(pan_Main, slv);
        }
        //
        private void lnkGV_K_e_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Quản lí Giáo Viên - Khoa ";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            
            qlsv_xl.AddControl(pan_Main, gkh);
            
        }
        private void quanliGV_Khoa_khoahoc_HEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lí Giáo Viên - Khoa ";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            
            qlsv_xl.AddControl(pan_Main, gkh);
        }
        //
        private void lnkKH_Nganh_Lop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Khoá Học - Ngành - Lớp";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

           
            qlsv_xl.AddControl(pan_Main, KH_N_L);
        }
        private void quảnLíKhoáHọcNgànhLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khoá Học - Ngành - Lớp";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            
            qlsv_xl.AddControl(pan_Main, KH_N_L);
        }
        //
        private void lnkNhapDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTitle.Text = "Nhập Điểm";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            
            qlsv_xl.AddControl(pan_Main, nhapdiem);
        }
        private void nhapDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhập Điểm";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            
            qlsv_xl.AddControl(pan_Main, nhapdiem);
        }

        #endregion

        #region hàm nhận tham số truyền về từ delegate Login
        public void enable_groupbox(bool kq)
        {
            grB_leftMenu.Enabled = kq;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                
                frmLogin.setGroupbox = new Login.EnableGroupbox(enable_groupbox);
                //nhận tham so truyen ve tu ham delegate EnableGroupbox
                frmLogin.ShowDialog();
            
            if (grB_leftMenu.Enabled == true)
            {
                DangNhapToolStripMenuItem.Enabled = false;
                DangXuatToolStripMenuItem.Enabled = true;
                pan_Main.Enabled = true;
                quanlyTK_ToolStripMenuItem.Enabled = true;
                TacVuToolStripMenuItem.Enabled = true;
                báoCáoToolStripMenuItem.Enabled = true;
            }
        }
        //
        private void lnkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grB_leftMenu.Enabled = false;
            quanlyTK_ToolStripMenuItem.Enabled = false;
            DangXuatToolStripMenuItem.Enabled = false;
            DangNhapToolStripMenuItem.Enabled = true;
            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            pan_Main.Controls.Clear();
            pan_Main.BackgroundImage = Properties.Resources.school;

            lblTitle.Text = "Chương trình quản lý sinh viên";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grB_leftMenu.Enabled = false;
            quanlyTK_ToolStripMenuItem.Enabled = false;
            DangXuatToolStripMenuItem.Enabled = false;
            DangNhapToolStripMenuItem.Enabled = true;
            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
            pan_Main.Controls.Clear();
            pan_Main.BackgroundImage = Properties.Resources.school;

            lblTitle.Text = "Chương trình quản lý sinh viên";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

        }
        //
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
           // WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region báo cáo
        private void lnkXuatSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frm.Show();
        }

        private void lnkXuatDSMH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmMH.Show();
        }

        private void lnkXemDiem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmDiem.Show();
        }



        private void xuatDSMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            frmMH.Show();
        }

        private void xuatDSSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            frm.Show();
            
            frm.FormClosed += Frm_FormClosed;
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void xemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDiem.Show();
        }
        #endregion

        #region mouse color

        private void lnkTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            lnkTaiKhoan.BackColor = System.Drawing.Color.AliceBlue;
        }
        private void lnkTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            lnkTaiKhoan.BackColor = System.Drawing.Color.Empty;
        }
        private void lnkDangXuat_MouseHover(object sender, EventArgs e)
        {
            lnkDangXuat.BackColor = System.Drawing.Color.AliceBlue;
        }
        private void lnkDangXuat_MouseLeave(object sender, EventArgs e)
        {
            lnkDangXuat.BackColor = System.Drawing.Color.Empty;
        }
        private void lnk_QuanlySv_lop_mh_MouseHover(object sender, EventArgs e)
        {
            lnk_QuanlySv__Mon_DKMH.BackColor = System.Drawing.Color.AliceBlue;
        }
        private void lnk_QuanlySv_lop_mh_MouseLeave(object sender, EventArgs e)
        {
            lnk_QuanlySv__Mon_DKMH.BackColor = System.Drawing.Color.Empty;
        }
        private void lnkNhapDiem_MouseHover(object sender, EventArgs e)
        {
            lnkNhapDiem.BackColor = System.Drawing.Color.AliceBlue;
        }
        private void lnkNhapDiem_MouseLeave(object sender, EventArgs e)
        {
            lnkNhapDiem.BackColor = System.Drawing.Color.Empty;
        }
        private void lnkGV_K_e_MouseHover(object sender, EventArgs e)
        {
            lnkGV_Khoa.BackColor = System.Drawing.Color.AliceBlue;
        }
        private void lnkGV_K_e_MouseLeave(object sender, EventArgs e)
        {
            lnkGV_Khoa.BackColor = System.Drawing.Color.Empty;
        }
        private void lnkXuatDSMH_MouseHover(object sender, EventArgs e)
        {
            lnkXuatDSMH.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkXuatDSMH_MouseLeave(object sender, EventArgs e)
        {
            lnkXuatDSMH.BackColor = System.Drawing.Color.Empty;
        }

        private void lnkXuatSV_MouseHover(object sender, EventArgs e)
        {
            lnkXuatSV.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkXuatSV_MouseLeave(object sender, EventArgs e)
        {
            lnkXuatSV.BackColor = System.Drawing.Color.Empty;
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
        }


        private void lnkXemDiem_MouseHover(object sender, EventArgs e)
        {
            lnkXemDiem.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quảnLýToolStripMenuItem1.Text = "Management";
            DangNhapToolStripMenuItem.Text = "Login";
            quanlyTK_ToolStripMenuItem.Text = "Account Management";
            DangXuatToolStripMenuItem.Text = "Log Out";
            thoátToolStripMenuItem.Text = "Exit";
            lnk_QuanlySv__Mon_DKMH.Text = "Student-Subject-Course Register";
            lnkKH_Nganh_Lop.Text = "Course-Field-Class";
            lnkGV_Khoa.Text = "Lecturer-Faculty";
            lnkNhapDiem.Text = "Insert scores";
            nhapDiemToolStripMenuItem.Text = "Insert scores";
            báoCáoToolStripMenuItem.Text = "Report";
            TacVuToolStripMenuItem.Text = "Tasks";
            xuatDSMonHocToolStripMenuItem.Text = "Subject List";
            xuatDSSVToolStripMenuItem.Text = "Student List";
            xemDiemToolStripMenuItem.Text = "Score View";
            aboutMeToolStripMenuItem.Text = "Information";
            thoátToolStripMenuItem1.Text = "Exit";
            lnkTaiKhoan.Text = "Account Management";
            lnkDangXuat.Text = "Log Out";
            btnQLSV_collapse.Text = "Account Management";
            lnkNhapDiem.Text = "Insert scores";
            lnkXuatDSMH.Text = "Subject List";
            lnkXuatSV.Text = "Student List";
            lnkXemDiem.Text = "Score View";
            btnQLMH_Collapse.Text = "General Management";
            btnQLDIEM_Collapse.Text = "Report";
            lblTitle.Text = "STUDENT MANAGEMENT PROGRAM";
            quanliSV_MH_DKMHToolStripMenuItem.Text = "Student-Subject-Course Register";
            quảnLíKhoáHọcNgànhLớpToolStripMenuItem.Text = "Course-Field-Class";
            quanliGV_KhoaToolStripMenuItem.Text = "Lecturer-Faculty";
            ngônNgữToolStripMenuItem.Text = "Language";
            //Login Form
            frmLogin.label1.Text = "LOGIN";
            //User
            user.groupBox1.Text = "Account Management";
            user.groupBox2.Text = "Find user";
            user.label3.Text = "User name:";
            user.groupBox3.Text = "Tasks:";
            user.rdTaoUser.Text = "Add new";
            user.rdDoiMatkhau.Text = "Change password";
            user.rdXoa.Text = "Delete";
            user.lblMatkhaumoi.Text = "Re-type password";
            //QuanLiMonHoc
            //SinhVien:
            slv.tabSV_Mon_DKMH.TabPages[0].Text = "STUDENT";
            slv.tabSV_Mon_DKMH.TabPages[1].Text = "SUBJECT";
            slv.tabSV_Mon_DKMH.TabPages[2].Text = "COURSE REGISTRATION";
            slv.groupBox1.Text = "INSERT STUDENT INFORMATION";
            slv.label1.Text = "ID:";
            slv.label2.Text = "Name:";
            slv.label5.Text = "DOB:";
            slv.label6.Text = "POB:";
            slv.label9.Text = "Origin:";
            slv.label10.Text = "Picture:";
            slv.label15.Text = "Note:";
            slv.label16.Text = "Class:";
            slv.label4.Text = "Sex:";
            slv.rdNam.Text = "Male";
            slv.rdNu.Text = "Female";
            slv.btnQuanLySV.Text = "Manage students";

            //MonHoc:
            slv.groupBox3.Text = "Insert Subject:";
            slv.label20.Text = "Subject ID:";
            slv.label14.Text = "Subject name:";
            slv.label8.Text = "Type: ";
            slv.rdMonbatbuoc.Text = "Compulsory";
            slv.rdMontuchon.Text = "Non-Compulsory";
            slv.label18.Text = "Number of credits: ";
            slv.label19.Text = "Number of theoretical credits:";
            slv.label12.Text = "Number of practical credits:";
            slv.label17.Text = "Credits:";
            slv.label11.Text = "Note:";
            slv.btnQLMH.Text = "Manage subjects";
            slv.label7.Text = "CURRENT SUBJECT LIST:";
            slv.label13.Text = "Faculty:";

            //Dang ki mon hoc:
            slv.groupBox6.Text = "Course registration";
            slv.groupBoxDKMH.Text = "Insert information";
            slv.label27.Text = "Choose subject:";
            slv.label26.Text = "Student ID:";
            slv.label22.Text = "Registration day:";
            slv.label24.Text = "Semester:";
            slv.label21.Text = "Credits:";
            slv.groupBox4.Text = "Find registered subjects:";
            slv.label37.Text = "Insert student ID:";
            slv.groupboxSVDKMH.Text = "Registered subjects:";
            slv.label3.Text = "List of subjects that student:";
            slv.label25.Text = "has registered";
            slv.dgvDangkyMH.Columns[0].HeaderText = "Subject ID";
            slv.dgvDangkyMH.Columns[1].HeaderText = "Student ID";
            slv.dgvDangkyMH.Columns[2].HeaderText = "Registration day";
            slv.dgvDangkyMH.Columns[3].HeaderText = "Credit(s)";
            slv.dgvDangkyMH.Columns[4].HeaderText = "Semester";

            //Khoahoc-Nganh
            //Khoahoc
            KH_N_L.tabKhoaHoc_Nganh_Lop.TabPages[0].Text = "Course";
            KH_N_L.tabKhoaHoc_Nganh_Lop.TabPages[1].Text = "Field";
            KH_N_L.tabKhoaHoc_Nganh_Lop.TabPages[2].Text = "Class";
            KH_N_L.groupBox1.Text = "Add a new course";
            KH_N_L.label12.Text = "Course ID";
            KH_N_L.label8.Text = "Course Name:";
            KH_N_L.label11.Text = "Note:";
            KH_N_L.label13.Text = "Beginning day:";
            KH_N_L.label14.Text = "Ending day:";
            KH_N_L.dgvKhoaHoc.Columns[0].HeaderText = "Course ID";
            KH_N_L.dgvKhoaHoc.Columns[1].HeaderText = "Course Name:";
            KH_N_L.dgvKhoaHoc.Columns[2].HeaderText = "Beginning day:";
            KH_N_L.dgvKhoaHoc.Columns[3].HeaderText = "Ending day:";
            KH_N_L.dgvKhoaHoc.Columns[4].HeaderText = "Note:";
            
            //Nganh hoc
            KH_N_L.groupBox7.Text = "Insert new fields";
            KH_N_L.label28.Text = "Field ID:";
            KH_N_L.label29.Text = "Field name:";
            KH_N_L.label31.Text = "Note:";
            KH_N_L.groupBox8.Text = "Subject List:";
            KH_N_L.dgvNganh.Columns[0].HeaderText = "Field ID";
            KH_N_L.dgvNganh.Columns[1].HeaderText = "Field name:";
            KH_N_L.dgvNganh.Columns[2].HeaderText = "Note:";

            //Lop
            KH_N_L.groupboxLOP.Text = "Add class";
            KH_N_L.label32.Text = "Class ID:";
            KH_N_L.label33.Text = "Class name:";
            KH_N_L.label36.Text = "Note:";
            KH_N_L.label34.Text = "Field";
            KH_N_L.label35.Text = "Faculty:";
            KH_N_L.label23.Text = "Find by:";
            KH_N_L.label38.Text = "Key word:";
            KH_N_L.groupBox9.Text = "Class list:";
            KH_N_L.cmbTimLop.Text = "-- Choose condition --";
            KH_N_L.dgvLop.Columns[0].HeaderText = "Class code";
            KH_N_L.dgvLop.Columns[1].HeaderText = "Course ID";
            KH_N_L.dgvLop.Columns[2].HeaderText = "Field ID";
            KH_N_L.dgvLop.Columns[3].HeaderText = "Class name";
            KH_N_L.dgvLop.Columns[4].HeaderText = "Note";
            //Giaovien-Khoa
            //GiaoVien
            gkh.tabGV_Khoa.TabPages[0].Text = "Teacher";
            gkh.tabGV_Khoa.TabPages[1].Text = "Faculty";
            gkh.groupboxGV.Text = "Add Teachers:";
            gkh.label1.Text = "Teacher ID:";
            gkh.label3.Text = "Teacher name:";
            gkh.label2.Text = "Faculty:";
            gkh.label5.Text = "Note:";
            gkh.groupBox3.Text = "Search Teacher Information:";
            gkh.label6.Text = "Find by:";
            gkh.cmbDieuKienTim.Text = "Choose condition";
            gkh.label4.Text = "Type in information";
            gkh.groupBox2.Text = "Current student list:";
            /*gkh.dgvGiaoVien.Columns[0].HeaderText = "Teacher ID";
            gkh.dgvGiaoVien.Columns[1].HeaderText = "Teacher name";
            gkh.dgvGiaoVien.Columns[2].HeaderText = "Course ID";
            gkh.dgvGiaoVien.Columns[3].HeaderText = "Update";
            gkh.dgvGiaoVien.Columns[4].HeaderText = "Delete";*/
            //Khoa
            gkh.groupboxKhoa.Text = "Add Faculties";
            gkh.label7.Text = "Faculty ID:";
            gkh.label10.Text = "Faculty Name:";
            gkh.label9.Text = "Note";
            gkh.groupBox5.Text = "Faculty List:";
            /*gkh.dgvKhoa.Columns[0].HeaderText = "Faculty ID";
            gkh.dgvKhoa.Columns[1].HeaderText = "Faculty name";
            gkh.dgvKhoa.Columns[2].HeaderText = "Note";
            gkh.dgvKhoa.Columns[3].HeaderText = "Update";
            gkh.dgvKhoa.Columns[4].HeaderText = "Delete";*/
            //Nhap diem:
            nhapdiem.groupBox1.Text = "Insert scores:";
            nhapdiem.groupBox2.Text = "Insert scores for subjects";
            nhapdiem.label1.Text = "Choose Faculty:";
            nhapdiem.label10.Text = "Choose Subject:";
            nhapdiem.groupBox4.Text = "Searh student scores:";
            nhapdiem.groupBox3.Text = "Insert scores:";
            nhapdiem.label2.Text = "Subject ID:";
            nhapdiem.label3.Text = "Student ID:";
            nhapdiem.label4.Text = "Score 1:";
            nhapdiem.label5.Text = "Score 2:";
            nhapdiem.label6.Text = "Time(s):";
            nhapdiem.label7.Text = "Exam day:";
            nhapdiem.label8.Text = "Note:";
            nhapdiem.label9.Text = "Type in student ID:";
            //BaoCaoMH:
            frmMH.groupBox1.Text = "Output subject list";
            frmMH.label2.Text = "Output subject list by faculty:";
            frmMH.btnDongY.Text = "Okay";
            frmMH.dgvMonHoc.Columns[0].HeaderText = "Subject name";
            frmMH.dgvMonHoc.Columns[1].HeaderText = "Credit(s)";
            frmMH.dgvMonHoc.Columns[2].HeaderText = "Type";
            frmMH.dgvMonHoc.Columns[3].HeaderText = "Number of classes";
            frmMH.dgvMonHoc.Columns[4].HeaderText = "Number of theoritcal credit(s)";
            frmMH.dgvMonHoc.Columns[5].HeaderText = "Number of practical credit(s)";
            frmMH.dgvMonHoc.Columns[6].HeaderText = "Note:";
            //Report sinh vien:
            frm.groupBox1.Text = "Output student list:";
            frm.label3.Text = "Choose the course";
            frm.label2.Text = "Choose class";
            frm.btnDongY.Text = "Okay";
            frm.dgvSinhVien.Columns[0].HeaderText = "Name";
            frm.dgvSinhVien.Columns[1].HeaderText = "Student ID";
            frm.dgvSinhVien.Columns[2].HeaderText = "Origin";
            frm.dgvSinhVien.Columns[3].HeaderText = "Day of Birth";
            frm.dgvSinhVien.Columns[4].HeaderText = "Place of Birth";
            frm.dgvSinhVien.Columns[5].HeaderText = "Sex";
            //Form diem:
            frmDiem.groupBox1.Text = "Search scores:";
            frmDiem.label1.Text = "Student ID:";
            frmDiem.btnXemDiem.Text = "View";
            frmDiem.dgvDiem.Columns[0].HeaderText = "Subject name";
            frmDiem.dgvDiem.Columns[1].HeaderText = "Credit(s)";
            frmDiem.dgvDiem.Columns[2].HeaderText = "Name";
            frmDiem.dgvDiem.Columns[3].HeaderText = "Score 1";
            frmDiem.dgvDiem.Columns[4].HeaderText = "Score 2:";
            frmDiem.dgvDiem.Columns[5].HeaderText = "Time(s)";
            frmDiem.dgvDiem.Columns[6].HeaderText = "Exam day";
            frmDiem.dgvDiem.Columns[7].HeaderText = "Note";
        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quảnLýToolStripMenuItem1.Text = "Quản lý";
            DangNhapToolStripMenuItem.Text = "Đăng nhập";
            quanlyTK_ToolStripMenuItem.Text = "Quản lý tài khoản";
            DangXuatToolStripMenuItem.Text = "Đăng xuất";
            thoátToolStripMenuItem.Text = "Thoát";
            lnk_QuanlySv__Mon_DKMH.Text = "Sinh viên-Môn-Đăng kí môn học";
            lnkKH_Nganh_Lop.Text = "Khoa-ngành-lớp";
            lnkGV_Khoa.Text = "Giao viên-Khoa";
            lnkNhapDiem.Text = "Nhập điểm";
            nhapDiemToolStripMenuItem.Text = "Nhập điểm";
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            TacVuToolStripMenuItem.Text = "Tác vụ";
            xuatDSMonHocToolStripMenuItem.Text = "Danh sách môn học";
            xuatDSSVToolStripMenuItem.Text = "Danh sách môn học";
            xemDiemToolStripMenuItem.Text = "Xem điểm";
            aboutMeToolStripMenuItem.Text = "Thông tin";
            thoátToolStripMenuItem1.Text = "Thoát";
            lnkTaiKhoan.Text = "Quản lí tài khoản";
            lnkDangXuat.Text = "Đăng xuất";
            btnQLSV_collapse.Text = "Quản lí tài khoản";
            lnkNhapDiem.Text = "Thêm điểm";
            lnkXuatDSMH.Text = "Danh sách môn";
            lnkXuatSV.Text = "Danh sách sinh viên";
            lnkXemDiem.Text = "Xem điểm";
            btnQLMH_Collapse.Text = "Quản lí chung";
            btnQLDIEM_Collapse.Text = "Báo cáo";
            lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            quanliSV_MH_DKMHToolStripMenuItem.Text = "Sinh viên-Môn-Đăng kí môn học Register";
            quảnLíKhoáHọcNgànhLớpToolStripMenuItem.Text = "Khóa-ngành-Lớp";
            quanliGV_KhoaToolStripMenuItem.Text = "Giao viên - Khoa";
            ngônNgữToolStripMenuItem.Text = "Ngôn ngữ";
            //Login Form
            frmLogin.label1.Text = "ĐĂNG NHẬP";

            //QuanLiMonHoc
            //SinhVien:
            slv.tabSV_Mon_DKMH.TabPages[0].Text = "SINH VIÊN";
            slv.tabSV_Mon_DKMH.TabPages[1].Text = "MÔN HỌC";
            slv.tabSV_Mon_DKMH.TabPages[2].Text = "ĐĂNG KÍ MÔN";
            slv.groupBox1.Text = "NHẬP THÔNG TIN SINH VIÊN";
            slv.label1.Text = "Mã SV:";
            slv.label2.Text = "Tên:";
            slv.label5.Text = "Ngày sinh:";
            slv.label6.Text = "Nơi sinh:";
            slv.label9.Text = "Quê quán:";
            slv.label10.Text = "Hình:";
            slv.label15.Text = "Ghi chú:";
            slv.label16.Text = "Lớp:";
            slv.label4.Text = "Gioi tinh:";
            slv.rdNam.Text = "Nam";
            slv.rdNu.Text = "Nữ";
            slv.btnQuanLySV.Text = "Quản lí sinh viên";

            //MonHoc:
            slv.groupBox3.Text = "Thêm môn học:";
            slv.label20.Text = "Mã môn:";
            slv.label14.Text = "Tên môn:";
            slv.label8.Text = "Loại: ";
            slv.rdMonbatbuoc.Text = "Bắt buộc";
            slv.rdMontuchon.Text = "Không bắt buộc";
            slv.label18.Text = "Tín chỉ: ";
            slv.label19.Text = "Tín chỉ lí thuyết:";
            slv.label12.Text = "Tín chỉ thực hành:";
            slv.label17.Text = "Số tiết:";
            slv.label11.Text = "Ghi chú:";
            slv.btnQLMH.Text = "Quản lí môn";
            slv.label7.Text = "Danh sách sinh viên hiện tại:";
            slv.label13.Text = "Khoa:";

            //Dang ki mon hoc:
            slv.groupBox6.Text = "Đăng kí môn";
            slv.groupBoxDKMH.Text = "Nhập thông tin";
            slv.label27.Text = "Chọn môn:";
            slv.label26.Text = "Mã SV:";
            slv.label22.Text = "Ngày đăng kí:";
            slv.label24.Text = "Học kì:";
            slv.label21.Text = "Tín chỉ:";
            slv.groupBox4.Text = "Tìm môn đã đăng kí:";
            slv.label37.Text = "Nhập mã sv:";
            slv.groupboxSVDKMH.Text = "Môn đã đăng kí:";
            slv.label3.Text = "Danh sách những môn sinh viên:";
            slv.label25.Text = "đã đăng kí";
            slv.dgvDangkyMH.Columns[0].HeaderText = "Mã môn";
            slv.dgvDangkyMH.Columns[1].HeaderText = "Mã sv";
            slv.dgvDangkyMH.Columns[2].HeaderText = "Ngày đăng kí";
            slv.dgvDangkyMH.Columns[3].HeaderText = "Tín chỉ";
            slv.dgvDangkyMH.Columns[4].HeaderText = "Học kì";

            //Khoahoc-Nganh
            //Khoahoc
            KH_N_L.tabKhoaHoc_Nganh_Lop.TabPages[0].Text = "Môn";
            KH_N_L.tabKhoaHoc_Nganh_Lop.TabPages[1].Text = "Ngành";
            KH_N_L.tabKhoaHoc_Nganh_Lop.TabPages[2].Text = "Lớp";
            KH_N_L.groupBox1.Text = "Thêm khóa học";
            KH_N_L.label12.Text = "Mã khóa";
            KH_N_L.label8.Text = "Tên khóa:";
            KH_N_L.label11.Text = "Ghi chú:";
            KH_N_L.label13.Text = "Ngày bắt đầu:";
            KH_N_L.label14.Text = "Ngày kết thúc:";
           /*KH_N_L.dgvKhoaHoc.Columns[0].HeaderText = "Mã khóa";
            KH_N_L.dgvKhoaHoc.Columns[1].HeaderText = "Tên khóa";
            KH_N_L.dgvKhoaHoc.Columns[2].HeaderText = "Ngày bắt đầu";
            KH_N_L.dgvKhoaHoc.Columns[3].HeaderText = "Ngày kết thúc";
            KH_N_L.dgvKhoaHoc.Columns[4].HeaderText = "Ghi chú";
            KH_N_L.dgvKhoaHoc.Columns[5].HeaderText = "Cập nhật";
            KH_N_L.dgvKhoaHoc.Columns[6].HeaderText = "Xóa";*/
            //Nganh hoc
            KH_N_L.groupBox7.Text = "Thêm ngành";
            KH_N_L.label28.Text = "Mã ngành";
            KH_N_L.label29.Text = "Tên ngành";
            KH_N_L.label31.Text = "Ghi chú";
            KH_N_L.groupBox8.Text = "Danh sách môn học";
            KH_N_L.dgvNganh.Columns[0].HeaderText = "Mã ngành";
            KH_N_L.dgvNganh.Columns[1].HeaderText = "Tên ngành";
            KH_N_L.dgvNganh.Columns[2].HeaderText = "Ghi chú";

            //Lop
            KH_N_L.groupboxLOP.Text = "Thêm lớp";
            KH_N_L.label32.Text = "Mã lớp";
            KH_N_L.label33.Text = "Tên lớp:";
            KH_N_L.label36.Text = "Ghi chú:";
            KH_N_L.label34.Text = "Ngành:";
            KH_N_L.label35.Text = "Khoa:";
            KH_N_L.label23.Text = "Tìm theo:";
            KH_N_L.label38.Text = "Từ khóa:";
            KH_N_L.groupBox9.Text = "Danh sách lớp:";
            KH_N_L.cmbTimLop.Text = "-- Chọn điều kiện --";
            KH_N_L.dgvLop.Columns[0].HeaderText = "Mã lớp";
            KH_N_L.dgvLop.Columns[1].HeaderText = "Mã khóa";
            KH_N_L.dgvLop.Columns[2].HeaderText = "Mã ngành";
            KH_N_L.dgvLop.Columns[3].HeaderText = "Tên lớp";
            KH_N_L.dgvLop.Columns[4].HeaderText = "Ghi chú";
            //Giaovien-Khoa
            //GiaoVien
            gkh.tabGV_Khoa.TabPages[0].Text = "Giao1 viên";
            gkh.tabGV_Khoa.TabPages[1].Text = "Khoa";
            gkh.groupboxGV.Text = "Thêm giáo viên";
            gkh.label1.Text = "Mã giáo viên";
            gkh.label3.Text = "Tên giáo viên";
            gkh.label2.Text = "Khoa";
            gkh.label5.Text = "Ghi chú";
            gkh.groupBox3.Text = "Tìm thông tin giáo viên";
            gkh.label6.Text = "Tìm theo";
            gkh.cmbDieuKienTim.Text = "Chọn điều kiện";
            gkh.label4.Text = "Nhập thông tin";
            gkh.groupBox2.Text = "Danh sách học sinh hiện tại";
           /* gkh.dgvGiaoVien.Columns[0].HeaderText = "Mã giáo viên";
            gkh.dgvGiaoVien.Columns[1].HeaderText = "Tên giáo viên";
            gkh.dgvGiaoVien.Columns[2].HeaderText = "Mã khóa";
            gkh.dgvGiaoVien.Columns[3].HeaderText = "Cập nhật";
            gkh.dgvGiaoVien.Columns[4].HeaderText = "Xóa";*/
            //Khoa
            gkh.groupboxKhoa.Text = "Thêm khoa";
            gkh.label7.Text = "Mã khoa";
            gkh.label10.Text = "Tên khoa";
            gkh.label9.Text = "Ghi chú";
            gkh.groupBox5.Text = "Danh sách khoa";
            /*gkh.dgvKhoa.Columns[0].HeaderText = "Mã khoa";
            gkh.dgvKhoa.Columns[1].HeaderText = "Tên khoa";
            gkh.dgvKhoa.Columns[2].HeaderText = "Ghi chú";
            gkh.dgvKhoa.Columns[3].HeaderText = "Cập nhật";
            gkh.dgvKhoa.Columns[4].HeaderText = "Xóa";*/
            //Nhap diem:
            nhapdiem.groupBox1.Text = "Nhập điểm";
            nhapdiem.groupBox2.Text = "Nhập điểm cho môn";
            nhapdiem.label1.Text = "Chọn khoa";
            nhapdiem.label10.Text = "Chọn ngành";
            nhapdiem.groupBox4.Text = "Tìm điểm sinh viên";
            nhapdiem.groupBox3.Text = "Nhập điểm:";
            nhapdiem.label2.Text = "Mã môn";
            nhapdiem.label3.Text = "Tên môn";
            nhapdiem.label4.Text = "Điểm lần 1:";
            nhapdiem.label5.Text = "Điểm lần 2:";
            nhapdiem.label6.Text = "Lần:";
            nhapdiem.label7.Text = "Ngày thi:";
            nhapdiem.label8.Text = "Ghi chú:";
            nhapdiem.label9.Text = "Nhập mã sv:";
            //BaoCaoMH:
            frmMH.groupBox1.Text = "Xuất danh sách môn học";
            frmMH.label2.Text = "Xuất danh sách môn học theo khoa";
            frmMH.btnDongY.Text = "Đồng ý";
            frmMH.dgvMonHoc.Columns[0].HeaderText = "Tên môn";
            frmMH.dgvMonHoc.Columns[1].HeaderText = "Tín chỉ";
            frmMH.dgvMonHoc.Columns[2].HeaderText = "Loại";
            frmMH.dgvMonHoc.Columns[3].HeaderText = "Số tiết";
            frmMH.dgvMonHoc.Columns[4].HeaderText = "Số tín chỉ lí thuyết";
            frmMH.dgvMonHoc.Columns[5].HeaderText = "Số tín chỉ thực hành";
            frmMH.dgvMonHoc.Columns[6].HeaderText = "Ghi chú:";
            //Report sinh vien:
            frm.groupBox1.Text = "Xuất danh sách sinh viên:";
            frm.label3.Text = "Chọn khoa";
            frm.label2.Text = "Chọn lớp";
            frm.btnDongY.Text = "Đồng ý";
            frm.dgvSinhVien.Columns[0].HeaderText = "Tên";
            frm.dgvSinhVien.Columns[1].HeaderText = "Mã sv";
            frm.dgvSinhVien.Columns[2].HeaderText = "Quê quán";
            frm.dgvSinhVien.Columns[3].HeaderText = "Ngày sinh";
            frm.dgvSinhVien.Columns[4].HeaderText = "Nơi sinh";
            frm.dgvSinhVien.Columns[5].HeaderText = "Gioi tính";
            //User
            //User
            user.groupBox1.Text = "Quản lý tài khoản";
            user.groupBox2.Text = "Tìm người dùng";
            user.label3.Text = "Tên người dùng";
            user.groupBox3.Text = "Tác vụ";
            user.rdTaoUser.Text = "Thêm mới";
            user.rdDoiMatkhau.Text = "Đổi mật khẩu";
            user.rdXoa.Text = "Xóa";
            user.lblMatkhaumoi.Text = "Nhâp lại mật khẩu";
            //Form diem:
            frmDiem.groupBox1.Text = "Tìm điểm:";
            frmDiem.label1.Text = "Nhập mã số sinh viên:";
            frmDiem.btnXemDiem.Text = "Xem";
            frmDiem.dgvDiem.Columns[0].HeaderText = "Tên môn";
            frmDiem.dgvDiem.Columns[1].HeaderText = "Tín chỉ";
            frmDiem.dgvDiem.Columns[2].HeaderText = "Tên";
            frmDiem.dgvDiem.Columns[3].HeaderText = "Điểm lần 1";
            frmDiem.dgvDiem.Columns[4].HeaderText = "Điểm lần 2";
            frmDiem.dgvDiem.Columns[5].HeaderText = "Lần";
            frmDiem.dgvDiem.Columns[6].HeaderText = "Ngày thi";
            frmDiem.dgvDiem.Columns[7].HeaderText = "Ghi chú";
        }

        private void lnkXemDiem_MouseLeave(object sender, EventArgs e)
        {
            lnkXemDiem.BackColor = System.Drawing.Color.Empty;
        }
        private void lnkKH_Nganh_Lop_MouseHover(object sender, EventArgs e)
        {
            lnkKH_Nganh_Lop.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void lnkKH_Nganh_Lop_MouseLeave(object sender, EventArgs e)
        {
            lnkKH_Nganh_Lop.BackColor = System.Drawing.Color.Empty;
        }

        #endregion

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutme ab = new Aboutme();
            ab.ShowDialog();
           
        }
        // no effect flicker double-buffer
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

    }
}
