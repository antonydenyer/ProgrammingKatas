namespace RomanNumerals
{
    public class RomanNumeralMap
    {
        private readonly int _arabicNumber;
        private readonly string _romanNumeral;

        public RomanNumeralMap(int arabicNumber, string romanNumeral)
        {
            _arabicNumber = arabicNumber;
            _romanNumeral = romanNumeral;
        }

        public string RomanNumeral
        {
            get { return _romanNumeral; }
        }

        public int ArabicNumber
        {
            get { return _arabicNumber; }
        }
    }
}