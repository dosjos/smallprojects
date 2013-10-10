using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GameOfLife
{
   
    public partial class Form1 : Form
    {
        private const int Xsize = 200;
        private const int Ysize = 250;
        readonly Board _b;
        private readonly MyBox _box;
        public Form1()
        {
            InitializeComponent();
            Width = 1020;
            Height = 820;
            _b = new Board();
            _box = new MyBox {Location = new Point(0, 0), Height = Height, Width = Width};
            Controls.Add(_box);
            Populate();
            Place();
            Invalidate();

        }

        private void GameTiem()
        {
            var temp = new Board();
            for (var i = 0; i < temp.grid.Length; i++)
            {
                temp.grid[i] = new Life[250];
                for (var j = 0; j < temp.grid[i].Length; j++)
                {
                    temp.grid[i][j] = new Life();
                }
            }

            for (var i = 0; i < _b.grid.Length; i++)
            {
                for (var j = 0; j < _b.grid[i].Length; j++)
                {
                    temp.grid[i][j].Alive = _b.grid[i][j].Alive;
                    var antall = CheckCell(i, j);
                    //Debug.WriteLine(antall);
                    if (antall == 3 && !_b.grid[i][j].Alive)
                    {
                        temp.grid[i][j].Alive = true;
                    }
                    if (_b.grid[i][j].Alive && (antall < 2 || antall > 3))
                    {
                       temp.grid[i][j].Alive = false;
                    }
                }
            }
            _b.grid = temp.grid;
            _box.SetBoard(_b);
            _box.Invalidate();
        }

        private int CheckCell(int x, int y)
        {
            var antall = 0;


            if (_b.grid[Mod(x + 1, Xsize)][y].Alive)
            {
                antall++;
            }
            if (_b.grid[Mod(x + 1, Xsize)][Mod(y + 1, Ysize)].Alive)
            {
                antall++;
            }
            if (_b.grid[x][Mod(y + 1, Ysize)].Alive)
            {
                antall++;
            }
            if (_b.grid[x][Mod(y - 1, Ysize)].Alive)
            {
                antall++;
            }
            if (_b.grid[Mod(x + 1, Xsize)][Mod(y - 1, Ysize)].Alive)
            {
                antall++;
            }
            if (_b.grid[Mod(x - 1, Xsize)][y].Alive)
            {
                antall++;
            }
            if (_b.grid[Mod(x - 1, Xsize)][Mod(y - 1, Ysize)].Alive)
            {
                antall++;
            }
            if (_b.grid[Mod(x - 1, Xsize)][Mod(y + 1, Ysize)].Alive)
            {
                antall++;
            }
            

            return antall;

        }
        public static int Mod(int x, int m)
        { 
            m = Math.Abs(m);                  
            return (x % m + m) % m;
        } 

        private void Place()
        {
            _box.SetBoard(_b);
        }

        private void Populate()
        {
            var r = new Random();
            for (var i = 0; i < _b.grid.Length; i++)
            {
                _b.grid[i] = new Life[250];
                for (var j = 0; j < _b.grid[i].Length; j++)
                {
                    int l = r.Next(0, 8);
                    _b.grid[i][j] = new Life {Alive = (l == 0)};
                    _b.grid[i][j].Draw();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new Thread(Work);
            t.Start();
            Controls.Remove(button1);

        }
        public void Work()
        {
            var start = DateTime.Now;
            while (true)
            {
                if ((DateTime.Now - start).TotalMilliseconds > 100)
                {
                    start = DateTime.Now;
                    //Thread.Sleep(250);
                    GameTiem();
                    _box.Invalidate();
                    
                }
            }
        }
    }

 

    
}

