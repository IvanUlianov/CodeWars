using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7kyu
{
	internal class KataLastDigit
	{
		/*
			Your job is to implement a function which returns the last D digits of an 
					integer N as a list.

			Special cases:
			If D > (the number of digits of N), return all the digits.
			If D <= 0, return an empty list.

		 */

		public static int[] LastDigit(long n, int d)
		{
			// LastDigit(long n, int d) => $"{n}".TakeLast(d).Select(c => (int)char.GetNumericValue(c)).ToArray();
			
			var arr = n.ToString().Select(q => int.Parse(new string(q, 1))).ToArray();
			if (d > n || d > arr.Length) return arr;
			if (d <= 0) return Array.Empty<int>();

			int[] retArr = new int[d];
			int count = 0;

			for (int i = arr.Length - d; i < arr.Length; i++)
			{
				retArr[count] = arr[i];
				count++;
			}
			return retArr;
		}
	}
}
