using System;
using System.Collections.Generic;

class Swimming : Activity
    {
        private uint Laps { get; set; }

        public Swimming(string date, double minutes, uint laps)
            : base(date, minutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date} Swimming ({Minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/m";
        }
    }