using System;
using System.Collections.Generic;
using System.Linq;

public class ExerciseTracker
{
    private List<Activity> _activities;

    public ExerciseTracker()
    {
        _activities = new List<Activity>();
    }

    public void AddExercise(string activityType, double lengthInMinutes)
    {
        Activity activity = null;

        switch (activityType.ToLower())
        {
            case "running":
                activity = new Running(DateTime.Now, lengthInMinutes, 5); // Example distance in miles
                break;
            case "cycling":
                activity = new StationaryBicycles(DateTime.Now, lengthInMinutes, 20); // Example speed in km/h
                break;
            case "swimming":
                activity = new Swimming(DateTime.Now, lengthInMinutes, 30); // Example laps
                break;
            default:
                Console.WriteLine("Invalid activity type.");
                return;
        }

        _activities.Add(activity);
    }

    public double GetTotalExerciseTime()
    {
        return _activities.Sum(a => a.LengthInMinutes);
    }
}