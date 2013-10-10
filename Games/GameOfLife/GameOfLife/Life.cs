using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Life
    {
        public Color BackColor { get; set; }
        public Boolean Alive { get; set; }

        public void Draw()
        {
            if (Alive)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
        }
    }
}
