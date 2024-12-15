public class ChecklistGoal : Goal {

    public int TimesToComplete {get;set;}
    public int TimesCompleted {get;set;}
    public int BonusPoints {get;set;}

    public ChecklistGoal(string name, string description, int points)
        : base(name, description, points){
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.WriteLine($"This is a checklist goal. Completed {TimesCompleted}/{TimesToComplete}");
    }

    public override void RecordProgress()
    {
        base.RecordProgress();
        TimesCompleted++;
        Console.WriteLine($"Progress recorded! {TimesCompleted}/{TimesToComplete} complete");

        if (TimesCompleted > TimesToComplete)
        {
            Console.WriteLine($"Congrats, you have exceeded your goal by {TimesCompleted - TimesToComplete} time(s)!");
            Console.WriteLine($"That is {TimesCompleted / (double)TimesToComplete * 100:F2}% over your goal!");
            Points += BonusPoints * 2;
            Console.WriteLine($"You've earned {Points}, which includes {BonusPoints * 2} for exceeding your goal!");
        }
        else if (TimesCompleted == TimesToComplete)
        {
            Console.WriteLine($"Congrats, you have met your goal of {TimesToComplete} times!");
            Points += BonusPoints;
            Console.WriteLine($"You've earned {Points}, which includes {BonusPoints} for hitting your goal!");
        }
        else
        {
            Console.WriteLine($"Keep on going! You are only {TimesToComplete - TimesCompleted} instances away from hitting your goal!");
            Console.WriteLine($"That's only {100 - (TimesCompleted / (double)TimesToComplete * 100):F2}% of your goal left to go!");
        }
    }


}