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
                Assert.That(result.ToNumeral(), Is.EqualTo("I"));
            }

            [Test]
            public void should_return_II_for_2()
            {
                var result = new RomanNumeral(2);
                Assert.That(result.ToNumeral(), Is.EqualTo("II"));
            }

            [Test]
            public void should_return_V_for_5()
            {
                var result = new RomanNumeral(5);
                Assert.That(result.ToNumeral(), Is.EqualTo("V"));
            }

            [Test]
            public void should_return_VI_for_6()
            {
                var result = new RomanNumeral(6);
                Assert.That(result.ToNumeral(), Is.EqualTo("VI"));
            }

            [Test]
            public void should_return_IV_for_4()
            {
                var result = new RomanNumeral(4);
                Assert.That(result.ToNumeral(), Is.EqualTo("IV"));
            }

            [Test]
            public void should_return_IX_for_9()
            {
                var result = new RomanNumeral(9);
                Assert.That(result.ToNumeral(), Is.EqualTo("IX"));
            }

            [Test]
            public void should_return_XLIX_for_49()
            {
                var result = new RomanNumeral(49);
                Assert.That(result.ToNumeral(), Is.EqualTo("XLIX"));
            }

            [Test]
            public void should_return_XCIX_for_99()
            {
                var result = new RomanNumeral(99);
                Assert.That(result.ToNumeral(), Is.EqualTo("XCIX"));
            }

            [Test]
            public void should_return_bbc_format_for_1999()
            {
                var result = new RomanNumeral(1999);
                Assert.That(result.ToNumeral(), Is.EqualTo("MCMXCIX"));
            }
        }

        [TestFixture]
        public class when_converting_an_roman_numeral_to_an_integer
        {
            [Test]
            public void should_return_1_for_I()
            {
                var result = new RomanNumeral("I");
                Assert.That(result.ToInt(), Is.EqualTo(1));
            }

            [Test]
            public void should_return_2_for_II()
            {
                var result = new RomanNumeral("II");
                Assert.That(result.ToInt(), Is.EqualTo(2));
            }

            [Test]
            public void should_return_4_for_IV()
            {
                var result = new RomanNumeral("IV");
                Assert.That(result.ToInt(), Is.EqualTo(4));
            }

            [Test]
            public void should_return_9_forIX()
            {
                var result = new RomanNumeral("IX");
                Assert.That(result.ToInt(), Is.EqualTo(9));
            }

            [Test]
            public void should_return_XLIX_for_49()
            {
                var result = new RomanNumeral("XLIX");
                Assert.That(result.ToInt(), Is.EqualTo(49));
            }

            [Test]
            public void should_return_99_for_XCIX()
            {
                var result = new RomanNumeral("XCIX");
                Assert.That(result.ToInt(), Is.EqualTo(99));
            }

            [Test]
            public void should_return_1999_for_bbc()
            {
                var result = new RomanNumeral("MCMXCIX");
                Assert.That(result.ToInt(), Is.EqualTo(1999));
            }
        }
    }
}
