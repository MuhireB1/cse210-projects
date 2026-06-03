public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    // Getters and Setters
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    // Member function to get writing information
    public string GetWritingInfo()
    {
        return $"{GetStudentName()} - {GetTopic()}\n{_title}";
    }
}