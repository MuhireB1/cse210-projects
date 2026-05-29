public class Comments
{
    // This class has the responsibility to track both the name of the person and their texted comments
    public string _name;
    public string _comment;


    //Constructor
    public Comments(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    // Member function to store comments
    public void DisplayComment()
    {
        Console.WriteLine($"{_name} - {_comment}");
    }
}