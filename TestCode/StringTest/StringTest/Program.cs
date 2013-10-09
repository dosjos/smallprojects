using System;
using System.Text;
using System.Diagnostics;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Stringbuilder VS string concat");

            Demo1();
            Console.WriteLine("Demo 1 - 2");
            Demo2();
            Console.WriteLine("press enter...");
            Console.ReadLine();
        }

        private static void Demo2()
        {
            StringBuilder sb = new StringBuilder();

            Stopwatch ss = Stopwatch.StartNew();

            for (int i = 0; i < 200000; i++)
            {
                sb.Append( ".");
            }
            String s = sb.ToString();
            Console.WriteLine(ss.Elapsed);

        }

        private static void Demo1()
        {
            string s = "";
            Stopwatch clock = Stopwatch.StartNew();
            for (int i = 0; i < 200000; i++)
            {
                s += ".";
            }
            Console.WriteLine( clock.Elapsed);
            
            Console.WriteLine(s.Length * 4);
        }
    }
}
