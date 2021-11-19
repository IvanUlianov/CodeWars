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
			#region BubbleSort
			////BubbleSort
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	for (int j = i + 1; j < arr.Length; j++)
			//	{
			//		if (arr[i] > arr[j])
			//		{
			//			int temp = arr[i];
			//			arr[i] = arr[j];
			//			arr[j] = temp;
			//		}

			//	}
			//}
			#endregion
			Array.Sort(arr);

			int sum = 0;
			for (int i = 1; i < arr.Length - 1; i++)
			{
				sum += arr[i];
			}
			return sum;
		}

		//void MinMax(int[] arr)
		//{
		//	int min = arr[0],
		//		max = arr[0];
		//	for (int i = 0; i < arr.Length; i++)
		//	{
		//		if (arr[i] <= min) min = arr[i];
		//		else if (arr[i] >= max) max = arr[i];
		//	}
		//}
	}
}
