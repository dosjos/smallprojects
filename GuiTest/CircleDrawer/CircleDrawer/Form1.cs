using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CircleDrawer
{
    public partial class Form1 : Form
    {
        int ballX= 0, ballY = 0;
        int stepY;
        
        Pen myPen;
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            int stepX = Height / 10;
            stepY = Width / stepX;
            label1.Text = "Width: "+ Width;
            label2.Text = "Height: " + Height;
            // Get the graphics object 
            Graphics gfx = paintEvnt.Graphics;
            // Create a new pen that we shall use for drawing the line 
            myPen = new Pen(Color.Black);
            // Loop and create a new line 10 pixels below the last one 
            int endX = 0;
            for (int i = 0; i < (Height/2); i = i + 10)
            {
                gfx.DrawLine(myPen, 0, i, endX, (Height/2));
                endX +=  stepY;
            }


            endX = 0;
            for (int i = 0; i < (Width/2); i = i + 10)
            {
                gfx.DrawLine(myPen, endX, 0, Width/2, i);
                endX += stepY;
            }


            endX = 0;
            for (int i = (Height / 2); i < Height; i = i + 10)
            {
                gfx.DrawLine(myPen, 0, i, endX, (Height - 40));
                endX += stepY;
            }
            endX = 0;
            for (int i = Height; i > Height / 2; i = i - 10)
            {
                gfx.DrawLine(myPen, 0, i, endX, (Height / 2));
                endX += stepY;
            }
            endX = 0;
            for (int i = Height; i > Height / 2; i = i - 10)
            {
                gfx.DrawLine(myPen, Width / 2, endX, i, 0);
                endX += stepY;
            }
            endX = Height / 2;
            for (int i = 0; i < Height / 2; i = i + 10)
            {
                gfx.DrawLine(myPen, i, 0, 0, endX);
                endX -= stepY;
            }

            endX = 0;
            for (int i = Height/2; i < Height; i = i + 10)
            {
                gfx.DrawLine(myPen, i, 0,Width-16, endX);
                endX += stepY;
            }

            endX = Height/2;
            for (int i = (Height / 2); i < Height; i = i + 10)
            {
                gfx.DrawLine(myPen, Width/2, i, endX, (Height - 40));
                endX += stepY;
            }
            endX = Height / 2;
            for (int i = (Height / 2); i < Height; i = i + 10)
            {
                gfx.DrawLine(myPen, Width / 2, i, endX, (Height - 40));
                endX -= stepY;
            }
            endX = Height / 2;
            for (int i = Height; i > Height/2; i = i - 10)
            {
                gfx.DrawLine(myPen, Width-16 , endX, i, Height-40);
                endX += stepY;
            }

            endX = 0;
            for (int i = Height; i > Height / 2; i = i - 10)
            {
                gfx.DrawLine(myPen, i, Height / 2, Width-16, endX);
                endX += stepY;
            }

            endX = Height/2;
            for (int i = Height / 2; i <Height; i = i + 10)
            {
                gfx.DrawLine(myPen, i, Height/2, Width - 16, endX);
                endX += stepY;
            }

            //for (int i = 0; i < Width; i += 20)
            //{
            //    gfx.DrawEllipse(myPen,(Width/2)-i/2, (Height/2)-i/2, i, i);
            //}

           // gfx.DrawEllipse(myPen, ballX, ballY, 50, 50);

           // ballX += 10;
            //ballY += stepY;
          
        
            
            //for (int i = 0; i < Height; i = i + 10)
            //{
            //    gfx.DrawLine(myPen, 0, i, Width, i);
            //}
            //// Loop and create a vertical line 10 pixels next to the last one 
            //for (int x = 0; x < Width; x = x + 10)
            //{
            //    gfx.DrawLine(myPen, x, 0, x, Height);
            //}

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Invalidate();


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
