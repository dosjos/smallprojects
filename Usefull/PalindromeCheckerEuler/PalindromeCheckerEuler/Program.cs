using System;

namespace PalindromeCheckerEuler
{
    class Program
    {
        static void Main()
        {
            var res = 0;
            for (int i = 0; i < 1000000; i++)
            {
                if (
                IsPalindrome(string.Format("{0}", i)))
                {
                    res++;
                }
            }
            Console.WriteLine( res );
            Console.ReadLine();
        }



        public static bool IsPalindrome(string value)
        {
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            var s2 = new string(charArray);
            return String.CompareOrdinal(value, s2) == 0;
        }
    }
}
