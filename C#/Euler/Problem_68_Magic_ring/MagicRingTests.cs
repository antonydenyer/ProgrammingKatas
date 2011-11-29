using System.Collections.Generic;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_68_Magic_ring
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

	internal class MagicRing
	{
		public MagicRing(int ringSize, int nodeSize)
		{
			for (int i = 0; i < ringSize; i++)
			{
				Nodes.Add(i, new int[nodeSize]);
			}

		}
		Dictionary<int, int[]> Nodes = new Dictionary<int, int[]>();
	}
}
