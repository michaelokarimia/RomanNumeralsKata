using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class NumeralPrinterTests
    {

        [TestCase(1,"i")]
        [Test]
        public void Converts_1_into_i(int arabicNumeral, string expectedNumeral)
        {
            Assert.That(NumeralPrinter.Print(arabicNumeral), Is.EqualTo(expectedNumeral));
        }
    }
}
