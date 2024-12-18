using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private int completedGoalsCount = 0;  
    private const int BonusThreshold = 5; 
    private const int BonusPoints = 50;  

    public List<Goal> Goals => goals;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayAllGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals added yet.");
            return;
        }

        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    public void RecordProgress(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal selectedGoal = goals[index];
            selectedGoal.RecordProgress();

            if (selectedGoal.IsComplete) 
            {
                completedGoalsCount++;
                if (completedGoalsCount % BonusThreshold == 0)
                {
                    UpdateScore(BonusPoints);
                    Console.WriteLine($"Bonus! You've earned {BonusPoints} bonus points for completing {completedGoalsCount} goals.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void MarkGoalComplete(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal selectedGoal = goals[index];
            selectedGoal.MarkComplete();
            Console.WriteLine($"{selectedGoal.Name} has been marked as complete.");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void UpdateScore(int points)
    {
        totalScore += points;
        Console.WriteLine($"Total score is now {totalScore}.");
    }

    public void SaveGoals(string filename)
    {
        Console.WriteLine($"Saving goals to {filename}...");
    }

    public void LoadGoals(string filename)
    {
        Console.WriteLine($"Loading goals from {filename}...");
    }
}
