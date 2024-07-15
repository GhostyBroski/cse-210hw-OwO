using System;
using System.Collections.Generic;

class Running : Activity
    {
        private double distance;

        public Running(string date, double minutes, double distance)
            : base(date, minutes)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / distance;
        }

        public override string GetSummary()
        {
            return $"{Date} Running ({Minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/m";
        }
    }