using System.Collections.Generic;
public class Video
{
    // This class has the responsibility to track title, author, and length in seconds of the video
    // Each video also has the responsibilty to to store a list of comments and should be defined by the comment class
    public string _title;
    public string _author;
    public double _length;
    public List<Comments> comments;

    //Constructor
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = new List<Comments>();
    }
    // Member methods
    public void AddComment(Comments comment)
    {
        comments.Add(comment);
    }
    public void DisplayVideoDetails()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length} seconds");
    Console.WriteLine($"Number of comments: {GetCommentCount()}");

    foreach (Comments comment in comments)
    {
        comment.DisplayComment();
    }

    Console.WriteLine();
}
    public int GetCommentCount()
    {
        return comments.Count;
    }
    
}
