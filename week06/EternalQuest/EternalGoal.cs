public class EternalGoal : Goal
{
    private int _timesCompleted;

    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
    }
    // Functional methods
    public override void RecordEvent()
    {
        // Increment counter - eternal goals can be completed infinite times
        _timesCompleted++;
    }
    public override bool IsComplete()
    {
        // Eternal goals are never truly complete
        return false;
    }
    public override string GetStringRepresentation()
    {
        // Format: EternalGoal|Name|Description|Points|TimesCompleted
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}";
    }
}