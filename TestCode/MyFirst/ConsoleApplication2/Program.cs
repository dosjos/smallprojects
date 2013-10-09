using System;

namespace ConsoleApplication2
{

    struct Rectangle//Structer, da vil de kopiere minneområdet, class kopierer peker på assignment
    {
        //ikke bruk struct.... DUH
        public int Height;
        public int Width;
    }
    class Program
    {
        static void Main()
        {
            var aRect = new Rectangle {Height = 10, Width = 15};
            Console.WriteLine("aRect = {0} x {1}", aRect.Height, aRect.Width);

            var bRect = aRect;
            bRect.Height = 20;
            bRect.Width = 25;
            Console.WriteLine("aRect = {0} x {1}", bRect.Height, bRect.Width);
            Console.WriteLine("aRect = {0} x {1}", aRect.Height, aRect.Width);

            Console.WriteLine("press enter...");
            Console.ReadLine();
        }
    }
}
