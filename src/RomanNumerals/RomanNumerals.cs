using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class RomanNumeral
    {
        private readonly int _arabicNumber;
        
        //it seems simplier to specify out layers rather than calculating the 4,9 and 40 etc
        private readonly Dictionary<int, string> _numeralMapping = new Dictionary<int, string>
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {10, "X"},
                {40, "XL"},
                {50, "L"},
                {90, "XC"},
                {100, "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},
                {1000, "M"},
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
                remainder -= largestNumeral.Key;
                romanNumeral += largestNumeral.Value;
            
            } while (remainder > 0);

            return romanNumeral;
        }

        private KeyValuePair<int,string> GetLargestNumeral(int arabicNumber)
        {
            return
                _numeralMapping.Where(x => x.Key <= arabicNumber).OrderByDescending(x => x.Key).
                    First();
        }
    }
}
