using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SevenDigital.Kata.Euler.Problems.Extension;

namespace SevenDigital.Kata.Euler.Problems.Problem_005_evens
{

	public class EvenlyDivisibleTests
	{
		[TestFixture]
		public class when_divinding_an_integer
		{
			[Test]
			public void With_a_divisble_number_IsDivisbleBy_should_be_true()
			{
				const int number = 10;
				var result = number.IsDivisibleBy(10);
				Assert.True(result);
			}


			[Test]
			public void With_a_no_divisble_number_IsDivisbleBy_should_be_true()
			{
				const int number = 7;
				var result = number.IsDivisibleBy(3);
				Assert.False(result);
			}
		}

		[TestFixture]
		public class when_looking_for_the_lowest_evenly_divisible
		{

			//[Test]
			//public void should_reduce_the_number_we_are_looking_for()
			//{
			//    var result = new EvenlyDivisible(1, 10);
			//    var divisors = result.LookingFor();

			//    Assert.That(divisors, Is.EquivalentTo(new[] { 10, 9, 8, 7, 6 }));
			//}


			[Test]
			public void With_any_number_between_1_and_10()
			{
				var lowestNumber = new EvenlyDivisible(1, 10).LowestNumber();

				Assert.That(lowestNumber, Is.EqualTo(232792560));
			}
		}

	}

	public class EvenlyDivisible
	{
		private readonly int _lower;
		private readonly int _upper;
		private List<int> _devisors = new List<int> {20,19,18,17,16,15,14,13,12,11 };

		public EvenlyDivisible(int lower, int upper)
		{
			_lower = lower;
			_upper = upper;
		}


		public int LowestNumber()
		{
			int maxNumber = GetMaxNumber();
			for (int numberToTest = _upper * _upper; numberToTest < maxNumber; numberToTest = numberToTest+ _upper)
			{
				var result = IsHappy(numberToTest);
				if (result)
					return numberToTest;	
			}
			return int.MinValue;
		}

		private int GetMaxNumber()
		{
			return _devisors.Aggregate(1, (current, devisor) => current*devisor);
		}

		private bool IsHappy(int numberToTest)
		{
			foreach (var devisor in _devisors)
			{
				if (!numberToTest.IsDivisibleBy(devisor))
				{
					return false;
				}
			}
			return true;
		}
	}
}
