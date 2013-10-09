using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Test
{
    class Abs2 : Real
    {
        public Abs2()
            : base()
        {

        }
        public Abs2(String s)
            : base(s)
        {
            Console.WriteLine("abs " + s);
        }
    }
}
