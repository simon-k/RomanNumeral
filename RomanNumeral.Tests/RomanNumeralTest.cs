using System;
using Xunit;

namespace RomanNumeral.Tests
{
    public class RomanNumeralTest
    {
        [Fact]
        public void StringConstructor_IsNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => new RomanNumeral(""));
        }

        [Fact]
        public void ToInt_ConstructedWithInteger_ReturnsIntegerValue()
        {
            var expectedValue = 0;

            var romanNumeral = new RomanNumeral(expectedValue);
            var actualValue = romanNumeral.ToInt();

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
