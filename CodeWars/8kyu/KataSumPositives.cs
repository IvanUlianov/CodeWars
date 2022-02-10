using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class KataSumPositives
	{
		/// <summary>
		/// выводит сумму массива, исключая макимальное и минимальное значение
		/// </summary>
		/// <param name="arr"></param>
		/// <returns>sum</returns>
		public static int Sum(int[] arr)
		{
			Array.Sort(arr);
			int sum = 0;
			for (int i = 1; i < arr.Length - 1; i++)
			{
				sum += arr[i];
			}
			return sum;
		}
	}
}
