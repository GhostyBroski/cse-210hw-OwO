using System;
using System.Diagnostics;
using System.Threading;

abstract class Activity
{
    private int duration;

    protected Activity(int duration)
    {
        this.duration = duration;
    }

    public int Duration => duration;

    public abstract void Introduce();
    public abstract void Start();
    public virtual void End()
    {
        Console.WriteLine("Activity completed.");
    }

    public void ShowSpinnerWithText(string text)
    {
        string[] spinnerChars = { "Ooo", "oOo", "ooO", "oOo", "Ooo" };
        Console.Write(text);
        for (int i = 0; i < 10; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c);
                Thread.Sleep(200);
                Console.Write("\b\b\b");
            }
        }
        Console.WriteLine();
    }

    public void ShowSpinner()
    {
        string[] spinnerChars = { "Ooo", "oOo", "ooO", "oOo", "Ooo" };
        for (int i = 0; i < 10; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c);
                Thread.Sleep(200);
                Console.Write("\b\b\b");
            }
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r");
    }
}