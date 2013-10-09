using System;

namespace DateTest
{
    class Program
    {
        static void Main()
        {
            var start = new Date {Day = 18, Month = 6, Year = 2012, Hour = 12, Minute = 0};
            const string a = "Meeting starts:";
            Console.WriteLine("{0,15} {1,2}/{2}-{3,4} {4,2}:{5:D2}",a, start.Day, start.Month, start.Year, start.Hour, start.Minute);
            var end = start;
            end.Hour += 2;
            const string b = "ends:";
            Console.WriteLine("{0,15} {1,2}/{2}-{3,4} {4,2}:{5:D2}", b, end.Day, end.Month, end.Year, end.Hour, end.Minute);

            Console.WriteLine("press enter...");
            Console.ReadLine();
        }
    }
}
