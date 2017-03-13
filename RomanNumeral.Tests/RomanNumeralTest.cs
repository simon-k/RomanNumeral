using System;
using Xunit;

namespace RomanNumeral.Tests
{
    public class RomanNumeralTest
    {
        [Fact]
        public void IntegerConstructor_IsNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => new RomanNumeral(0));
        }

        [Fact]
        public void StringConstructor_IsNotImplemented()
        {
            Assert.Throws<NotImplementedException>(() => new RomanNumeral(""));
        }
    }
}
