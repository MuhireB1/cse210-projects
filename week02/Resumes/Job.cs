public class Job
{
   // RESPONSIBILITY
   // Keeps track of the company, job title, start year and end year//
   public string _companyName = "";
   public string _jobTitle = "";
   public int _startYear;
   public int _endYear;

   //BEHAVIORS
   //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
   public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}.");
    }

}