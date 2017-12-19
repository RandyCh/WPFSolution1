using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserPictureBox2 : UserControl
    {
        public UserPictureBox2()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Invalidate();//讓控制項的整個介面失效,並重新繪製

        }
       
        public Color FillColor1 { get; set; }
        public Color FillColor2 { get; set; }

        public Image PicImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            MessageBox.Show("Test");
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Color.Red;
            this.Invalidate();//讓控制項的整個介面失效,並重新繪製
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            this.Invalidate();//讓控制項的整個介面失效,並重新繪製
        }
    }
}
