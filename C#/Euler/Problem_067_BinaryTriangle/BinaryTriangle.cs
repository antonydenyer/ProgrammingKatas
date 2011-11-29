using System;
using System.Collections.Generic;
using System.Linq;

namespace SevenDigital.Kata.Euler.Problems.Problem_067_BinaryTriangle
{
	public class BinaryTriangle
	{
		private readonly List<List<int>> _triangle;

		public BinaryTriangle(List<List<int>> triangle)
		{
			_triangle = triangle;
		}

		public int GetValueTotal()
		{
			var calculator = new List<int>[_triangle.Count];
			_triangle.CopyTo(calculator);

			for (int i = calculator.Length - 2; i >= 0; i--)
			{
				var row = calculator[i];
				var previousRow = calculator[i + 1];

				for (int j = 0; j < row.Count; j++)
				{
					row[j] = row[j] + Math.Max(previousRow[j], previousRow[j + 1]);
				}
			}

			return calculator.First().First();
		}
	}
}