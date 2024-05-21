using System;

class Program
{
    static void Main(string[] args)
    {
        Reference john316 = new Reference("John", 3, 16, 16);
        string john316Text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture john316Scripture = new Scripture(john316, john316Text);

        ScriptureManager scriptureManager = new ScriptureManager();
        scriptureManager.AddScripture(john316Scripture);
        john316Scripture.Display();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
