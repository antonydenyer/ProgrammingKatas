using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_007_PrimeNumbers
{
    [TestFixture]
    public class PrimenumberGeneratorTests
    {
        [Test]
        public void first_prime_is_2()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.Generate(1).Last();
            Assert.That(result,Is.EqualTo(2));
        }

        [Test]
        public void second_prime_is_3()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.Generate(2).Last();
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void third_prime_is_5()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.Generate(3).Last();
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void big_prime_is_104743()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.Generate(10001).Last();
            Assert.That(result, Is.EqualTo(104743));
        }
    }
}
