using System;
using System.Diagnostics;
using System.Threading;

class ListingActivity : Activity
{
    private static readonly string[] Prompts = new[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration, "Listing") { }

    public override void Introduce()
    {
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void Start()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);

        Console.WriteLine("Starting in...");
        Countdown(5);

        Stopwatch stopwatch = Stopwatch.StartNew();
        int itemCount = 0;
        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            Console.Write("List something: ");
            Console.ReadLine();
            itemCount++;
        }
        stopwatch.Stop();

        Console.WriteLine($"You listed {itemCount} items.");
    }
}