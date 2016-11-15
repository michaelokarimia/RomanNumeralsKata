namespace RomanNumerals
{
    public class NumeralPrinter
    {
        private NumeralConverter _converter;

        public NumeralPrinter(NumeralConverter numeralConverter)
        {
            _converter = numeralConverter;
        }

        public string Print(int numeral)
        {
            return _converter.Convert(numeral);
        }
        
    }
}