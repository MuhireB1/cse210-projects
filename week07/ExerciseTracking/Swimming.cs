public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, double lengthInMinutes, double laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Assuming each lap is 50 meters, converting to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_lengthInMinutes / 60); // Speed in km/h
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance(); // Pace in minutes per kilometer
    }
}