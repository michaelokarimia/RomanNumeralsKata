using System.Collections.Generic;

namespace RomanNumerals
{
    public class NumeralConverter
    {
        private List<Rule> _ruleList;

        public NumeralConverter(List<Rule> ruleList)
        {
            _ruleList = ruleList;
        }

        public string Convert(int numeral)
        {
            string numeralsString = "";

            foreach (var rule in _ruleList)
            {
                while (rule.IsApplicable(numeral))
                {
                    var result = rule.AppyRule(numeral);

                    numeralsString += result.GetStringOutput();
                    numeral = result.GetNewNumeral();
                }
            }

            return numeralsString;
        }
    }
}