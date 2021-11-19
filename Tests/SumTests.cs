using CodeWars;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	internal class SumTests
	{
		[Test]
		public void SumPositives()
		{
			Assert.AreEqual(16, KataSumPositives.Sum(new[] { 6, 2, 1, 8, 10 }));
		}
	}
}

