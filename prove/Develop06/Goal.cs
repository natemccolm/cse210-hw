public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public int Points { get => _points; set => _points = value; }
    public bool IsComplete { get => _isComplete; protected set => _isComplete = value; }

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }

    protected void AddPoints(int points)
    {
        Console.WriteLine($"Added {points} points.");
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Completed: {_isComplete}");
    }

    public virtual void RecordProgress()
    {
        if (!_isComplete)  
        {
            MarkComplete();
            AddPoints(_points);  
            Console.WriteLine($"{_name} is now completed! You've earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"{_name} has already been completed.");
        }
    }
}
