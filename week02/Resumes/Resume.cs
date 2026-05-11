public class Resume
{
    // RESPONSIBILITY
    // Keeps track of the person's name and a list of their jobs//
    public string _resumeName = "";
    public List<Job> _jobs = new List<Job>();

    //BEHAVIORS 
    //Display the resume, which shows the name first, followed by displaying each one of the jobs//
    public void Display()
    {
        Console.WriteLine($"Name: {_resumeName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayInfo();
        }
    }
}