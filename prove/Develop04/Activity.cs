using System;
using System.Diagnostics;
using System.Threading;

abstract class Activity
{
    private int duration;
    private string title;

    protected Activity(int duration, string title)
    {
        this.duration = duration;
        this.title = title;
    }

    public int Duration => duration;
    public string Title => title;

    public abstract void Introduce();
    public abstract void Start();
    public virtual void End()
    {
        Console.WriteLine($"{Title} activity completed.");
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