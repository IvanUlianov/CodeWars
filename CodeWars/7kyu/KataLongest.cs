/*Take 2 strings s1 and s2 including only letters from ato z. 
 * Return a new sorted string, the longest possible, 
 * containing distinct letters - each taken only once - coming from s1 or s2. 
 */
namespace CodeWars._7kyu
{
	internal class KataLongest
	{
		public static string Longest(string s1, string s2)
		{
			#region Best Practices
			//return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
			#endregion

			string temp = s1 + s2;
			char[] k = temp.Distinct().ToArray();
			Array.Sort(k);
			string str = new(k);

			return str;
		}
	}
}
