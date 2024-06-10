using System;
using System.Diagnostics;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Introduce()
    {
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public override void Start()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            Console.WriteLine("Breathing in...");
            Countdown(4);
            Console.WriteLine("Breathing out...");
            Countdown(4);
        }
        stopwatch.Stop();
    }

    public override void End()
    {
        base.End();
        Console.WriteLine("Breathing activity completed.");
    }
}