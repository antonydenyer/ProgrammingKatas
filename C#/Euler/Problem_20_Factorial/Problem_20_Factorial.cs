using System.Linq;
using System.Numerics;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_20_Factorial
{
    [TestFixture]
    public class Problem_20_Factorial
    {
        [TestCase]
        public void Evaluate()
        {
            BigInteger factorial = Factorial(100);
            int result = 0;

            foreach (var value in factorial.ToString().ToArray())
            {
                result += int.Parse(value.ToString());
            }

            Assert.That(result, Is.EqualTo(648));
        }

        public BigInteger Factorial(BigInteger max)
        {
            if (max == 1)
                return 1;
            
            return max * Factorial(--max);
        }
    }
}
