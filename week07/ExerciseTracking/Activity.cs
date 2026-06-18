public abstract class Activity
{
    protected DateTime _date;
    protected double _lengthInMinutes;

    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public double LengthInMinutes
    {
        get { return _lengthInMinutes; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy");
        string activityType = this.GetType().Name;
        return $"{date} {activityType} ({_lengthInMinutes:0} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}

