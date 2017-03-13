using System;

namespace RomanNumeral
{
    public class RomanNumeral
    {
        private readonly int _value;

        public RomanNumeral(int value)
        {
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
    }
}
