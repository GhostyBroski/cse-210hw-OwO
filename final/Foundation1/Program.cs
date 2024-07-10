using System;

public class Program
{
    private List<Video> videos;

    public Program()
    {
        videos = new List<Video>();
    }

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Videos");
            Console.WriteLine("2. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Display();
                    break;
                case "2":
                    Console.WriteLine("Quitting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void Display()
    {
        foreach (var video in videos)
        {
            video.Display();
        }
    }

    public static void Main(string[] args)
    {
        Program program = new Program();

        Video video1 = new Video("This VTuber won't stop harrassing me!", "CDawgVA", 10);
        video1.AddComment(new Comment("HELP SHE FOUND M--", "CDawgVa"));
        video1.AddComment(new Comment("RIPBOZO o7", "Leafio"));
        video1.AddComment(new Comment("A Game Theory!!", "MattyPatty"));

        Video video2 = new Video("Indigo Park Explained!", "SuperHorrorBro", 20);
        video2.AddComment(new Comment("He's so fluffy!", "Nightmaris"));
        video2.AddComment(new Comment("NOPE I'M OUT", "FuzionG"));
        video2.AddComment(new Comment("But that's just a theory...", "YourGirlSteph"));

        Video video3 = new Video("Lucky Block Madness??!?", "JeromeASF", 30);
        video3.AddComment(new Comment("Noice :)", "YaBoyDW"));
        video3.AddComment(new Comment("WOAHHHH DO IT AGAIN :O", "Minecrafter3000"));
        video3.AddComment(new Comment("Everyday in this house...", "Dropsy"));

        program.videos.Add(video1);
        program.videos.Add(video2);
        program.videos.Add(video3);

        program.Menu();
    }
}