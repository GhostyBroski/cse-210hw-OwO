using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;
    static int experiencePoints = 0;
    static int level = 1;
    static int xpForNextLevel = 10;

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Level: {level} {DisplayExperienceBar()}");
            Console.WriteLine($"Total Score: {totalScore}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        var choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                AddSimpleGoal();
                break;
            case "2":
                AddEternalGoal();
                break;
            case "3":
                AddChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void AddSimpleGoal()
    {
        Console.Write("Enter name: ");
        var name = Console.ReadLine();
        Console.Write("Enter description: ");
        var description = Console.ReadLine();
        Console.Write("Enter points: ");
        var points = int.Parse(Console.ReadLine());
        goals.Add(new SimpleGoal(name, description, points));
    }

    static void AddEternalGoal()
    {
        Console.Write("Enter name: ");
        var name = Console.ReadLine();
        Console.Write("Enter description: ");
        var description = Console.ReadLine();
        Console.Write("Enter points: ");
        var points = int.Parse(Console.ReadLine());
        goals.Add(new EternalGoal(name, description, points));
    }

    static void AddChecklistGoal()
    {
        Console.Write("Enter name: ");
        var name = Console.ReadLine();
        Console.Write("Enter description: ");
        var description = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        var points = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points on completion: ");
        var bonusPoints = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        var targetCount = int.Parse(Console.ReadLine());
        goals.Add(new ChecklistGoal(name, description, points, bonusPoints, targetCount));
    }

    static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayGoal());
        }
        Console.WriteLine($"\nTotal Score: {totalScore}\n");
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey();
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalScore);
            writer.WriteLine(experiencePoints);
            writer.WriteLine(level);
            writer.WriteLine(xpForNextLevel);
            foreach (var goal in goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"SimpleGoal|{simpleGoal.Name}|{simpleGoal.Description}|{simpleGoal.Points}|{simpleGoal.IsCompleted}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"EternalGoal|{eternalGoal.Name}|{eternalGoal.Description}|{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"ChecklistGoal|{checklistGoal.Name}|{checklistGoal.Description}|{checklistGoal.Points}|{checklistGoal.BonusPoints}|{checklistGoal.TargetCount}|{checklistGoal.CurrentCount}|{checklistGoal.IsCompleted}");
                }
            }
        }
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                totalScore = int.Parse(reader.ReadLine());
                experiencePoints = int.Parse(reader.ReadLine());
                level = int.Parse(reader.ReadLine());
                xpForNextLevel = int.Parse(reader.ReadLine());
                goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            simpleGoal.IsCompleted = bool.Parse(parts[4]);
                            goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            var eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            goals.Add(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            checklistGoal.CurrentCount = int.Parse(parts[6]);
                            checklistGoal.IsCompleted = bool.Parse(parts[7]);
                            goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No saved data found.");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select a goal to complete:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            var goal = goals[index];
            totalScore += goal.CompleteGoal();
            GainExperience(goal.GetExperiencePoints());

            // Ensure that eternal goals always add points to totalScore.
            if (goal is EternalGoal eternalGoal)
            {
                totalScore += eternalGoal.Points;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    static void GainExperience(int xp)
    {
        experiencePoints += xp;
        while (experiencePoints >= xpForNextLevel)
        {
            experiencePoints -= xpForNextLevel;
            level++;
        }
    }

    static string DisplayExperienceBar()
    {
        int filledSlots = (experiencePoints * 10) / xpForNextLevel;
        return "[" + new string('O', filledSlots) + new string('X', 10 - filledSlots) + "]";
    }
}