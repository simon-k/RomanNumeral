using System;

namespace RomanNumeral
{
    public class RomanNumeral
    {
        private readonly int _value;

        public RomanNumeral(int value)
        {
           if (IsValueOutOfRange(value))
            {
                throw new ArgumentOutOfRangeException();
            }
            _value = value;
        }

        public RomanNumeral(string value)
        {
            throw new NotImplementedException();
        }

        public int ToInt()
        {
            return _value;
        }

        private bool IsValueOutOfRange(int value)
        {
            return (value < 1) || (value > 3999);
        }
    }
}
