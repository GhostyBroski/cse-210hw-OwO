using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public abstract int CompleteGoal();
    public abstract string DisplayGoal();
    public abstract int GetExperiencePoints();
}