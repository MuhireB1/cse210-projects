using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqaure = SqaureNumber(favNumber);

        DisplayResult(name, sqaure);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to this program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            return name; 
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string fav = Console.ReadLine();
            int favNumber = int.Parse(fav);

            return favNumber;
        }

        static int SqaureNumber(int number)
        {
            int sqaure = number * number;
            return sqaure;
        }
        static void DisplayResult(string name, int snumber)
        {
            Console.WriteLine($"{name}, the square of your number is {snumber}");
        }

    }