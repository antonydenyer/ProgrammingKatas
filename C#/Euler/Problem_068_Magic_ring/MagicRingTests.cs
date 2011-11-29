using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_068_Magic_ring
{
	[TestFixture]
	class MagicRingTests
	{


		[Test]
		public void example_3_gon_ring()
		{
			string actual = Calcaulate_maximum_string_for_ring(9, 12, 3, 3);
			Assert.That(actual, Is.EqualTo("432621513"));
		}

		private string Calcaulate_maximum_string_for_ring(int minTotal, int maxTotal, int ringSize, int nodeSize)
		{

			for (int i = 1; i <= 6; i++)
			{

			}


			return "";
		}
	}
}
