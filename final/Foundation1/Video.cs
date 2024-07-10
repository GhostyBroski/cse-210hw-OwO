using System;

public class Video
{
    private string title;
    private string author;
    private int videoLength;
    private List<Comment> comments;

    public Video(string title, string author, int videoLength)
    {
        this.title = title;
        this.author = author;
        this.videoLength = videoLength;
        this.comments = new List<Comment>();
    }

    public int GetCommentNumber() => comments.Count;
    public string GetTitle() => title;
    public string GetAuthor() => author;
    public int GetVideoLength() => videoLength;
    public void SetTitle(string title) => this.title = title;
    public void SetAuthor(string author) => this.author = author;
    public void SetVideoLength(int videoLength) => this.videoLength = videoLength;
    
    public void AddComment(Comment comment) => comments.Add(comment);
    
    public void Display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Video Length: {videoLength} minutes");
        Console.WriteLine($"Number of Comments: {GetCommentNumber()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}