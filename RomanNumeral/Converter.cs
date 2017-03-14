using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral
{
    public class Converter
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
            var highestElement = RomanNumeralTable.LastOrDefault(x => x.Key <= value);
            var remainder = value - highestElement.Key;
            if (remainder <= 0)
            {
                return highestElement.Value;
            }
            return highestElement.Value + ToRomanNumeral(remainder);
        }
    }
}
