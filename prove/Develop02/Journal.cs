using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; } = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToShortDateString();
        Entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
            Console.WriteLine(entry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
                writer.WriteLine(entry.ToString());
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            Entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                    Entries.Add(new Entry(parts[0].Trim(), parts[1].Trim(), parts[2].Trim()));
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
