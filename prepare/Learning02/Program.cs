using System;

class Program
{
    static void Main(string[] args )
    { 
       Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "DELL";
        job1._startYear = "2014";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Apple";
        job2._startYear = "2000";
        job2._endYear = "2010";

        Resume resume = new Resume();
        resume._name = "Allison Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
    
}