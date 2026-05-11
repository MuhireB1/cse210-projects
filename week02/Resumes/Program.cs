using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Apple Inc";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.DisplayInfo(); 

        // Person 2 Instance//
        Job job2 = new Job();
        job2._companyName = "Microsoft";
        job2._jobTitle = "Software Developer";
        job2._endYear =  2025;
        job2._startYear = 2023;
        job2.DisplayInfo();

        // Resume instance//
        Resume resume1 = new Resume();
        resume1._resumeName = "Muhire Bienvenue";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.Display();
        
    }
}