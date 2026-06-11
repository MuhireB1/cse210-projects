public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Functional method
    public override void RecordEvent()
    {
        // Increment completion counter if not yet complete
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }
    public override bool IsComplete()
    {
        // Complete when all target items are done
        return _amountCompleted >= _target;
    }
    public override string GetDetails()
    {
        // Show progress: "[ ] Goal Name -- Completed 2/5 times"
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} -- Completed {_amountCompleted}/{_target} times";
    }
    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal|Name|Description|Points|Target|Bonus|AmountCompleted
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}