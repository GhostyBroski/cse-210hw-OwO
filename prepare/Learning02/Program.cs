using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Game Designer";
        job1._company = "RIOT Games";
        job1._startYear = 2017;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Senior Level Designer";
        job2._company = "Blizzard";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Ash Jones";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}