using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A")
        {
            if (percent >= 93)
            {
                letter = "A";
            }
            else if (percent <= 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }

        if (letter == "B")
        {
            if (percent >= 86)
            {
                letter = "B+";
            }
            else if (percent <= 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }

        if (letter == "C")
        {
            if (percent >= 76)
            {
                letter = "C+";
            }
            else if (percent <= 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }

        if (letter == "D")
        {
            if (percent >= 66)
            {
                letter = "D+";
            }
            else if (percent <= 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }

        if (letter == "F")
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Sadly, you failed... Better luck next time!");
        }
    }
}