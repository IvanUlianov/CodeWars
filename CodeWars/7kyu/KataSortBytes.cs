/*
 * Implement a function that takes an unsigned 32 bit integer as input and sorts its bytes in descending order, 
 * returning the resulting (unsigned 32 bit) integer.	
 * An alternative way to state the problem is as follows: The number given as input is made up of four bytes. 
 * Reorder these bytes so that the resulting (unsigned 32 bit) integer is as large as possible.
 * https://www.codewars.com/kata/6076d4edc7bf5d0041b31dcf/train/csharp
 */

namespace CodeWars._7kyu
{
	internal class KataSortBytes
	{
		public static uint SortBytes(uint number)
		{
			#region Best Practices
			
			//var bytes = BitConverter.GetBytes(number);
			//Array.Sort(bytes);
			//return BitConverter.ToUInt32(bytes);

			#endregion

			string binary = Convert.ToString(number, 2);

			String st = binary;
			if (st.Length < 32)
			{
				for (int i = 32 - st.Length; i > 0; i--) st = "0" + st;
			}

			var s = Regex.Matches(st, @".{0,8}");
			var array = s.Cast<Match>().Select(e => e.Value).ToArray();

			Array.Sort(array);
			Array.Reverse(array);

			string res = String.Join("", array);
			var uRes = Convert.ToUInt32(res, 2);

			return uRes;
		}
	}
}
