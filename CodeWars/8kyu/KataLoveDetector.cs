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
			//return flower1 % 2 != flower2 % 2 ;

			bool magic = (flower1 - flower2) % 2 != 0;
			return magic;
		}
	}
}

