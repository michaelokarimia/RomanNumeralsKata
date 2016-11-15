using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class Applicability
    {
        private Func<int, bool> _applicableRule;

        public Applicability(Func<int, bool> applicableRule)
        {
            _applicableRule = applicableRule;
        }

        public bool IsApplicable(int numeral)
        {
            return _applicableRule(numeral);
        }
    }
}