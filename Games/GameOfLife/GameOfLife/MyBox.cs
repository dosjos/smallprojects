using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public class MyBox : PictureBox
    {
        private Board b;

        public void SetBoard(Board bb)
        {
            b = bb;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Pen pen = new Pen(Color.Black, 2);
            Brush br = new SolidBrush(Color.Black);
            for (int i = 0; i < b.grid.Length; i++)
            {
                for (int j = 0; j < b.grid[i].Length; j++)
                {
                    b.grid[i][j].Draw();
                    pen.Color = b.grid[i][j].BackColor;
                    pe.Graphics.DrawRectangle(pen, j * 4, i * 4, 2, 2);
                }
            }
        }
    }
}
