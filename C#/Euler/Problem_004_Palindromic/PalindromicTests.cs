using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_004_Palindromic
{
	[TestFixture]
	public class PalindromicTests
	{
		[Test]
		public void largest_two_digit_number()
		{
			var result = new Palindrome(2).Largest();

			Assert.That(result,Is.EqualTo(9009));
		}

		[Test]
		public void largest_three_digit_number()
		{
			var result = new Palindrome(3).Largest();

			Assert.That(result, Is.EqualTo(906609));
		}

		[Test]
		public void MOAR_PERFORMANCE()
		{
			long loopTicks;
			var first = new Palindrome(9999);

			loopTicks = Time(() => first.IsPalindrome("906609"), 9999);
			

			Console.WriteLine("Loop: {0}", loopTicks);
			
		}

		private long Time(Action toDo, int repetitions)
		{
			var stopwatch = new System.Diagnostics.Stopwatch();
			stopwatch.Start();
			{
				stopwatch.Start();
				for (int i = 0; i < repetitions; i ++)
				{
					toDo();
				}
			}
			stopwatch.Stop();
			return stopwatch.ElapsedTicks;
		}
	}
}
