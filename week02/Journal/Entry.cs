public class Entry
{   // Member variables to define Entry class responsibility
    public string _date;
    public string _promptText;
    public string _entryText;

    // Constructor to easily create a new entry
    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }

    // Functions to display   
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}