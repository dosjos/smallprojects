using System;

namespace EffectiveEksempler
{
    class MyCollection<T>
    {
        private readonly T[] _theValues = new T[100];
        public T this[int index]
        {
            get { return _theValues[index]; }
            set { _theValues[index] = value; }
        }
    }
    class Program
    {
       
        static void Main()
        {
            var sammling = new MyCollection<int>();
            sammling[0] = 1; // basically det samme som en arraylist..... eller et array.....

            var r = new Random();

            for (var i = 0; i < 100; i++)
            {
                sammling[i] = r.Next(i);
            }

            var sum = 0;
            for (var i = 0; i < 100; i++)
            {
                sum += sammling[i];
            }

            Console.WriteLine(sum);
            Console.ReadKey();

        }

        
    }
}
