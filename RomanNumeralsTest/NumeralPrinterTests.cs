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
        private Dictionary<int, string> _mappings;

        [SetUp]
        public void Setup()
        {
            var ruleList = new List<Rule>();


            _mappings = new Dictionary<int, string>
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
                {50,"l"},

            };

            Func<int, bool> IsLessThanorEqualTo10 = i => i <= 10 && i > 0;
            Func<int, bool> isLessThan11 = _mappings.ContainsKey;

            var applicability = new Applicability(isLessThan11);
            Func<int, RuleResult> arabicNumeralToRomanNumeral = i => _mappings.ContainsKey(i) ? new RuleResult(_mappings[i],0) : new RuleResult("",0);
            var lessThan11 = new Rule(applicability,arabicNumeralToRomanNumeral);


            var between11and40 = new Applicability(i => i > 10 && i < 40);
            Func<int, RuleResult> printNumber11To40 = i => new RuleResult(arabicNumeralToRomanNumeral(10).GetStringOutput() + arabicNumeralToRomanNumeral(i).GetStringOutput(), i-10) ;
            var ElevenToTwentyRule = new Rule(between11and40, printNumber11To40);


            var from40To49 = new Applicability(i => i >= 40 && i <=49);
            Func<int,RuleResult> print40to50 = i => new RuleResult(arabicNumeralToRomanNumeral(10).GetStringOutput() + arabicNumeralToRomanNumeral(50).GetStringOutput() +
                arabicNumeralToRomanNumeral(i-40).GetStringOutput(),0);

            var FourtytoFourtyNineRule = new Rule(from40To49,print40to50);
 

            ruleList.Add(FourtytoFourtyNineRule);
            ruleList.Add(ElevenToTwentyRule);
            ruleList.Add(lessThan11);

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
        [TestCase(21,"xxi")]
        [TestCase(31,"xxxi")]
        [TestCase(32,"xxxii")]
        [TestCase(35,"xxxv")]
        [TestCase(34,"xxxiv")]
        [TestCase(38,"xxxviii")]
        [TestCase(40,"xl")]
        [TestCase(41,"xli")]
        [TestCase(42,"xlii")]
        [TestCase(43,"xliii")]
        [TestCase(44,"xliv")]
        [TestCase(45,"xlv")]
        [TestCase(46,"xlvi")]
        [TestCase(47,"xlvii")]
        [TestCase(48,"xlviii")]
        [TestCase(49,"xlix")]
        [TestCase(50,"l")]

        [Test]
        public void Converts_1_into_i(int arabicNumeral, string expectedNumeral)
        {
            Assert.That(_subject.Print(arabicNumeral), Is.EqualTo(expectedNumeral));
        }
    }
}
