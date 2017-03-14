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

        [Fact]
        public void StringConstructor_IsNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => new RomanNumeral(""));
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
        public void ToRomanNumeral_ConstructedWithValudInteger_ReturnsExpectedRomanNumeral(int value, string expectedRomanNumeral)
        {
            var romanNumeral = new RomanNumeral(value);
            Assert.Equal(expectedRomanNumeral, romanNumeral.ToRomanNumeral());
        }
    }
}
