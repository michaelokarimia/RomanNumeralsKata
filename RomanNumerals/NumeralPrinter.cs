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
            return _converter.Convert(numeral);
        }
        
    }
}