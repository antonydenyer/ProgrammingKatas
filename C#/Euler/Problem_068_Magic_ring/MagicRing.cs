using System.Collections.Generic;

namespace SevenDigital.Kata.Euler.Problems.Problem_068_Magic_ring
{
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