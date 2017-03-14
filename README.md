# RomanNumerals
This solution was made in Visual Studio 2017 using .NET Core 1.1.

# About the solution
This solution implements a data type making it possible to represent a value in Roman Numeral.

Convetion from decimal to roman numeral is based on http://www.rapidtables.com/convert/number/how-number-to-roman-numerals.htm
Convetion from roman numeral to decimal is based on http://www.rapidtables.com/convert/number/how-roman-numerals-to-number.htm

# TODO
- Validate that the input in RomanNumeral.Converter.ToRomanNumeral(int) is valid
- Validate that the input in RomanNumeral.Converter.ToInt(string) is valid
- Catch exception when reminder in RomanNumeral.Converter.ToRomanNumeral(int) is < 0
- Extract GetHighestElement