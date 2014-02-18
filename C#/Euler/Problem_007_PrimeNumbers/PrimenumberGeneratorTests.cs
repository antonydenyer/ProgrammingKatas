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
            Assert.That(result, Is.EqualTo(2));
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

        [Test]
        public void really_big_prime_is_104743()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.Generate(30001).Last();
            Assert.That(result, Is.EqualTo(350381));
        }

        [Test]
        public void mad_really_big_prime_is_4256249()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.Generate(300001).Last();
            Assert.That(result, Is.EqualTo(4256249));
        }

        [Test]
        public void primes_from_two()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.GenerateBetween(2, 2).First();
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void primes_from_two_untill_five()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.GenerateBetween(2, 5).ToList();

            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result[1], Is.EqualTo(3));
            Assert.That(result[2], Is.EqualTo(5));
        }


        [Test]
        public void primes_from_104742()
        {
            var generator = new PrimeNumberGenerator();
            var result = generator.GenerateBetween(104742, 104743).First();
            Assert.That(result, Is.EqualTo(104743));
        }
    }
}
