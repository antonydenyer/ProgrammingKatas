using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SevenDigital.Kata.Euler.Problems.Problem_067_BinaryTriangle;

namespace SevenDigital.Kata.Euler.Problems.Problem_018_BinaryTriangle
{
	[TestFixture]
	public class BinaryTriangleTest
	{
		//had a little help from http://blogs.sun.com/malkit/entry/euler_problem_18_and_67

		readonly List<List<int>> _triangle = new List<List<int>>();

		[SetUp]
		public void Setup()
		{
			_triangle.Add(new List<int>() { 75 });
			_triangle.Add(new List<int>() { 95, 64 });
			_triangle.Add(new List<int>() { 17, 47, 82 });
			_triangle.Add(new List<int>() { 18, 35, 87, 10 });
			_triangle.Add(new List<int>() { 20, 04, 82, 47, 65 });
			_triangle.Add(new List<int>() { 19, 01, 23, 75, 03, 34 });
			_triangle.Add(new List<int>() { 88, 02, 77, 73, 07, 63, 67 });
			_triangle.Add(new List<int>() { 99, 65, 04, 28, 06, 16, 70, 92 });
			_triangle.Add(new List<int>() { 41, 41, 26, 56, 83, 40, 80, 70, 33 });
			_triangle.Add(new List<int>() { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 });
			_triangle.Add(new List<int>() { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 });
			_triangle.Add(new List<int>() { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 });
			_triangle.Add(new List<int>() { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 });
			_triangle.Add(new List<int>() { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 });
			_triangle.Add(new List<int>() { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 });

		}

		[TestCase]
		public void should_find_maximum_total_from_the_top_to_bottom_of_tree()
		{
			var result = new BinaryTriangle(_triangle).GetValueTotal();

			Assert.That(result, Is.EqualTo(1074));
		}
	}

	static class Extensions
	{
		public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
		{
			return listToClone.Select(item => (T)item.Clone()).ToList();
		}
	}
}
