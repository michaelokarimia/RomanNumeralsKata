using System;

namespace RomanNumerals
{
    public class Rule
    {
        private Applicability _applicabilityTester;
        private Func<int,string> _ruleToExecute;

        public Rule(Applicability applicabilityTester, Func<int, string> ruleToExecute)
        {
            
            _applicabilityTester = applicabilityTester;
            _ruleToExecute = ruleToExecute;
        }

        public string AppyRule(int numeral, string returnString)
        {
            if (IsApplicable(numeral))
            {
                returnString += RuleToExecute(numeral);
            }
            return returnString;
        }

        private string RuleToExecute(int numeral)
        {
            return _ruleToExecute(numeral);
        }


        private bool IsApplicable(int numeral)
        {
            return _applicabilityTester.IsApplicable(numeral);
        }
    }
}