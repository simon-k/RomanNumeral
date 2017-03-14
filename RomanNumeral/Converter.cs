using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral
{
    internal class Converter
    {
        private static readonly SortedList<int, string> RomanNumeralTable = new SortedList<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" },
        };

        public static string ToRomanNumeral(int value)
        {
            var highestElement = GetHighestElementByDecimal(value);
            var remainder = value - highestElement.Key;
            if (remainder <= 0)
            {
                return highestElement.Value;
            }
            return highestElement.Value + ToRomanNumeral(remainder);
        }

        public static int ToInt(string value)
        {
            var highestElement = GetHighestElementByRomanNumeral(value);
            var remainder = value.Remove(0, highestElement.Value.Length);
            if (remainder.Length <= 0)
            {
                return highestElement.Key;
            }
            return highestElement.Key + ToInt(remainder);
        }

        private static KeyValuePair<int, string> GetHighestElementByDecimal(int value)
        {
            return RomanNumeralTable.LastOrDefault(x => x.Key <= value);
        }

        private static KeyValuePair<int, string> GetHighestElementByRomanNumeral(string value)
        {
            return RomanNumeralTable.Last(x =>
            {
                if (value.Length >= 2)
                {
                    return x.Value == value.Substring(0, 2) || x.Value == value.Substring(0, 1);
                }
                return x.Value == value.Substring(0, 1);
            });
        }
    }
}
