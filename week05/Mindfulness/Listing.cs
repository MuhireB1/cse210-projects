public class Listing : Activity
{
    private List<string> _prompts;
    private int _counter;
    // constructor
    public Listing(string name, string description, int duration): base(name, description, duration)
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetDuration(0);
        _prompts = new List<string>();
        _counter = 0;
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        if (_prompts.Count == 0)
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
        }
    }

    public void ListingActivity()
    {
        Random random = new Random();

        // Show random prompt
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine();

        // Get list items until duration is reached
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _counter++;
            }
        }
    }

    public void Run()
    {
        DisplayStartMessage();
        ListingActivity();
        Console.WriteLine();
        Console.WriteLine($"You listed {_counter} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        InitializePrompts();
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Enter your responses (press Enter on an empty line to finish):");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            userList.Add(input);
        }
        return userList;
    }

}