using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenDigital.Kata.Euler.Problems.Problem_007_PrimeNumbers
{
    class PrimeNumberGenerator
    {
        private List<int> _primeNumbers;

        public IEnumerable<int> Generate(int numberOfPrimes)
        {
            _primeNumbers = new List<int> { 2 };
            int numberToTest = 3;

            while (_primeNumbers.Count < numberOfPrimes)
            {
                if (IsPrime(numberToTest))
                {
                    _primeNumbers.Add(numberToTest);
                }
                numberToTest += 2;
            }
            return _primeNumbers;
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
    }
}
