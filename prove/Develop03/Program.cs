using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture references
        Reference john316to17 = new Reference("John", 3, 16, 17);
        Reference psalm23 = new Reference("Psalm", 23, 1, 2);

        // Define the scripture texts with multiple verses
        List<Verse> john316to17Text = new List<Verse>
        {
            new Verse(16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Verse(17, "For God did not send his Son into the world to condemn the world, but to save the world through him.")
        };

        List<Verse> psalm23Text = new List<Verse>
        {
            new Verse(1, "The Lord is my shepherd; I shall not want."),
            new Verse(2, "He maketh me to lie down in green pastures: he leadeth me beside the still waters.")
        };

        // Create the scriptures
        Scripture john316to17Scripture = new Scripture(john316to17, john316to17Text);
        Scripture psalm23Scripture = new Scripture(psalm23, psalm23Text);

        // Create the scripture manager
        ScriptureManager scriptureManager = new ScriptureManager();
        scriptureManager.AddScripture(john316to17Scripture);
        scriptureManager.AddScripture(psalm23Scripture);

        // Prompt user to select a scripture to display
        Console.WriteLine("Select a scripture to display:");
        Console.WriteLine($"1. John 3:16-17");
        Console.WriteLine($"2. Psalm 23:1-2");
        Console.WriteLine("Enter the number of the scripture you want to display:");
        string choice = Console.ReadLine();

        Scripture selectedScripture = null;
        switch (choice)
        {
            case "1":
                selectedScripture = scriptureManager.GetScripture(john316to17);
                break;
            case "2":
                selectedScripture = scriptureManager.GetScripture(psalm23);
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        if (selectedScripture != null)
        {
            // Display the selected scripture
            selectedScripture.Display();

            // Wait for user input to clear the console and obscure words
            while (true)
            {
                Console.WriteLine("\nPress enter to continue, or type 'quit' to finish:");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    break;
                }
                else if (input == "")
                {
                    Console.Clear();
                    if (!selectedScripture.ObscureRandomWords(3))
                    {
                        Console.WriteLine($"{selectedScripture.GetReferenceText()}\n{selectedScripture.GetScriptureText()}");
                        Console.WriteLine("All words have been obscured. Press enter to finish.");
                        Console.ReadLine();
                        break;
                    }
                    selectedScripture.Display();
                }
                else
                {
                    Console.WriteLine("Invalid input. Press Enter to try again...");
                }
            }
        }
        else
        {
            Console.WriteLine("Scripture not found.");
        }
    }
}