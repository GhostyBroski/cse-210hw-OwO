using System;
using System.Collections.Generic;

class Running : Activity
    {
        private double Distance { get; set; }

        public Running(string date, double minutes, double distance)
            : base(date, minutes)
        {
            Distance = distance;
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return (Distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / Distance;
        }

        public override string GetSummary()
        {
            return $"{Date} Running ({Minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/m";
        }
    }