using System;
using System.Collections.Generic;

class Activity
    {
        private string date;
        private double minutes;

        public Activity(string date, double minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public string Date => date;
        public double Minutes => minutes;

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