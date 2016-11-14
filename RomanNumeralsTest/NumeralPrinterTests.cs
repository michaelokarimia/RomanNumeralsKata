using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class NumeralPrinterTests
    {
        private NumeralPrinter _subject;

        [TestCase(1,"i")]
        [TestCase(2,"ii")]
        [TestCase(3,"iii")]
        [TestCase(4,"iv")]
        [Test]
        public void Converts_1_into_i(int arabicNumeral, string expectedNumeral)
        {
            _subject = new NumeralPrinter();
            Assert.That(_subject.Print(arabicNumeral), Is.EqualTo(expectedNumeral));
        }
    }
}
