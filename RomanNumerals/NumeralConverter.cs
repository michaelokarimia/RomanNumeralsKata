using System.Collections.Generic;

namespace RomanNumerals
{
    public class NumeralConverter
    {
        public string Convert(int numeral)
        {
            var ruleDictionary = new Dictionary<int, string>
            {
                {1,"i"},
                {2,"ii"},
                {3,"iii"},
                {4,"iv"}
            };

            return ruleDictionary.ContainsKey(numeral) ? ruleDictionary[numeral]: "";
        }
    }
}