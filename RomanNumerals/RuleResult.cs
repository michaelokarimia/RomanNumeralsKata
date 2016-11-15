namespace RomanNumerals
{
    public class RuleResult
    {
        private int _arabicNumber;
        private string returnString;

        public RuleResult()
        {
        }

        public RuleResult(string returnString, int arabicNumber)
        {
            this.returnString = returnString;
            this._arabicNumber = arabicNumber;
        }

        public string GetStringOutput()
        {
            return returnString;
        }

        public int GetNewNumeral()
        {
            return _arabicNumber;
        }
    }
}