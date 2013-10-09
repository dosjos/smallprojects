using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileReadWrite
{

    //Creates a random SAMI word
    class Program
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(@".\mynewFile.txt")) { 
            var random = new Random();
            int i = 1;
            while (i != 65) {
                i = random.Next(65,92);
                sw.Write((char)i);
            }
            sw.WriteLine();
            sw.Dispose();

            var sr = new StreamReader(@".\mynewFile.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
            Console.WriteLine("press enter...");
            Console.ReadLine();
        }
    }
}
