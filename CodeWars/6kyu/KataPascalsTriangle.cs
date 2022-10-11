/*
Here you will create the classic Pascal's triangle.
Your function will be passed the depth of the triangle and your code has to return the corresponding Pascal's triangle up to that depth.
To build the triangle, start with a single 1 at the top, for each number in the next row you just take the two numbers above it and add them together, except for the edges, which are all 1. e.g.:
https://www.codewars.com/kata/52945ce49bb38560fe0001d9/train/csharp
*/

namespace CodeWars._6kyu
{
    class PascalTriangel
    {
        public static long[][] Solution(long value)
		{
			long [][] arr = new long[value][];
			int temp = 1;

			for (int i = 0; i < value; i++)
			{
				arr[i] = new long[temp];

				for (int j = 0; j < temp; j++)
				{
					if (j==0 || j == i)
					{
						arr[i][j] = 1;
					}
					else{
						arr[i][j] = arr[i-1][j-1] + arr[i-1][j];
					}
				}

				temp++;
			}

			return arr;
        }
    }
}