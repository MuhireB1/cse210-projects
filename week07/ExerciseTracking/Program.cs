using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new StationaryBicycles(new DateTime(2022, 11, 4), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 60, 10));

        // Additional examples
        activities.Add(new Running(new DateTime(2022, 11, 6), 25, 2.5));
        activities.Add(new StationaryBicycles(new DateTime(2022, 11, 7), 30, 12.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 8), 45, 8));

        // Display summaries for all activities
        Console.WriteLine("========== EXERCISE TRACKER SUMMARY ==========\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("\n=============================================");
    }
}
