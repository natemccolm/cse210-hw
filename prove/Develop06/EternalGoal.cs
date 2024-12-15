public class EternalGoal: Goal {

    public EternalGoal(string name, string description, int points)
        :base (name, description, points){
        }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine("This is an eternal goal.");
    }

    public override void RecordProgress()
    {
        base.RecordProgress();
        Console.WriteLine($"You earned {Points} points for completing this progress!");
    }

    


}