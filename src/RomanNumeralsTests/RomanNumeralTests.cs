using NUnit.Framework;

namespace RomanNumerals.Tests
{
    class RomanNumeralTests
    {
        [TestFixture]
        public class when_converting_an_integer_to_a_roman_numeral
        {
            [Test]
            public void should_return_I_for_1()
            {
                var result = new RomanNumeral(1);
                Assert.That(result.ToString(), Is.EqualTo("I"));
            }

            [Test]
            public void should_return_II_for_2()
            {
                var result = new RomanNumeral(2);
                Assert.That(result.ToString(), Is.EqualTo("II"));
            }

            [Test]
            public void should_return_V_for_5()
            {
                var result = new RomanNumeral(5);
                Assert.That(result.ToString(), Is.EqualTo("V"));
            }

            [Test]
            public void should_return_VI_for_6()
            {
                var result = new RomanNumeral(6);
                Assert.That(result.ToString(), Is.EqualTo("VI"));
            }

            [Test]
            public void should_return_IV_for_4()
            {
                var result = new RomanNumeral(4);
                Assert.That(result.ToString(), Is.EqualTo("IV"));
            }

            [Test]
            public void should_return_IX_for_9()
            {
                var result = new RomanNumeral(9);
                Assert.That(result.ToString(), Is.EqualTo("IX"));
            }

            [Test]
            public void should_return_XLIX_for_49()
            {
                var result = new RomanNumeral(49);
                Assert.That(result.ToString(), Is.EqualTo("XLIX"));
            }

            [Test]
            public void should_return_XCIX_for_99()
            {
                var result = new RomanNumeral(99);
                Assert.That(result.ToString(), Is.EqualTo("XCIX"));
            }

            [Test]
            public void should_return_bbc_format_for_1999()
            {
                var result = new RomanNumeral(1999);
                Assert.That(result.ToString(), Is.EqualTo("MCMXCIX"));
            }
        }
    }
}
