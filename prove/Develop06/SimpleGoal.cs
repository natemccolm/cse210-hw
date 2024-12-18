public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine("This is a simple goal.");
    }

    public override void RecordProgress()
    {
        if (!IsComplete)  
        {
            MarkComplete();
            AddPoints(Points); 
            Console.WriteLine($"{Name} is now completed! You've earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"{Name} has already been completed.");
        }
    }
}
