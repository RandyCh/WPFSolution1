﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public class MyButton : Control
    {
        public MyButton()
        {
            this.FillColor1 = Color.Orange;
            this.FillColor2 = Color.Gray;

        }
        public Color FillColor1 { get; set; }
        public Color FillColor2 { get; set; }

        public enum Shape { Ellipse, Rectangle}
        private Shape m_FillSahpe;
        public Shape FillShape
        {
            get
            {
                return m_FillSahpe;
            }
            set
            {
                m_FillSahpe = value;
                this.Invalidate();//讓控制項的整個介面失效,並重新繪製
            }
        }
        //public FillDirtection
        protected override void OnPaint(PaintEventArgs e)
        {
            //GDI+=>XAML UI
            Graphics g = e.Graphics;//將帶入的事件位置圖形命名為g
            g.SmoothingMode = SmoothingMode.AntiAlias;//使物件比較平滑
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);
            LinearGradientBrush brush1 = new LinearGradientBrush(pt1, pt2, this.FillColor1,this.FillColor2);//漸層的刷子

            switch(this.FillShape)
                {
                case Shape.Ellipse:
                     g.FillEllipse(brush1, this.ClientRectangle);//ClientRectangle表示取得工作區域的矩形
                    break;
                case Shape.Rectangle:
                    g.FillRectangle(brush1, this.ClientRectangle);
                    break;
                                                        //g.FillEllipse(brush1, this.ClientRectangle); 
        }
            //============================
            //Draw String
            float x, y;
            x = (this.ClientRectangle.Width - g.MeasureString(base.Text, base.Font).Width) / 2;
            y = (this.ClientRectangle.Height - g.MeasureString(base.Text, base.Font).Height) / 2;
            g.DrawString(base.Text, base.Font, Brushes.White, x, y);

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.FillColor1 = Color.Blue;
            this.Invalidate();//讓控制項的整個介面失效,並重新繪製
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.FillColor1 = Color.Orange;
            this.Invalidate();//讓控制項的整個介面失效,並重新繪製
        }

    }

}
