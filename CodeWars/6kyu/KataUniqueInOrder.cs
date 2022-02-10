/*Implement the function unique_in_order which takes as argument 
 * a sequence and returns a list of items without any elements 
 * with the same value next to each other and preserving the original order of elements.
 * https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp
 */
namespace CodeWars._6kyu
{
	internal class KataUniqueInOrder
	{
		public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
		{
			var current = default(T);

			foreach (var item in iterable)
			{
				if (item.Equals(current))
					continue;

				current = item;

				yield return item;
			}
		}
	}
}
