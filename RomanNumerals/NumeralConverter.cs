using System.Collections.Generic;

namespace RomanNumerals
{
    public class NumeralConverter
    {
        Dictionary<int, string> _ruleDictionary;

        public NumeralConverter(Dictionary<int,string> ruleDictionary)
        {
            _ruleDictionary = ruleDictionary;
        }

        public string Convert(int numeral)
        {
            

            return _ruleDictionary.ContainsKey(numeral) ? _ruleDictionary[numeral]: "";
        }
    }
}