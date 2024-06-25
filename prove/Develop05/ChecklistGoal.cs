using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ChecklistGoal : Goal
{
    public int Points { get; set; }
    public int BonusPoints { get; set; }
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int targetCount)
    {
        Name = name;
        Description = description;
        Points = points;
        BonusPoints = bonusPoints;
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override int CompleteGoal()
    {
        if (!IsCompleted)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string DisplayGoal()
    {
        return $"[ {(IsCompleted ? "X" : " ")} ] {Name}: {Description} (Completed {CurrentCount}/{TargetCount} times, Points: {Points}, Bonus: {BonusPoints} on completion)";
    }

    public override int GetExperiencePoints()
    {
        if (!IsCompleted && CurrentCount == TargetCount)
        {
            return 5;
        }
        return 0;
    }
}