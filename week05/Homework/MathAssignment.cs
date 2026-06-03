using System.Collections.Generic;
public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problem;

    // Constructor
    public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }
    
    // Getters and Setters
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public string GetProblem()
    {
        return _problem;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public void SetProblem(string problem)
    {
        _problem = problem;
    }

    // Member method to get homework list
    public void GetHomeworkList(List<string> Homework)
    {
        Homework.Add(_textBookSection);
        Homework.Add(_problem);
    }
}