using System;
// Had my program work with a library of scriptures(6) rather than a single one. Choosesgit scriptures at random to present to the user.
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        Console.WriteLine("\nMemorizing Scripture...");
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
    }
}