using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create assignment
        Assignment assignment1 = new Assignment("Muhire", "Web Fundamentals");
        Console.WriteLine(assignment1.GetSummary());

        // Create math assignment
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math1.GetSummary());
        List<string> homeworkList = new List<string>();
        math1.GetHomeworkList(homeworkList);
        foreach (string item in homeworkList)
        {
            Console.WriteLine(item);
        }

        // Create writing assignment instance
        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writing1.GetWritingInfo());
    }
}