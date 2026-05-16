using System;

namespace JournalApp;

// Added a feature Save or load your document to a database or use a different library or format such as JSON for storage" to exceed requirement //
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        //
        int userChoice = 0;
        while (userChoice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");


            // Get user input//
            Console.Write("What would you like to do? ");
            string response = Console.ReadLine();
            int.TryParse(response, out userChoice);

            // Condition the output//
            if (userChoice == 1)
            {
                string choice = prompt.GetRandomPrompt();
                Console.WriteLine($"\n{choice}");
                Console.Write(">> ");
                string reply = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, choice, reply);
                journal.AddEntry(newEntry);
            }
            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter filename to save to (default: journal.json): ");
                string saveFilename = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(saveFilename))
                {
                    saveFilename = "journal.json";
                }
                if (!saveFilename.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    saveFilename += ".json";
                }

                journal.SaveToFile(saveFilename);
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter filename to load from (default: journal.json): ");
                string loadFilename = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(loadFilename))
                {
                    loadFilename = "journal.json";
                }
                if (!loadFilename.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    loadFilename += ".json";
                }

                journal.LoadFromFile(loadFilename);
                journal.DisplayAll();
            }
        }
        Console.WriteLine("Quitting the program!...");
    }
}