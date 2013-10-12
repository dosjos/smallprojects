using System;
using System.Threading;

namespace Filosofer
{
    class Program
    {
        static void Main()
        {
            var fen = new Fork();
            var fto = new Fork();
            var ftre = new Fork();
            var ffire = new Fork();
            var ffem = new Fork();


            var en = new Philosof(fen, fto, 1);
            var to = new Philosof(fto,ftre,2);
            var tre = new Philosof(ftre,ffire,3);
            var fire= new Philosof(ffire,ffem,4);
            var fem = new Philosof(ffem,fen,5);



            while (true)
            {
                en.WhatDo();
                to.WhatDo();
                tre.WhatDo();
                fire.WhatDo();
                fem.WhatDo();
                Console.WriteLine("--------------------------");
                Thread.Sleep(1000);
            }



            //Thread a = new Thread(en.WhatDo);
            //Thread b = new Thread(to.WhatDo);
            //Thread c = new Thread(tre.WhatDo);
            //Thread d = new Thread(fire.WhatDo);
            //Thread e = new Thread(fem.WhatDo);

            //a.Start();
            //Thread.Sleep(5);

            //b.Start();

            //Thread.Sleep(5);
            //c.Start();
            //Thread.Sleep(5);
            //d.Start();
            //Thread.Sleep(5);
            //e.Start();


        }
    }

    public class Fork
    {
        public bool InUse { get; set; }
    }

    public class Philosof
    {
        public  Fork Left { get; set; }
        public  Fork Right { get; set; }
        public int Nr { get; set; }

        private enum State
        {
            Eating,
            Thinking
        };

        private State _action;
        public Philosof(Fork right, Fork left, int i)
        {
            Right = right;
            Left = left;
            _action = State.Thinking;
            Nr = i;
        }

        public void WhatDo()
        {
            
                if (!Left.InUse && !Right.InUse && _action == State.Thinking)
                {
                    _action = State.Eating;
                    Right.InUse = true;
                    Left.InUse = true;
                    Console.WriteLine("Philosofer #{0} is now eating", Nr);
                }
                else if (_action == State.Eating)
                {
                    Right.InUse = false;
                    Left.InUse = false;
                    _action = State.Thinking;
                    Console.WriteLine("Philosofer #{0} is now Thinking", Nr);
                }
            }
        

    }

}
