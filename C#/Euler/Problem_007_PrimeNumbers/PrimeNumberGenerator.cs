using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenDigital.Kata.Euler.Problems.Problem_007_PrimeNumbers
{
    class PrimeNumberGenerator
    {
        public IEnumerable<int> Generate(int numberOfPrimes)
        {
            var primeNumbers = new List<int> { 2 };
            var numberToTest = 3;

            while (primeNumbers.Count < numberOfPrimes)
            {
                if (IsPrime(numberToTest))
                {
                    primeNumbers.Add(numberToTest);
                }
                numberToTest += 2;
            }
            return primeNumbers;
        }


        private bool IsPrime(int numberToTest)
        {
            var testRange = (int)Math.Floor(Math.Sqrt(numberToTest));
            for (int i = testRange; i > 1; i--)
            {
                if (numberToTest % i == 0)
                    return false;
            }
            return true;
        }

        public IEnumerable<int> GenerateBetween(int lower, int upper)
        {
            var primeNumbers = new List<int>();
            var numberToTest = lower;

            while (numberToTest <= upper)
            {
                if (IsPrime(numberToTest))
                {
                    primeNumbers.Add(numberToTest);
                }
                numberToTest++;
            }
            return primeNumbers;
        }
    }
}
