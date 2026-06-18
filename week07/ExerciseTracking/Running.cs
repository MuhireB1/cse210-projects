public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, double lengthInMinutes, double distanceInMiles)
        : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    public override double GetSpeed()
    {
        return _distanceInMiles / (_lengthInMinutes / 60);
    }

    public override double GetPace()
    {
        return _lengthInMinutes / _distanceInMiles;
    }
}