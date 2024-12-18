using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private const string _filePath = "activities.txt"; // File path for saving/loading activities

    static void Main(string[] args)
    {
        List<Activity> activities = LoadActivities();

        if (activities.Count == 0)
        {
            activities.Add(new Running("03 Nov 2022", 30, 3.0)); 
            activities.Add(new Cycling("04 Nov 2022", 45, 12.0));
            activities.Add(new Swimming("05 Nov 2022", 40, 20)); 
        }

        Console.WriteLine("Activities:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        ShowMotivationalMessage();

        SaveActivities(activities);
    }

    static void SaveActivities(List<Activity> activities)
    {
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            foreach (var activity in activities)
            {
                if (activity is Running running)
                {
                    writer.WriteLine($"Running,{running.Date},{running.Duration},{running.GetDistance()}");
                }
                else if (activity is Cycling cycling)
                {
                    writer.WriteLine($"Cycling,{cycling.Date},{cycling.Duration},{cycling.GetSpeed()}");
                }
                else if (activity is Swimming swimming)
                {
                    writer.WriteLine($"Swimming,{swimming.Date},{swimming.Duration},{swimming.GetPace()}");
                }
            }
        }
    }

    static List<Activity> LoadActivities()
    {
        List<Activity> activities = new List<Activity>();

        if (File.Exists(_filePath))
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');

                    if (parts[0] == "Running")
                    {
                        string date = parts[1];
                        int duration = int.Parse(parts[2]);
                        double distance = double.Parse(parts[3]);
                        activities.Add(new Running(date, duration, distance));
                    }
                    else if (parts[0] == "Cycling")
                    {
                        string date = parts[1];
                        int duration = int.Parse(parts[2]);
                        double speed = double.Parse(parts[3]);
                        activities.Add(new Cycling(date, duration, speed));
                    }
                    else if (parts[0] == "Swimming")
                    {
                        string date = parts[1];
                        int duration = int.Parse(parts[2]);
                        int laps = int.Parse(parts[3]);
                        activities.Add(new Swimming(date, duration, laps));
                    }
                }
            }
        }

        return activities;
    }

    static void ShowMotivationalMessage()
    {
        string[] messages = new string[]
        {
            "Great job! Keep it up!",
            "You're doing awesome!",
            "One more mile, you can do it!",
            "The only bad workout is the one that didn't happen!",
            "Believe in yourself and all that you are!",
            "Push yourself, no one else is going to do it for you!",
            "Strive for progress, not perfection!",
            "It never gets easier, you just get stronger!"
        };

        Random random = new Random();
        int index = random.Next(messages.Length);
        Console.WriteLine(messages[index]);
    }
}
