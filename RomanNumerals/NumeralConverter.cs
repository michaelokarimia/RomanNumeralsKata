using System.Collections.Generic;

namespace RomanNumerals
{
    public class NumeralConverter
    {
        private Rule _rule;

        public NumeralConverter(Rule rule)
        {
            _rule = rule;
        }

        public string Convert(int numeral)
        {
            string romanNumeralsString = "";

            romanNumeralsString = _rule.AppyRule(numeral, romanNumeralsString);
          
            return romanNumeralsString;
        }
    }
}