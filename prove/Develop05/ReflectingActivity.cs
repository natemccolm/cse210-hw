public class ReflectingActivity : MindfulnessActivity
{
    private Random _random;

    public ReflectingActivity() : base("Reflecting Activity", "Something motivational and sappy about a kitten in a tree hanging in there or whatever.")
    {
        _random = new Random();
    }

    public override void DisplayStartingMessage()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Description);
        Console.WriteLine("Take a moment to reflect on a meaningful experience in your life. Or don't. We won't know or judge either way: ");
    }

    public override int GetDurationFromUser()
    {
        int duration;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                return duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the duration.");
            }
        }
    }

    public override void DisplayFinishingMessage()
    {
        Console.Clear();
        Console.WriteLine("Good job! You've completed the reflecting activity.");
        Console.WriteLine("Press any key to return to the menu.");
    }

    public override void ShowCountDown(int duration)
    {
        int countdownDuration = 3;
        for (int i = countdownDuration; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"Activity starts in {i} seconds...");
            Thread.Sleep(1000);
        }
        DisplayPrompt();
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.Clear();
        Console.WriteLine("Reflection prompt: ");
        Console.WriteLine(prompt);
        Console.WriteLine("Take a few moments to reflect on this.");
    }

    public string GetRandomPrompt()
    {
        string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        int index = _random.Next(prompts.Length);
        return prompts[index];
    }

    public string CaptureReflection()
    {
        Console.WriteLine("Please take a moment to reflect and type your response below. Press enter when finished to move to the next prompt: ");
        return Console.ReadLine();
    }

    public void DisplayReflection(string reflection)
    {
        Console.Clear();
        Console.WriteLine($"Your reflection: {reflection}");
        Console.Write("Good job! You've wasted time reflecting on things. Hit any key to return to the menu.");
        Console.ReadKey();
    }
}
