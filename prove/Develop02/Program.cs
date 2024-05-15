using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static Entry WriteEntry() {
        Prompt prompt = new Prompt();
        string freshPrompt = prompt.GetPrompt();
        Console.WriteLine(freshPrompt);
        Console.Write("Your entry: ");
        string thoughts = Console.ReadLine();
        DateTime dateTime = DateTime.Now;
        
        Entry newEntry = new Entry(dateTime.ToString(), freshPrompt, thoughts);
        Console.WriteLine("\nHere's your new journal entry: \n");
        newEntry.Display();

        return newEntry;
    }

    static void SaveJournalFile(Journal journal, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in journal.entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    static Journal LoadJournalFile(string filePath)
    {
        Journal journal = new Journal();
        
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry entry = Entry.FromString(line);
                    if (entry != null)
                    {
                        journal.AppendEntry(entry);
                    }
                }
            }
        }

        return journal;
    }

    static void Main()
    {
        string filePath = "journal.txt";
        Journal journal = new Journal();
        bool quit = false;

        do
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = WriteEntry();
                    journal.AppendEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal = LoadJournalFile(filePath);
                    Console.WriteLine("Journal loaded.");
                    break;
                case "4":
                    SaveJournalFile(journal, filePath);
                    Console.WriteLine("Journal saved.");
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (!quit);

        Console.WriteLine("Goodbye!");
    }
}