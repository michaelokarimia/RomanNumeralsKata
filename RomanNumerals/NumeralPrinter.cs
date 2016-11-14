using System.Collections.Generic;

namespace RomanNumerals
{
    public class NumeralPrinter
    {
        private NumeralConverter _converter;

        public NumeralPrinter(Dictionary<int,string> rules)
        {
            _converter = new NumeralConverter(rules);
        }

        public string Print(int numeral)
        {
            return _converter.Convert(numeral);
        }
        
    }
}