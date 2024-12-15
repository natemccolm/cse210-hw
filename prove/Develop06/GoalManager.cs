using System;
using System.Collections.Generic;
public class GoalManager{

    private List<Goal> goals=new List<Goal>();
    private int totalScore=0;
    public List<Goal> Goals => goals;
    public void AddGoal (Goal goal)
    {
        goals.Add(goal);
    }

    public virtual void DisplayAllGoals(){

        foreach (Goal goal in goals){
            goal.DisplayGoal();
        }

    }

    public void MarkGoalComplete (Goal goal) {
        if (goal is SimpleGoal simpleGoal){
            UpdateScore(simpleGoal.Points);
            Console.WriteLine($"{simpleGoal.Name} completed! {simpleGoal.Points} points awarded!");
        }
        else if (goal is EternalGoal eternalGoal){
            UpdateScore(eternalGoal.Points);
            Console.WriteLine($"{eternalGoal.Name} progress recorded! {eternalGoal.Points} awarded!");
        }

        else if (goal is ChecklistGoal checklistGoal){
            UpdateScore(checklistGoal.Points);
            Console.WriteLine($"{checklistGoal.Name} progress recorded! {checklistGoal.Points} awarded!");
        }
    }

    private void UpdateScore (int points){
        totalScore += points;
        Console.WriteLine($"Total score is now {totalScore}.");
    }

    public void SaveGoals(string filename){
        using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Score: {totalScore}");
                foreach (Goal goal in goals){
                    if (goal is SimpleGoal simpleGoal){
                        writer.WriteLine($"Simple | {simpleGoal.Name} | {simpleGoal.Description} | {simpleGoal.Points} ");
                    }
                    else if (goal is EternalGoal eternalGoal) {
                        writer.WriteLine($"Eternal | {eternalGoal.Name} | {eternalGoal.Description} | {eternalGoal.Points} ");
                    }
                    else if (goal is ChecklistGoal checklistGoal){
                        writer.WriteLine($"Checklist | {checklistGoal.Name} | {checklistGoal.Description} | {checklistGoal.Points} | {checklistGoal.TimesToComplete} | {checklistGoal.TimesCompleted} | {checklistGoal.BonusPoints}");
                    }
                }
            }
            Console.WriteLine("Goals successfully saved!");
        }

    public void LoadGoals(string filename){
        if(!File.Exists(filename)){
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename)){
            string scoreLine = reader.ReadLine();
            totalScore = int.Parse(scoreLine.Split(':')[1]);

            string line;
            while ((line=reader.ReadLine()) !=null){
                string[] parts = line.Split('|');
                string type = parts [0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = type switch{
                    "Simple"=> new SimpleGoal(name, description, points){
                        IsComplete=bool.Parse(parts[4])
                    },

                    "Eternal" => new EternalGoal(name, description, points),
                    "Checklist" => new ChecklistGoal(name, description, points){
                        TimesToComplete = int.Parse(parts[4]),
                        TimesCompleted = int.Parse(parts[5]),
                        BonusPoints = int.Parse (parts[6])
                    },
                    _=> null
                };
                if (goal != null){
                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals successfully loaded!");       
    }
}