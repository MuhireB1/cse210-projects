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
        Fraction Fraction2 = new Fraction(5, 1);
        Console.WriteLine(Fraction2.GetFractionString());
        Console.WriteLine(Fraction2.GetDecimalValue());

        // Third Instance of Fraction
        Fraction Fraction3 = new Fraction(3, 4);
        Console.WriteLine(Fraction3.GetFractionString());
        Console.WriteLine(Fraction3.GetDecimalValue());

        // Fourth Instance of Fractio
        Fraction Fraction4 = new Fraction(1, 3);
        Console.WriteLine(Fraction4.GetFractionString());
        Console.WriteLine(Fraction4.GetDecimalValue());
    }
}