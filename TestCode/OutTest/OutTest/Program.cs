using System;

namespace Fourth
{
    class Program
    {
        //ref Må være initialisert
        /////
        //out Kan initialiseres inni en metode

        static void Main()
        {
            int a;
            FixA(out a);
            Console.WriteLine(a);

            Console.WriteLine("press enter...");
            Console.ReadLine();
        }

        private static void FixA(out int a)
        {
            a = 55;
            a = a * a;
        }
    }
}
