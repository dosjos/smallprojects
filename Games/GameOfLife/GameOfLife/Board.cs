using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Board
    {
        public Life[][] grid;

        public Board()
        {
            grid = new Life[200][];
        }
    }
}
