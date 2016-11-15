using System.Collections.Generic;

namespace RomanNumerals
{
    public class Rule
    {
        private Dictionary<int, string> _numeralDictionary;
        private Applicability _applicabilityTester;

        public Rule(Dictionary<int, string> numeralDictionary, Applicability applicabilityTester)
        {
            _numeralDictionary = numeralDictionary;
            _applicabilityTester = applicabilityTester;
        }


        public string AppyRule(int numeral, string romanNumeralsString)
        {
            if (IsApplicable(numeral))
            {
                romanNumeralsString += _numeralDictionary.ContainsKey(numeral) ? _numeralDictionary[numeral] : "";
            }
            return romanNumeralsString;
        }


        private bool IsApplicable(int numeral)
        {
            return _applicabilityTester.IsApplicable(numeral);
        }
    }
}