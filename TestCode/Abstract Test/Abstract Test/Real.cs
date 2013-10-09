using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Test
{
    class Real : Abs
    {
        public Real()
            : base()
        {

        }
        public Real(String s)
            : base(s)
        {
            Console.WriteLine("Real " + s);
        }
    }
}
