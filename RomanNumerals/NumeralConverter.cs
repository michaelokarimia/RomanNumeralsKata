using System.Collections.Generic;

namespace RomanNumerals
{
    public class NumeralConverter
    {
        private RuleList _ruleList;

        public NumeralConverter(RuleList ruleList)
        {
            _ruleList = ruleList;
        }

        

        public string Convert(int numeral)
        {
            string romanNumeralsString = "";


            romanNumeralsString = _ruleList.AppyRule(numeral, romanNumeralsString);
            
            

            return romanNumeralsString;
        }
    }
}