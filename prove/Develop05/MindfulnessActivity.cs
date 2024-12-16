public abstract class MindfulnessActivity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void DisplayStartingMessage();
    public abstract int GetDurationFromUser();
    public abstract void DisplayFinishingMessage();

    // Virtual method for the countdown, can be overridden by derived classes
    public virtual void ShowCountDown(int duration)
    {
        int countdownDuration = 3;
        for (int i = countdownDuration; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"Activity starts in {i} seconds...");
            Thread.Sleep(1000);
        }
    }
}
