using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction defaultOption = new Fraction();
        Fraction wholeNumber = new Fraction(5);
        Fraction inputOption = new Fraction(3, 4);
        Fraction third = new Fraction(1, 3);

        Console.WriteLine("defaultOption");
        Console.WriteLine(defaultOption.GetFractionString());
        Console.WriteLine(defaultOption.GetDecimalValue());
        Console.WriteLine("");
        Console.WriteLine(defaultOption.GetTop());
        Console.WriteLine(defaultOption.GetBottom());
        Console.WriteLine("");

        Console.WriteLine("wholeNumber");
        Console.WriteLine(wholeNumber.GetFractionString());
        Console.WriteLine(wholeNumber.GetDecimalValue());
        Console.WriteLine("");
        Console.WriteLine(wholeNumber.GetTop());
        Console.WriteLine(wholeNumber.GetBottom());
        Console.WriteLine("");

        Console.WriteLine("inputOption");
        Console.WriteLine(inputOption.GetFractionString());
        Console.WriteLine(inputOption.GetDecimalValue());
        Console.WriteLine("");
        Console.WriteLine(inputOption.GetTop());
        Console.WriteLine(inputOption.GetBottom());
        Console.WriteLine("");
        
        Console.WriteLine("third");
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
        Console.WriteLine("");
        Console.WriteLine(third.GetTop());
        Console.WriteLine(third.GetBottom());

    }
}