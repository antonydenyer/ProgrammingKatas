using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_18_BinaryTriangle
{
    [TestFixture]
    public class BinaryTriangleTest
    {
        //had a little help from http://blogs.sun.com/malkit/entry/euler_problem_18_and_67

        List<List<int>> triangle = new List<List<int>>();

        [SetUp]
        public void Setup()
        {
            triangle.Add(new List<int>() { 75 });
            triangle.Add(new List<int>() { 95, 64 });
            triangle.Add(new List<int>() { 17, 47, 82 });
            triangle.Add(new List<int>() { 18, 35, 87, 10 });
            triangle.Add(new List<int>() { 20, 04, 82, 47, 65 });
            triangle.Add(new List<int>() { 19, 01, 23, 75, 03, 34 });
            triangle.Add(new List<int>() { 88, 02, 77, 73, 07, 63, 67 });
            triangle.Add(new List<int>() { 99, 65, 04, 28, 06, 16, 70, 92 });
            triangle.Add(new List<int>() { 41, 41, 26, 56, 83, 40, 80, 70, 33 });
            triangle.Add(new List<int>() { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 });
            triangle.Add(new List<int>() { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 });
            triangle.Add(new List<int>() { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 });
            triangle.Add(new List<int>() { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 });
            triangle.Add(new List<int>() { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 });
            triangle.Add(new List<int>() { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 });

        }

        [TestCase]
        public void should_find_maximum_total_from_the_top_to_bottom_of_tree()
        {
            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                var row = triangle[i];
                var previousRow = triangle[i + 1];

                for (int j = 0; j < row.Count; j++)
                {
                    row[j] = row[j] + Math.Max(previousRow[j], previousRow[j + 1]);
                }
            }

            Assert.That(triangle.First().First(), Is.EqualTo(1074));
        }


    }
}
