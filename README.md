# RomanNumerals
This solution was made in Visual Studio 2017 using .NET Core 1.1.

# About the solution
This solution implements a data type making it possible to represent a value in Roman Numeral.

Convetion from decimal to roman numeral is based on http://www.rapidtables.com/convert/number/how-number-to-roman-numerals.htm
Convetion from roman numeral to decimal is based on http://www.rapidtables.com/convert/number/how-roman-numerals-to-number.htm

# Usage
To use a RomanNumeral construct it by passing an integer or string as argument. The value can be fetched as an int or a string
representation of the roman numeral value.

```csharp
var numberOne = new RomanNumeral(90);
var numberTwo = new RomanNumeral("MCMXCIX");

Console.WriteLine(numberOne);           //XC
Console.Writeline(numberTwo.ToInt())	//1999
```

# TODO
- Validate that the input in RomanNumeral.Converter.ToRomanNumeral(int) is valid
- Validate that the input in RomanNumeral.Converter.ToInt(string) is valid
- Catch exception when reminders in RomanNumeral.Converter are < 0
- Throw ArgumentOutOfRange instead of InvalidOperationException when constructing RomanNumeral with an invalid string
- Add math operators so two RomanNumerals can be added, subtracted, multiplied or divided 
- Implement IComparable and IEquatable
