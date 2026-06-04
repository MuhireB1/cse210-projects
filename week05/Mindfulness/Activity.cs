public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructors
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Getters and Setters
public string Getname()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Member Functions
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string dur = Console.ReadLine();
        _duration = int.Parse(dur);
        Console.WriteLine();
        Console.Write("Starting in: ");
        ShowCountdown(3);
        Console.WriteLine();
}
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done! \nYou have completed another {_duration} seconds of the {_name} activity.");
        Console.WriteLine();
    }

    public void ShowSpinner(int duration)
    {
        List<string> spinner = new List<string>() { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Count;
        }
        Console.Write(" \b");
    }

    public void ShowSpinnerWithMessage(string message, int duration)
    {
        List<string> spinner = new List<string>() { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime startTime = DateTime.Now;
        Console.Write(message + " ");
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(250);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Count;
        }
        Console.WriteLine();
    }
    public void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}