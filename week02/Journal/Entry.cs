public class Entry
{   // Member variables to define Entry class responsibility
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry()
    {
    }

    // Constructor to easily create a new entry
    public Entry(string date, string prompt, string entry)
    {
        Date = date;
        PromptText = prompt;
        EntryText = entry;
    }

    // Functions to display   
    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}\n");
    }
}