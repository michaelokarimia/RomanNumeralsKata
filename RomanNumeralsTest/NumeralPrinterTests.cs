using System.Collections.Generic;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class NumeralPrinterTests
    {
        private NumeralPrinter _subject;
        private Dictionary<int, string> _rules;

        [SetUp]
        public void Setup()
        {
            _rules = new Dictionary<int, string>
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

            _subject = new NumeralPrinter(_rules);

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
        [Test]
        public void Converts_1_into_i(int arabicNumeral, string expectedNumeral)
        {
            Assert.That(_subject.Print(arabicNumeral), Is.EqualTo(expectedNumeral));
        }
    }
}
