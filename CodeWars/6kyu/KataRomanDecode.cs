/* 
 * Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.
 * Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. 
 * So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.
 * https://www.codewars.com/kata/51b6249c4612257ac0000005/train/csharp
 */

namespace CodeWars._6kyu
{
	internal class KataRomanDecode
	{
		private static Dictionary<char, int> map = new()
		{
			{ 'I', 1 },
			{ 'V', 5 },
			{ 'X', 10 },
			{ 'L', 50 },
			{ 'C', 100 },
			{ 'D', 500 },
			{ 'M', 1000 }
		};
		internal static int RomanDecode(string roman)
		{
			if (roman == null) return -1;
			int dec = 0;

			for (int i = 0; i < roman.Length; i++)
			{
				if (i + 1 < roman.Length && Comapare(roman[i], roman[i + 1])) dec -= map[roman[i]];
				else dec += map[roman[i]];
			}
			return dec;
		}

		private static bool Comapare(char v1, char v2)
		{
			return map[v1] < map[v2];
		}
	}
}
