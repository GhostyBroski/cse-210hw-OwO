using System;
using System.Diagnostics;
using System.Threading;

class ReflectionActivity : Activity
{
    private static readonly string[] Prompts = new[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly string[] Questions = new[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel during this experience?",
        "What did you learn from this experience?",
        "How can you apply what you learned to future situations?"
    };

    public ReflectionActivity(int duration) : base(duration, "Reflection") { }

    public override void Introduce()
    {
        Console.WriteLine("Welcome to the Reflection Activity!");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public override void Start()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Random random = new Random();

        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            string prompt = Prompts[random.Next(Prompts.Length)];
            Console.WriteLine(prompt);
            ShowSpinner(); 
            Thread.Sleep(3000); 

            foreach (string question in Questions)
            {
                if (stopwatch.Elapsed.TotalSeconds >= Duration) break;
                Console.WriteLine(question);
                ShowSpinner(); 
                Thread.Sleep(3000); 
            }
        }
        stopwatch.Stop();
    }
}