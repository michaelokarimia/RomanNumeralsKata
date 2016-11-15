using System.Collections.Generic;

namespace RomanNumerals
{
    public class RuleList
    {
        private Dictionary<int, string> _numeralDictionary;

        public RuleList(Dictionary<int, string> numeralDictionary)
        {
            _numeralDictionary = numeralDictionary;
        }


        public string AppyRule(int numeral, string romanNumeralsString)
        {
            if (_numeralDictionary.ContainsKey(numeral))
            {
                romanNumeralsString += _numeralDictionary.ContainsKey(numeral) ? _numeralDictionary[numeral] : "";
            }
            return romanNumeralsString;
        }

        
    }
}