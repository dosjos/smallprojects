using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            const int a = 33;
            const int b = 44;
            var res = String.Format("{0,4:f2} + {1,4:f2} = {2,4:f2}", a, b, a + b);
            Console.WriteLine(res);


            const string firstName = "Petter";
            const string lastName = "Pettersen";

            var p = new Person {FirstName = firstName, LastName = lastName, Birthday = 1980};
            
            int alder = p.BeregnAlder();
            
            Console.WriteLine("Alder på mannen er " + alder);
            
            Console.WriteLine("Enter for å avslutte lille venn...");
            Console.ReadLine();
        }
    }
}
