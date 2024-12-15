public class SimpleGoal : Goal {

    public SimpleGoal(string name, string description, int points)
        :base (name, description, points){

        }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine("This is a simple goal.");
    }

    








}

