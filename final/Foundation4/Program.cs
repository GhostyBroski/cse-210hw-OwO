using System;
using System.Collections.Generic;

class Program
    {
        private List<Activity> Activities { get; set; } = new List<Activity>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateSampleActivities();
            program.DisplaySummaries();
        }

        private void CreateSampleActivities()
        {
            Running running = new Running("03 Nov 2022", 30, 3.0);
            Cycling cycling = new Cycling("04 Nov 2022", 45, 15.0);
            Swimming swimming = new Swimming("05 Nov 2022", 60, 40);

            Activities.Add(running);
            Activities.Add(cycling);
            Activities.Add(swimming);
        }

        private void DisplaySummaries()
        {
            foreach (var activity in Activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }