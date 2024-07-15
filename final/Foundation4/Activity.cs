using System;
using System.Collections.Generic;

class Activity
    {
        protected string Date { get; set; }
        protected double Minutes { get; set; }

        public Activity(string date, double minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual double GetPace()
        {
            return 0.0;
        }

        public virtual string GetSummary()
        {
            return $"{Date} Activity ({Minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/m";
        }
    }