using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	internal class KataLoveDetector
	{
		public static bool Lovefunc(int flower1, int flower2)
		{
			bool magic = true;
			bool pF1 = flower1 % 2 == 0,
				 pF2 = flower2 % 2 == 0;

			if(pF1 && pF2)
			{
				magic = false;
			}

			return magic;
		}
	}
}

