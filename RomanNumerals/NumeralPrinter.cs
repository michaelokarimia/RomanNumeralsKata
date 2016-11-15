namespace RomanNumerals
{
    public class NumeralPrinter
    {
        private NumeralConverter _converter;

        public NumeralPrinter(RuleList ruleList)
        {
            _converter = new NumeralConverter(ruleList);
        }

        public string Print(int numeral)
        {
            return _converter.Convert(numeral);
        }
        
    }
}