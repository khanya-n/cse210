using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFrac = new Fraction();
        Fraction wholeNumber = new Fraction(5);
        Fraction fraction = new Fraction(3, 4);
        Fraction third = new Fraction(1, 3);

        Console.WriteLine(defaultFrac.GetFractionString());
        Console.WriteLine(defaultFrac.GetDecimalValue());

        Console.WriteLine(wholeNumber.GetFractionString());
        Console.WriteLine(wholeNumber.GetDecimalValue());
        
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
    }
}