public class StationaryBicycles : Activity
{
    private double _speedInKmh;

    public StationaryBicycles(DateTime date, double lengthInMinutes, double speedInKmh)
        : base(date, lengthInMinutes)
    {
        _speedInKmh = speedInKmh;
    }

    public override double GetDistance()
    {
        return _speedInKmh * (_lengthInMinutes / 60); // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return _speedInKmh; // Speed in km/h
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance(); // Pace in minutes per kilometer
    }
}