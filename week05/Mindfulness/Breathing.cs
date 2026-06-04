public class Breathing : Activity
{
    // No attributes
    // constructor
    public Breathing(string name, string description, int duration): base(name, description, duration)
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetDuration(0);
    }
    public void BreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        int timeElapsed = 0;

        while (timeElapsed < GetDuration())
        {
            Console.WriteLine("Breathe in... ");
            ShowCountdown(6);
            Console.WriteLine();
            timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
            if (timeElapsed >= GetDuration()) break;

            Console.WriteLine("Now breathe out... ");
            ShowCountdown(6);
            Console.WriteLine();
            timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }
    }

    public void Run()
    {
        DisplayStartMessage();
        BreathingActivity();
        DisplayEndingMessage();
    }
}