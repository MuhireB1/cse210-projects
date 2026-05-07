using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade//
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        // Letter variable//
        string letter = "";

        // Determine the letter grade//
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        // Adding symbols on grade and print grade//
        string sign = "";

        if (number % 10 >= 7)
        {
            sign = "+";
        }
        else if (number % 10 < 3)
        {
            sign = "-";
        }

        // Removing the sign for A+ and F-//
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F" && sign == "-")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade letter is {letter}{sign}");

        // Determine if the passed or failed//
        if (number >= 70)
        {
            Console.WriteLine("Congrats! You passed the course!");
        }
        else
        {
            Console. WriteLine("Sorry, you did not pass the course. Keep trying! Better luck next time!");
        }
    }
}