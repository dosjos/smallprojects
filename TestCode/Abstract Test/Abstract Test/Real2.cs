using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Test 
{
    class Real2 : Abs2
    {
        public Real2()
            : base()
        {

        }
        public Real2(String s)
            : base(s)
        {
            Console.WriteLine("Real2 " + s);
        }
    }
}
