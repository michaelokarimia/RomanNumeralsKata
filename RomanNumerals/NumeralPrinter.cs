namespace RomanNumerals
{
    public class NumeralPrinter
    {
        public string Print(int numeral)
        {
            if (numeral == 1)
                return "i";
            if (numeral == 2)
                return "ii";

            return "";
        }
    }
}