using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7kyu
{
	/*
	   * Given the triangle of consecutive odd numbers:

					1
				3     5
			 7     9    11
		  13    15    17    19
		21    23    25    27    29

		Calculate the sum of the numbers in the nth row of this 
		triangle (starting at index 1) e.g.: (Input --> Output)

		1 -->  1
		2 --> 3 + 5 = 8

	*/

	// return n*n*n;
	internal class KataRowSumOddNumbers
	{
		public static long rowSumOddNumbers(long n)
		{
			int[][] arr = new int[n][];

			long sum = 0;
			int numValue = 1,
				k = 1;

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new int[k];
				int indexValue = 0;

				while (indexValue < arr[i].Length)
				{
					if (numValue % 2 != 0)
					{
						arr[i][indexValue] = numValue;
						indexValue++;
					}
					numValue++;
				}
				k++;
			}


			for (int j = 0; j < arr.Length; j++)
			{
				sum += arr[n - 1][j];
			}

			return sum;
		}
	}
}
