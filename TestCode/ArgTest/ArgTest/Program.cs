using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int nedover;
                int bortover;
                if(!int.TryParse(args[0], out nedover) || !int.TryParse(args[1], out bortover))
                {
                    System.Environment.Exit(1);
                }

                int x = int.Parse(args[0]);
                int y = int.Parse(args[1]);

                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= y; j++)
                    {
                        Console.Write("{0,4} |",i*j);
                        #region CROSSING SWORDS
                        if (i == 1 && j == y)
                        {
                            Console.WriteLine();
                          //  Console.Write("  ");
                            for (int k = 0; k < y; k++)
                            {
                             Console.Write("-----+");   
                            }
                        }
                        #endregion
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry, no party rocking....");
            }

            Console.WriteLine("press enter...");
            Console.ReadLine();
        }
    }
}
