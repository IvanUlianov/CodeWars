/*Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. 
 *The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
 *https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
 */
namespace CodeWars._6kyu
{
	internal class KataDuplicateCount
	{
		#region Best Practices
		//return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
		#endregion
		public static int DuplicateCount(string str)
		{
			return str.ToLower().ToArray().GroupBy(x => x).Where(x => x.Count() > 1).Count();
		}
	}
}
