using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._8kyu
{
	internal class KataEvenOrOdd
	{
		public static string EvenOrOdd(int number)
		{
			if (number % 2 == 0) return "Even";
			else return "Odd";
		}
	}
}
