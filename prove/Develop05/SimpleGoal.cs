using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SimpleGoal : Goal
{
    public int Points { get; set; }

    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public override int CompleteGoal()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string DisplayGoal()
    {
        return $"[ {(IsCompleted ? "X" : " ")} ] {Name}: {Description} (Points: {Points})";
    }

    public override int GetExperiencePoints()
    {
        return 3;
    }
}