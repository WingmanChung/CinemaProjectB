<<<<<<< Updated upstream
﻿class Program
{
    public static int[] Range(int min, int max)
    {
        int[] arr = new int[max - min];
        for (int i = 0, j = min; i < arr.Length; i++, j++)
        {
            arr[i] = j;
        }
        return arr;
    }

    public static int[] PowersOf(int v, int howMany)
    {
        int[] arr = new int[howMany];
        for (int i = 1; i < arr.Length; i++)
        {
            arr[0] = 1;
            arr[i] = arr[i - 1] * v;
        }
        return arr;
    }

    public static void Main()
    {
        var rangeVal1 = Range(3, 7);
        var rangeVal2 = Range(-1, 5);
        var powersOf2 = PowersOf(2, 5);
        var powersOf3 = PowersOf(3, 4);
    }
} 
=======
﻿using System;
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
>>>>>>> Stashed changes
