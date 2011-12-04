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
            var primes = new List<int> { 2 };
            int numberToTest = 3;

            while (primes.Count < numberOfPrimes)
            {
                if (IsPrime(numberToTest))
                {
                    primes.Add(numberToTest);
                }
                numberToTest += 2;
            }
            return primes;
        }

        private bool IsPrime(int numberToTest)
        {
            var testRange = (int)Math.Floor(Math.Sqrt(numberToTest));
            for (int i = testRange; i > 1; i--)
            {
                if(numberToTest % i ==0)
                    return false;
            }
            return true;
        }
    }
}
