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
            string romanNumeralString = "";
            
            romanNumeralString = _converter.Convert(numeral, romanNumeralString);

            return romanNumeralString;
        }
        
    }
}