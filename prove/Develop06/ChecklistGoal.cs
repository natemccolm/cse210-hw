public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    public int TimesToComplete { get => _timesToComplete; set => _timesToComplete = value; }
    public int TimesCompleted { get => _timesCompleted; set => _timesCompleted = value; }
    public int BonusPoints { get => _bonusPoints; set => _bonusPoints = value; }

    public ChecklistGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesToComplete = 0;
        _timesCompleted = 0;
        _bonusPoints = 0;
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine("This is a checklist goal.");
        Console.WriteLine($"Times to complete: {_timesToComplete}");
        Console.WriteLine($"Times completed: {_timesCompleted}");
        Console.WriteLine($"Bonus points: {_bonusPoints}");
    }

    public override void RecordProgress()
    {
        if (!IsComplete)  
        {
            _timesCompleted++;
            Console.WriteLine($"{Name} has been completed {_timesCompleted} times.");
            
            if (_timesCompleted >= _timesToComplete)
            {
                MarkComplete();
                AddPoints(Points + _bonusPoints);  
                Console.WriteLine($"{Name} is now completed! You've earned {Points + _bonusPoints} points.");
            }
        }
        else
        {
            Console.WriteLine($"{Name} has already been completed.");
        }
    }
}
