using System;

public class Comment
{
    private string text;
    private string commenter;

    public Comment(string text, string commenter)
    {
        this.text = text;
        this.commenter = commenter;
    }

    public void Display()
    {
        Console.WriteLine($"Commenter: {commenter}");
        Console.WriteLine($"Comment: {text}");
        Console.WriteLine();
    }
}