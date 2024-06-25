using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class EternalGoal : Goal
{
    public int Points { get; set; }

    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override int CompleteGoal()
    {
        return Points;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {Name}: {Description} (Points: {Points} each time)";
    }

    public override int GetExperiencePoints()
    {
        return 1;
    }
}