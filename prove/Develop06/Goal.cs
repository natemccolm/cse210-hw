public class Goal{

    public string Name {get; set;}
    public string Description {get; set;}
    public int Points {get;set;}
    public bool IsComplete{get;set;}

    public Goal (string name, string description, int points){

        Name=name;
        Description=description;
        Points=points;
        IsComplete=false;
    }

    public virtual void DisplayGoal(){
        Console.WriteLine($"Goal: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Points: {Points}");
        Console.WriteLine($"Completed: {IsComplete}");
    }

    public virtual void RecordProgress(){
        Console.WriteLine($"Recording progress for: {Name}");
    }

    public int GetPoints(){
        return Points;
    }

}