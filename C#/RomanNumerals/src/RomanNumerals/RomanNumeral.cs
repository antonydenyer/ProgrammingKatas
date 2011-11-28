using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        private readonly string _romanNumeral;
        private readonly int _arabicNumber;

        //it seems simplier to specify out layers rather than calculating the 4,9 and 40 etc
        private readonly List<RomanNumeralMap> _numeralMapping = new List<RomanNumeralMap>
            {
                new RomanNumeralMap(1, "I"),
                new RomanNumeralMap(4, "IV"),
                new RomanNumeralMap(5, "V"),
                new RomanNumeralMap(9, "IX"),
                new RomanNumeralMap(10, "X"),
                new RomanNumeralMap(40, "XL"),
                new RomanNumeralMap(50, "L"),
                new RomanNumeralMap(90, "XC"),
                new RomanNumeralMap(100, "C"),
                new RomanNumeralMap(400, "CD"),
                new RomanNumeralMap(500, "D"),
                new RomanNumeralMap(900, "CM"),
                new RomanNumeralMap(1000, "M"),
            };


        public RomanNumeral(int arabicNumber)
        {
            _arabicNumber = arabicNumber;
        }

        public RomanNumeral(string romanNumeral)
        {
            _romanNumeral = romanNumeral;
        }


        public string ToNumeral()
        {
            return ToRomanNumeral(_arabicNumber);
        }

        public int ToInt()
        {
            return ParseRomanNumeral(_romanNumeral);
        }

        private int ParseRomanNumeral(string romanNumeral)
        {
            var arabicNumber = 0;

            var numeralArray = romanNumeral.ToCharArray();

            for (var i = numeralArray.Length - 1; i >= 0; i--)
            {
                if (i > 0 && ContainsNumeral(DuoNumeral(numeralArray[i - 1], numeralArray[i])))
                {
                    arabicNumber += GetintegerForNumeral(DuoNumeral(numeralArray[i - 1], numeralArray[i]));
                    i--;
                }
                else
                {
                    arabicNumber += GetintegerForNumeral(numeralArray[i].ToString());
                }
            }

            return arabicNumber;
        }

        public bool ContainsNumeral(string numeral)
        {
            return GetNumeral(numeral) != null;
        }

        private int GetintegerForNumeral(string numeral)
        {
            return GetNumeral(numeral).ArabicNumber;
        }

        private static string DuoNumeral(char one, char two)
        {
            return string.Format("{0}{1}", one, two);
        }

        private RomanNumeralMap GetNumeral(string numeral)
        {
            return _numeralMapping.Where(x => x.RomanNumeral == numeral).FirstOrDefault();
        }

        private string ToRomanNumeral(int arabicNumber)
        {
            var romanNumeral = string.Empty;
            var remainder = arabicNumber;

            do
            {
                var largestNumeral = GetLargestNumeral(remainder);
                remainder -= largestNumeral.ArabicNumber;
                romanNumeral += largestNumeral.RomanNumeral;

            } while (remainder > 0);

            return romanNumeral;
        }

        private RomanNumeralMap GetLargestNumeral(int arabicNumber)
        {
            return
                _numeralMapping.Where(x => x.ArabicNumber <= arabicNumber).OrderByDescending(x => x.ArabicNumber).
                    First();
        }

    }
}
