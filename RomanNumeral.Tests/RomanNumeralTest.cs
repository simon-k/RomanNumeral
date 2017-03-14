using System;
using Xunit;

namespace RomanNumeral.Tests
{
    public class RomanNumeralTest
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(4000)]
        public void IntegerConstructor_ThrowsExceptionIfConstructedWithIllegalValues(int illegalValue)
        {
            var expectedMessage = "Roman Numeral must be between 1 and 3999";

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new RomanNumeral(illegalValue));

            Assert.Contains(expectedMessage, exception.Message);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3999)]
        public void ToInt_ConstructedWithValidInteger_ReturnsIntegerValue(int expectedValue)
        {
            var romanNumeral = new RomanNumeral(expectedValue);
            var actualValue = romanNumeral.ToInt();

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(90, "XC")]
        [InlineData(1999, "MCMXCIX")]
        [InlineData(2444, "MMCDXLIV")]
        [InlineData(3999, "MMMCMXCIX")]
        public void ToString_ConstructedWithValudInteger_ReturnsExpectedString(int value, string expectedRomanNumeral)
        {
            var romanNumeral = new RomanNumeral(value);
            Assert.Equal(expectedRomanNumeral, romanNumeral.ToString());
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("XC", 90)]
        [InlineData("MCMXCIX", 1999)]
        [InlineData("MMCDXLIV", 2444)]
        [InlineData("MMMCMXCIX", 3999)]
        public void ToInt_ConstructedWithValidString_ReturnsExpectedInteger(string value, int expectedInteger)
        {
            var romanNumeral = new RomanNumeral(value);
            Assert.Equal(expectedInteger, romanNumeral.ToInt());
        }
    }
}
