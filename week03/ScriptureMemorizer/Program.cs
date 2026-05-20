using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        
        while (true)
        {
            Scripture scripture = library.GetRandomScripture();

            Console.WriteLine($"\nMemorizing scripture {library.GetScriptureCount()} from the library...");
            Console.WriteLine("Press Enter to start:");
            Console.ReadLine();

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nScripture complete!");
            Console.WriteLine("Type 'next' for another scripture or 'exit' to quit:");
            string response = Console.ReadLine();

            if (response.ToLower() == "exit")
                break;
        }
    }
}