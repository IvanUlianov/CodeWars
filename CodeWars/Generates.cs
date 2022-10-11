namespace CodeWars
{
	internal class Generates
	{
		private Random rnd = new();

		internal int[] GenerateIntRandomArray(int arrLength, int minValue, int maxValue)
		{
			int[] arr = new int[arrLength];
			for (int i = 0; i < arrLength; i++)
			{
				arr[i] = rnd.Next(minValue, maxValue);
			}

			return arr;
		}
		internal int[] GenerateOddArray(int arrLength)
		{
			int[] arr = new int[arrLength];
			int numValue = 0,
				indexValue = 0;

			while (indexValue < arr.Length)
			{
				if (numValue % 2 != 0)
				{
					arr[indexValue] = numValue;
					indexValue++;
				}
				numValue++;
			}

			return arr;
		}
		internal int[] GenerateEvenArray(int arrLength)
		{
			int[] arr = new int[arrLength];
			int i = 0,
				j = 0;

			while (j < arr.Length)
			{
				if (i % 2 == 0)
				{
					arr[j] = i;
					j++;
				}
				i++;
			}

			return arr;
		}
	}
}
