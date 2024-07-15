using System;
using System.Collections.Generic;

 class Program
    {
        private List<Event> Events { get; set; } = new List<Event>();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.CreateSampleEvents();
            program.Menu();
        }

        private void CreateSampleEvents()
        {
            Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
            Address address2 = new Address("456 Elm St", "Provo", "UT", "USA");
            Address address3 = new Address("789 Oak St", "Salt Lake City", "UT", "USA");

            Lecture lecture = new Lecture("Lecture", "A Crash Course in C# Programming", "A lecture on advanced C# programming from an amazing BYU-I professor.", address1, "2024-08-01", "10:00 AM", "Bro. Godderidge", 100);
            Reception reception = new Reception("Reception", "Wedding Reception", "A celebration of marriage between Lauren Skousen and Daniel Skousen.", address2, "2024-08-02", "6:00 PM", "rsvpHappilyTogether@gmail.com");
            Outdoor outdoor = new Outdoor("Outdoor", "Community Picnic", "A fun community picnic for everyone to enjoy!", address3, "2024-08-03", "12:00 PM", "Sunny and Warm!");

            Events.Add(lecture);
            Events.Add(reception);
            Events.Add(outdoor);
        }

        private void Menu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display Events");
                Console.WriteLine("2. Quit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Display();
                        break;
                    case "2":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private void Display()
        {
            foreach (var eventItem in Events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(eventItem.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                Console.WriteLine(eventItem.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(eventItem.GetShortDescription());
                Console.WriteLine();
            }
        }
    }