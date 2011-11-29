using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_67_BinaryTriangle
{
    [TestFixture]
    public class BinaryTriangle
    {
        //had a little help from http://blogs.sun.com/malkit/entry/euler_problem_18_and_67

        List<List<int>> triangle = new List<List<int>>();

        [SetUp]
        public void Setup()
        {
            using (StreamReader re = File.OpenText(@"C#\Euler\Problem_67_BinaryTriangle\triangle.txt"))
            {
                string input = null;
                while ((input = re.ReadLine()) != null)
                {
                    triangle.Add(ParseLine(input));
                }
            }

        }

        private List<int> ParseLine(string input)
        {
            string[] split = input.Split(' ');
            var intLine = new List<int>();

            foreach (var s in split)
            {
                intLine.Add(int.Parse(s));
            }
            return intLine;
        }

        [Test]
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

            Assert.That(triangle.First().First(), Is.EqualTo(7273));
        }


    }
}
