using System;
using System.Collections.Generic;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class NumeralPrinterTests
    {
        private NumeralPrinter _subject;
        private Dictionary<int, string> _mappings1_to_10;

        [SetUp]
        public void Setup()
        {
            var ruleList = new List<Rule>();


            _mappings1_to_10 = new Dictionary<int, string>
            {
                {1,"i"},
                {2,"ii"},
                {3,"iii"},
                {4,"iv"},
                {5,"v"},
                {6,"vi"},
                {7,"vii"},
                {8,"viii"},
                {9,"ix"},
                {10,"x"},
            };

            Func<int, bool> IsLessThanorEqualTo10 = i => i <= 10;
            Func<int, bool> applicableRule = _mappings1_to_10.ContainsKey + IsLessThanorEqualTo10;

            var applicability = new Applicability(applicableRule);


            Func<int, string> actionToExecute = i => _mappings1_to_10.ContainsKey(i) ? _mappings1_to_10[i] : "";

            var lessThan11Rule = new Rule(applicability,actionToExecute);

            ruleList.Add(lessThan11Rule);


            Applicability applicabilityForRuleTwo = new Applicability(i => i > 10 && i < 21);
            Func<int, string> printNumber11To20 = i => "x" + actionToExecute(i - 10) ;


            var ElevenToTwentyRule = new Rule(applicabilityForRuleTwo, printNumber11To20);

            ruleList.Add(ElevenToTwentyRule);

            var numeralConverter = new NumeralConverter(ruleList);

            _subject = new NumeralPrinter(numeralConverter);

        }

        [TestCase(0,"")]
        [TestCase(1,"i")]
        [TestCase(2,"ii")]
        [TestCase(3,"iii")]
        [TestCase(4,"iv")]
        [TestCase(5,"v")]
        [TestCase(6,"vi")]
        [TestCase(7,"vii")]
        [TestCase(8,"viii")]
        [TestCase(9,"ix")]
        [TestCase(10,"x")]
        [TestCase(11,"xi")]
        [TestCase(12,"xii")]
        [TestCase(13,"xiii")]
        [TestCase(14,"xiv")]
        [TestCase(15,"xv")]
        [TestCase(16,"xvi")]
        [TestCase(17,"xvii")]
        [TestCase(18,"xviii")]
        [TestCase(19,"xix")]
        [TestCase(20,"xx")]
        [Test]
        public void Converts_1_into_i(int arabicNumeral, string expectedNumeral)
        {
            Assert.That(_subject.Print(arabicNumeral), Is.EqualTo(expectedNumeral));
        }
    }
}
