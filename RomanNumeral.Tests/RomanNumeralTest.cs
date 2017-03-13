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
            Assert.Throws<ArgumentOutOfRangeException>(() => new RomanNumeral(illegalValue));
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


    }
}
