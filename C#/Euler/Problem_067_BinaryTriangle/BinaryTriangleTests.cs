using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_067_BinaryTriangle
{
	[TestFixture]
	public class BinaryTriangleTests
	{
		//had a little help from http://blogs.sun.com/malkit/entry/euler_problem_18_and_67

		readonly List<List<int>> _triangle = new List<List<int>>();

		[SetUp]
		public void Setup()
		{
			using (StreamReader re = File.OpenText(@"C#\Euler\Problem_067_BinaryTriangle\triangle.txt"))
			{
				string input = null;
				while ((input = re.ReadLine()) != null)
				{
					_triangle.Add(ParseLine(input));
				}
			}

		}

		private List<int> ParseLine(string input)
		{
			var split = input.Split(' ');
			return split.Select(int.Parse).ToList();
		}

		[Test]
		public void should_find_maximum_total_from_the_top_to_bottom_of_tree()
		{
			var result = new BinaryTriangle(_triangle).GetValueTotal();

			Assert.That(result, Is.EqualTo(7273));
		}


	}
}
