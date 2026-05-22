using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction wholeNumber = new Fraction(5);
        Fraction fraction = new Fraction(3,4);
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(wholeNumber.GetFractionString());
        Console.WriteLine(wholeNumber.GetDecimalValue());
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}