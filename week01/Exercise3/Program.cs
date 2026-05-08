using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            
            // Generate random number//
            Random randomGeneretor = new Random();
            int number = randomGeneretor.Next(1, 100);
            int guessNumber = -1;
             // Track entry times//
            int entry = 1;
            
            while (guessNumber != number)
            {
                // Ask user to guess the number//
                Console.Write("What is your guess number ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                
               
                if (guessNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                // Count entry times//
                entry++;
            }
            // Print and count
            Console.WriteLine("Congrats! You have guess it!");
            Console.WriteLine($"It took you {entry} times");

            // Ask the user if they want to play again//
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}