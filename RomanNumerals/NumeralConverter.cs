namespace RomanNumerals
{
    public class NumeralConverter
    {
        public string Convert(int numeral)
        {
            var romanNumeralString = "";

            if (numeral == 1)
                romanNumeralString = "i";
            if (numeral == 2)
                romanNumeralString = "ii";
            if (numeral == 3)
                romanNumeralString = "iii";
            if (numeral == 4)
                romanNumeralString = "iv";
            return romanNumeralString;
        }
    }
}