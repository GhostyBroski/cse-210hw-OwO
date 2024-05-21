using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<Word> _unobscuredWords;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
        _unobscuredWords = new List<Word>(_words); // Initialize with all words as unobscured
    }

    public string GetReferenceText()
    {
        return _reference.GetReference();
    }

    public string GetScriptureText()
    {
        return string.Join(' ', _words.Select(word => word.IsObscured() ? new string('_', word.GetWord().Length) : word.GetWord()));
    }

    public void Display()
    {
        // Display the scripture reference and text
        Console.WriteLine($"{GetReferenceText()}\n: {GetScriptureText()}");

        while (true)
        {
            Console.WriteLine("\nPress Enter to clear the console and replace one word with underscores, or type 'quit' to exit...");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Environment.Exit(0);
            }
            else if (input == "")
            {
                ObscureRandomWord();

                // Check if all words are obscured
                if (_unobscuredWords.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{GetReferenceText()}\n: {GetScriptureText()}");
                    Console.WriteLine("All words have been obscured. Press Enter to exit...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                Console.Clear();
                Console.WriteLine($"{GetReferenceText()}: {GetScriptureText()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to try again...");
            }
        }
    }

    private void ObscureRandomWord()
    {
        if (_unobscuredWords.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_unobscuredWords.Count);
            _unobscuredWords[index].Obscure();
            _unobscuredWords.RemoveAt(index);
        }
    }
}