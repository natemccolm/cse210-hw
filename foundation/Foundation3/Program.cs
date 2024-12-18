using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("04 Nov 2022", 45, 12.0),
            new Swimming("05 Nov 2022", 40, 20)
        };

        Console.WriteLine("Activities:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        ShowMotivationalMessage();
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
