using System.Collections.Generic;
public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public Reflection()
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        InitializePrompts();
        InitializeQuestions();
    }
    public Reflection(string name, string description, int duration): base(name, description, duration)
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetDuration(0);
        _prompts = new List<string>();
        _questions = new List<string>();
        InitializePrompts();
        InitializeQuestions();
    }

    private void InitializePrompts()
    {
        if (_prompts.Count == 0)
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
        }
    }

    private void InitializeQuestions()
    {
        if (_questions.Count == 0)
        {
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");
        }
    }

    // Member Functions
    public void ReflectionActivity()
    {
        Random random = new Random();

        // Show a random prompt
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);
        Console.WriteLine();

        // Ask random questions for the duration
        DateTime startTime = DateTime.Now;
        int timeElapsed = 0;

        while (timeElapsed < GetDuration())
        {
            int questionIndex = random.Next(_questions.Count);
            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(5);
            Console.WriteLine();
            timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }
    }

    public void Run()
    {
        DisplayStartMessage();
        ReflectionActivity();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        InitializePrompts();
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        InitializeQuestions();
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompts()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(10000);
        }
    }

}