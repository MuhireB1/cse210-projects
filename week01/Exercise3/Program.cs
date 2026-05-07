using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        
        while (playAgain == "yes")
        {
            // Generate Random magic number//
            Random randomGenerator = new Random();
            int number =randomGenerator.Next(1, 100);

            // Ask the user for their guess//
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);

            // Keep track of the number of guesses//
            int guessCount = 1;


            // Compare the user's guess to the magic number and provide untill guessed right//
            while (userGuess != number)
            {
                if (userGuess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < number)
                {
                    Console.WriteLine("Higher");
                }

                // Ask for another guess
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                userGuess = int.Parse(guess);

                //guess count//
                guessCount++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if the user wants to play again//
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
} 