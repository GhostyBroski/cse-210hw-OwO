using System;
using System.Collections.Generic;

class Cycling : Activity
    {
        private double Speed { get; set; }

        public Cycling(string date, double minutes, double speed)
            : base(date, minutes)
        {
            Speed = speed;
        }

        public override double GetDistance()
        {
            return (Speed / 60) * Minutes;
        }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date} Cycling ({Minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/m";
        }
    }