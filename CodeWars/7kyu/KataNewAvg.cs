/* The accounts of the "Fat to Fit Club (FFC)" association are supervised by John as a volunteered accountant. The association is funded through financial donations from generous benefactors. 
 * John has a list of the first n donations: [14, 30, 5, 7, 9, 11, 15] He wants to know how much the next benefactor should give to the association so that the average of the first n + 1 donations should reach an average of 30. 
 * After doing the math he found 149. He thinks that he made a mistake. Could you help him? 
 * 
 * [14, 30, 5, 7, 9, 11, 15] => 91 
 * arr.length = 7 
 * average = 13
 * 8 * 30 = 240
 * 240 - 91 = 149
 */

namespace CodeWars._7kyu
{
	internal class KataNewAvg
	{
		public static long NewAvg(double[] arr, double navg)
		{
			#region Best Practices
			//var donation = (arr.Length + 1) * navg - arr.Sum();
			//if (donation <= 0)
			//{
			//	throw new ArgumentException();
			//}
			//return (long)Math.Ceiling(donation);
			#endregion

			double correctSum = (arr.Length + 1) * navg;
			double sumAvg = 0;

			foreach (var item in arr)
			{
				sumAvg += item;
			}

			double newAvg = correctSum - sumAvg;
			long a = (long)Math.Ceiling(newAvg);

			if (newAvg <= 0)
			{
				throw new ArgumentException(String.Format("ValueError or invalid_argument or argument-error or DomainError"));
			}
			return a;
		}
	}
}
