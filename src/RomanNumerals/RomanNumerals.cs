using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class RomanNumeral
    {
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

        public new string ToString()
        {
            return ToRomanNumeral(_arabicNumber);
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
