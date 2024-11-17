using System;
using System.Collections.Generic;

class Program
{
    private static Journal journal = new Journal();
    private static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I could relive one moment from today, what would it be?",
        "What did I learn today?"
    };

    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nJournal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
    }

    static void WriteNewEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();
        journal.AddEntry(prompt, response);
    }

    static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    static void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved successfully.");
    }

    static void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded successfully.");
    }
}
