using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._8kyu
{
	internal class KataDifferenceInAges
	{
		public static int[] DifferenceInAges(int[] ages)
		{
			int difference,
				minAge = ages[0],
				maxAge = ages[0];

			for (int i = 0; i < ages.Length; i++)
			{
				if (ages[i] <= minAge) minAge = ages[i];
				else if (ages[i] >= maxAge) maxAge = ages[i];
			}

			difference = maxAge - minAge;
			int[] arr = new int[3] { minAge, maxAge, difference };
			return arr;
		}
	}
}
