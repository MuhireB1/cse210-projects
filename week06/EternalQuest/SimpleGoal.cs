public class SimpleGoal : Goal
{
    private bool _IsComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _IsComplete = false;
    }

    // Functional methods
    public override void RecordEvent()
    {
        // Mark the goal as complete (can only be completed once)
        _IsComplete = true;
    }
    public override bool IsComplete()
    {
        // Return true if goal has been completed
        return _IsComplete;
    }
    public override string GetStringRepresentation()
    {
        // Format: SimpleGoal|Name|Description|Points|IsComplete
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_IsComplete}";
    }
}