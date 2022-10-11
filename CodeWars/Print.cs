namespace CodeWars
{
	internal class Print
	{
		internal void PrintArray<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
			Console.WriteLine();
		}
	}
}
