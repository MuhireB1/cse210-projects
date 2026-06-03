public class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Mutators and accessors
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetStudetName(string studentName)
    {
        _studentName = studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // Member method to display summary of the the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}