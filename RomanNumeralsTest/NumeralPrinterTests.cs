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
        [Test]
        public void Converts_1_into_i(int arabicNumeral, string expectedNumeral)
        {
            _subject = new NumeralPrinter();
            Assert.That(_subject.Print(arabicNumeral), Is.EqualTo(expectedNumeral));
        }
    }
}
