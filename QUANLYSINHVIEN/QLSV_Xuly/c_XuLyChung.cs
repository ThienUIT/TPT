using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace QLSV_Xuly
{
    public class c_XuLyChung
    {

        //Hàm xóa rỗng tất cả các textbox trên form
        public void ClearAllTextBox(Control ctr)//ctr truyền vào 1 form, hoặc 1 usercontrol, hoặc 1 groupbox chứa các textbox......
        {
            if (ctr.GetType() == typeof(TextBox))
            {
                ctr.Text = "";

            }
            //Duyệt tất cả các textbox trên form
            foreach (Control iCtr in ctr.Controls)
            {
                ClearAllTextBox(iCtr);
            }
        }

        public void AddControl(Panel pn, UserControl uc)
        {
            pn.BackgroundImage = null;
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }


        //public void doublue_buffer()
        //{

        //    BufferedGraphicsContext currentContext;
        //    BufferedGraphics myBuffer;
        //    // Lấy một tham chiếu của BufferedGraphicsContext
        //    currentContext = BufferedGraphicsManager.Current;
        //    // Tạo một buffer với kích cỡ là bề mặt form;
        //    myBuffer = currentContext.Allocate(this.CreateGraphics(),

        //    this.DisplayRectangle);

        //    // Vẽ một ellipse
        //    myBuffer.Graphics.DrawEllipse(Pens.Blue, this.DisplayRectangle);
        //    // Render nội dung
        //    myBuffer.Render();
        //    myBuffer.Dispose();

        //}
    }
}
