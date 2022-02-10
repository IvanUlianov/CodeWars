/* Complete the solution so that it splits the string into pairs of two characters. 
 * If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').
 * https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp
 */

namespace CodeWars._6kyu
{
	internal class KataSplitString
	{
		public static string[] Solution(string str)
		{
			#region Best Practices
			//return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
			#endregion

			Regex regular = new(".{1,2}");
			var matches = regular.Matches(str);

			var go = matches.Select(z => z.Value).ToArray();

			for (int i = 0; i < go.Length; i++)
			{
				if (go[i].Length < 2) go[i] = go[i].Insert(1, "_");
			}

			return go;
		}
	}
}
