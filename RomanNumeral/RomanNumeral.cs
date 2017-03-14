using System;

namespace RomanNumeral
{
    public class RomanNumeral
    {
        private const int MinValue = 1;
        private const int MaxValue = 3999;

        private readonly int _value;

        public RomanNumeral(int value)
        {
           if (IsValueOutOfRange(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"Roman Numeral must be between {MinValue} and {MaxValue}");
            }
            _value = value;
        }

        public RomanNumeral(string value)
        {
            _value = Converter.ToInt(value);
        }

        public int ToInt()
        {
            return _value;
        }

        public override string ToString()
        {
            return Converter.ToRomanNumeral(_value);
        }

        private bool IsValueOutOfRange(int value)
        {
            return (value < MinValue) || (value > MaxValue);
        }
    }
}
