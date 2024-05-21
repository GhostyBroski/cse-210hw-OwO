using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture reference
        Reference john316 = new Reference("John", 3, 16, 16);

        // Define the scripture text
        string john316Text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create the scripture
        Scripture john316Scripture = new Scripture(john316, john316Text);

        // Create the scripture manager
        ScriptureManager scriptureManager = new ScriptureManager();
        scriptureManager.AddScripture(john316Scripture);

        // Display the scripture
        Console.WriteLine("Scripture:");
        john316Scripture.Display();

        // Wait for Enter key press to close the program
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
