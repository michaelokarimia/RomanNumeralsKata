namespace RomanNumerals
{
    public class NumeralPrinter
    {
        private NumeralConverter _converter;

        public NumeralPrinter()
        {
            _converter = new NumeralConverter();
        }

        public string Print(int numeral)
        {
            var romanNumeralString = _converter.Convert(numeral);

            return romanNumeralString;
        }
        
    }
}