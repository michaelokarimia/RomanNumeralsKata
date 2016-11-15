using System;

namespace RomanNumerals
{
    public class Rule
    {
        private Applicability _applicabilityTester;
        private Func<int,RuleResult> _ruleToExecute;

        public Rule(Applicability applicabilityTester, Func<int, RuleResult> ruleToExecute)
        {
            
            _applicabilityTester = applicabilityTester;
            _ruleToExecute = ruleToExecute;
        }

        public RuleResult AppyRule(int numeral)
        {
            RuleResult ruleResult = new RuleResult();

            if (IsApplicable(numeral))
            {
                 ruleResult = RuleToExecute(numeral);
            }
            return ruleResult;
        }

        private RuleResult RuleToExecute(int numeral)
        {
            return _ruleToExecute(numeral);
        }


        public bool IsApplicable(int numeral)
        {
            return _applicabilityTester.IsApplicable(numeral);
        }
    }
}