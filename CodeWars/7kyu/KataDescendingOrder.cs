using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7kyu
{
	/*
	 * Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. 
	 * Essentially, rearrange the digits to create the highest possible number.
	 */
	internal class KataDescendingOrder
	{
		public static int DescendingOrder(int num)
		{ 
			// return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

			var srs = num.ToString().Select(q => int.Parse(new string(q, 1))).ToArray();
			Array.Sort(srs);
			Array.Reverse(srs);

			int value = 0;
			for (int i = 0; i < srs.Length; i++)
			{
				value *= 10;
				value += srs[i];
			}

			return value;


			return 0;
		}
	}
}
