namespace CodeWars
{
	public class Programm
	{
		public static void Main()
		{
			Console.WriteLine("\n***Method  => Start\n");

			int[] nums = new int[]{1,0,2,3,0,4,5,0};
		//  int[] mums = new int[]{0,0,0,0,0,0,0,0};
			DuplicateZeros(nums);

			Console.WriteLine("\n***Method  => Ended\n");
		}

		public static void DuplicateZeros(int[] arr)
		{
			int arrLength = arr.Length;	
			int[] newArr = new int[arrLength];
			int num = 0;

			for (int i = 0; i < arrLength; i++)
			{
				newArr[i] = arr[num];
				num++;
			}

		}
	}
} 