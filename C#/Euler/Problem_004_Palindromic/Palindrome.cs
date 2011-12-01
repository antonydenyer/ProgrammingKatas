using System;
using System.Collections.Generic;
using System.Linq;

namespace SevenDigital.Kata.Euler.Problems.Problem_004_Palindromic
{
	public class Palindrome
	{
		private readonly int _numberOfDigits;

		public Palindrome(int numberOfDigits)
		{
			_numberOfDigits = numberOfDigits;
		}

		public int Largest()
		{
			var result = AllPalindromes();
			return result.OrderByDescending(x => x).First();
		}

		public IEnumerable<int> AllPalindromes()
		{
			string highestNumberString = string.Empty;

			for (int i = 0; i < _numberOfDigits; i++)
			{
				highestNumberString += "9";
			}

			int highestNumber = Convert.ToInt32(highestNumberString);
			for (int outer = highestNumber; outer > 0 ; outer--)
			{
				for (int inner = highestNumber; inner > 0 ; inner--)
				{
					var value = outer*inner;
					if (value % 11 == 0 &&  IsPalindrome(value.ToString()))
						yield return value;
				}
			}
		}

		public bool IsPalindrome(string input)
		{
			for (int i = 0, j = input.Length - 1; i < input.Length && j >= 0; i++, j--)
			{
				if (input[i] != input[j])
					return false;
			}

			return true;
		}
	}
}