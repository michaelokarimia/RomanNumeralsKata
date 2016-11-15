using System.Collections.Generic;

namespace RomanNumerals
{
    public class Rule
    {
        private Dictionary<int, string> _numeralDictionary;

        public Rule(Dictionary<int, string> numeralDictionary)
        {
            _numeralDictionary = numeralDictionary;
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
            return _numeralDictionary.ContainsKey(numeral);
        }
    }
}