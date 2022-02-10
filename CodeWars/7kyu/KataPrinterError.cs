
namespace CodeWars._7kyu
{
	internal class KataPrinterError
	{
		public static string PrinterError(string s)
		{
			#region Best Practices
			//return s.Where(c => c > 'm').Count() + "/" + s.Length;
			#endregion

			char[] arrChar = s.ToCharArray();
			char cheсk = 'm';
			int count = 0,
				arrLength = arrChar.Length;

			for (int i = 0; i < arrChar.Length; i++)
			{
				if (arrChar[i] > cheсk) count++;
			}

			return $"{count}/{arrLength}";
		}
	}
}
