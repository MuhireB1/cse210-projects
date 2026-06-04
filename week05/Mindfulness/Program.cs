using System;
 /// <summary>
 ///  Added a Keeping a log of how many times activities were performed.
 /// </summary>
class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
        Reflection reflection = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
        Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nWelcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    breathingCount++;
                    break;
                case "2":
                    reflection.Run();
                    reflectionCount++;
                    break;
                case "3":
                    listing.Run();
                    listingCount++;
                    break;
                case "4":
                    Console.WriteLine("\nActivity Log:");
                    Console.WriteLine($"Breathing Activity: {breathingCount} times");
                    Console.WriteLine($"Reflection Activity: {reflectionCount} times");
                    Console.WriteLine($"Listing Activity: {listingCount} times");
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}