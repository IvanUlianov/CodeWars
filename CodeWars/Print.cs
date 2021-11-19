using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
