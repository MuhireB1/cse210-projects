public class Goal
{
    private string _name;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    // Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPoint(int points)
    {
        _points = points;
    }

    // Functional Methods
    public virtual void RecordEvent()
    {
        // Base implementation - overridden by subclasses
    }
    public virtual bool IsComplete()
    {
        // Base implementation - returns false by default
        return false;
    }
    public virtual string GetDetails()
    {
        // Returns goal with completion checkbox
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name}";
    }
    public virtual string GetStringRepresentation()
    {
        // Base serialization format for saving/loading
        return $"{_name}|{_description}|{_points}";
    }
}