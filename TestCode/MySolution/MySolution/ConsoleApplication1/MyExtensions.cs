using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	static class MyExtensions
	{
		public static int Tripple(this int a)
		{
			return a * 3;
		}

		public static string Reverse(this string s)
		{
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}

		public static string Repeat(this string s, int reps)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < reps; i++)
			{
				sb.Append(s);
			}

			return sb.ToString();
		}

		//public static void Fire<T>(this EventHandler<T> eventHandler, object sender, T eventArgs )
		//{
		//    if (eventHandler != null)
		//    {
		//        eventHandler(sender, eventArgs);
		//    }
		//}
	}
}
