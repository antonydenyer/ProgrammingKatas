using System;

namespace SevenDigital.Kata.Euler.Problems.Problem_017_NumbersToWords
{
    class NumbersToWords
    {
        /// <summary>
        /// There's some code duplication here. 
        /// There must be recursive way to build up the string 
        /// recursively by dividing by 10 until you hit something < 100
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string Get(int number)
        {
            if (Lookup.WORDS.ContainsKey(number) && number < 100)
                return Lookup.WORDS[number];


            if (number < 100)
            {
                decimal div = (decimal)number / (decimal)10;
                int left = (int)Math.Floor(div);
                int right;
                Math.DivRem(number, 10, out right);
                return Get(left * 10) + " " + Get(right);
            }
            else if (number < 1000)
            {
                decimal div = (decimal)number / (decimal)100;
                if (Math.Round(div) == div)
                {
                    return Get((int)Math.Round(div)) + " " + Lookup.WORDS[100];
                }

                int left = (int)Math.Floor(div);
                int right;
                Math.DivRem(number, 100, out right);
                return Get(left * 100) + " and " + Get(right);
            }
            else
            {
                return "one thousand";
            }
        }
    }

}
