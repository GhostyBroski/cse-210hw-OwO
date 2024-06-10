using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "4") return;

            Console.Write("Enter the duration for the activity in seconds: ");
            if (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid duration. Please try again.");
                Thread.Sleep(2000);
                continue;
            }

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(duration),
                "2" => new ReflectionActivity(duration),
                "3" => new ListingActivity(duration),
                _ => null
            };

            if (activity == null)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
                continue;
            }

            activity.Introduce();
            activity.Start();
            activity.End();
            activity.ShowSpinnerWithText("Returning to menu ");
        }
    }
}