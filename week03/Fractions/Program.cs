using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction Fraction1 = new Fraction();
        // Fraction1.SetTop(1);
        // Fraction1.SetBottom(1);
        // Console.WriteLine(Fraction1.GetFractionString());
        // Console.WriteLine(Fraction1.GetTop());
        // Console.WriteLine(Fraction1.GetBottom());

        // Second Instance of Fraction
        Fraction Fraction2 = new Fraction(1, 3);
        Console.WriteLine(Fraction2.GetFractionString());
        Console.WriteLine(Fraction2.GetDecimalValue());


    }
}