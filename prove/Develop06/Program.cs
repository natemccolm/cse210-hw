//added further breakdown of how many instances left on checklist, as well as percentages of how far through the goal number they had come.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add a Goal");
            Console.WriteLine("2. Display All Goals");
            Console.WriteLine("3. Mark Goal as Complete");
            Console.WriteLine("4. Exit");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal(goalManager);  
                    break;
                case "2":
                    goalManager.DisplayAllGoals();
                    break;
                case "3":
                    Console.WriteLine("Enter the index number of the goal to mark as complete: ");
                    int index = int.Parse(Console.ReadLine());
                    if (index >=0 && index<goalManager.Goals.Count)
                    {
                        Goal selectedGoal=goalManager.Goals[index];
                        goalManager.MarkGoalComplete(selectedGoal);
                    }
                    else {
                        Console.WriteLine("Invalid insdex. Please try again.");
                    }


                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (choice != "4");
    }

    static void AddGoal(GoalManager goalManager)
    {
        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the number of points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;
        Console.WriteLine("Select goal type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.WriteLine("Enter the number of times to complete the goal: ");
                int timesToComplete = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points) { TimesToComplete = timesToComplete };
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goalManager.AddGoal(newGoal);  
        Console.WriteLine("Goal added successfully.");
    }
}
