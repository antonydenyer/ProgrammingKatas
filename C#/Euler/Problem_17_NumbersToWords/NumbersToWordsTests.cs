using System.Text;
using NUnit.Framework;

namespace SevenDigital.Kata.Euler.Problems.Problem_17_NumbersToWords
{
    public class NumbersToWordsTests
    {
        NumbersToWords _numbersToWords = new NumbersToWords();
        [TestCase]
        public void _5_returns_five()
        {
            Assert.That(_numbersToWords.Get(5), Is.EqualTo("five"));
        }

        [TestCase]
        public void _21_returns_twenty_one()
        {
            Assert.That(_numbersToWords.Get(21), Is.EqualTo("twenty one"));
        }

        [TestCase]
        public void _342_returns_three_hundred_and_forty_two()
        {
            Assert.That(_numbersToWords.Get(342), Is.EqualTo("three hundred and forty two"));
        }

        [TestCase]
        public void _300_three_hundred()
        {
            Assert.That(_numbersToWords.Get(300), Is.EqualTo("three hundred"));
        }

        [TestCase]
        public void _100_one_hundred()
        {
            Assert.That(_numbersToWords.Get(100), Is.EqualTo("one hundred"));
        }


        [TestCase]
        public void _1000_one_thousand()
        {
            Assert.That(_numbersToWords.Get(1000), Is.EqualTo("one thousand"));
        }

        [TestCase]
        public void _1_to_1000_in_words()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 1000; i++)
            {
                sb.Append(_numbersToWords.Get(i));
            }

            Assert.That(sb.ToString().Replace(" ", "").Length,
                        Is.EqualTo(21124));
        }
    }
}
