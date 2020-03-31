using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    class GradientLabel : Panel
    {
        
        private Color cLeft;
        private Color cRight;

       
        public Color BeginColor
        {
            get
            {
                return cLeft;
            }
            set
            {
                cLeft = value;
            }
        }
        
        public Color EndColor
        {
            get
            {
                return cRight;
            }
            set
            {
                cRight = value;
            }
        }
        public GradientLabel()
        {
            
            cLeft = SystemColors.ActiveCaption;
            cRight = SystemColors.Control;
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            
            LinearGradientBrush GBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, 0), cLeft, cRight);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            
            e.Graphics.FillRectangle(GBrush, rect);
           
            SolidBrush drawBrush = new SolidBrush(this.ForeColor);
            StringFormat sf = new StringFormat();
           
            sf.Alignment = StringAlignment.Center;
            
            RectangleF rectF = new
            RectangleF(0, this.Height / 2 - Font.Height / 2, this.Width, this.Height);
            
            e.Graphics.DrawString(this.Text, this.Font, drawBrush, rectF, sf);
        }
    }
    }
