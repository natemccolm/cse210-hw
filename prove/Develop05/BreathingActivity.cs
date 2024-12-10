public class BreathingActivity{

    public string Name {get;set;}
    public string Description {get; set;}

    public BreathingActivity(){
        Name="Breathing Activity";
        Description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.";
    }

    public void DisplayStartingMessage(){
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine("Please enter the duration of the activity in seconds: ");
    }

    public int GetDurationFromUser(){
            int duration;
            while(true){
                if (int.TryParse(Console.ReadLine(), out duration) && duration>0)
                    {
                        return duration;
                    }

                else{
                    Console.WriteLine("Invalid input. Please enter a valid number for the duration.");
                }
            }
    }

    public void ShowCountDown(int duration){
        int countdownDuration=3;
        for (int i=countdownDuration; i>0; i--){
            Console.Clear();
            Console.WriteLine($"Activity starts in {i} seconds...");
            Thread.Sleep(1000);
        }
        DisplayBreathingPrompts(duration);
    }

       public void DisplayFinishingMessage(){
        Console.Clear();
        Console.WriteLine("Good Job! You've completed the breathing activity!");
        Console.WriteLine("Press any key to return to the menu.");
    }

public void DisplayBreathingPrompts(int duration)
{
    int remainingTime = duration;

    while (remainingTime > 0)
    {
        Console.Clear();
        Console.WriteLine("Breathe in...");
        PauseWithCountdown(3, "Breathe in... Time left: ");
        remainingTime -= 3;

        if (remainingTime <= 0) break;

        Console.Clear();
        Console.WriteLine("Breathe out...");
        PauseWithCountdown(3, "Breathe out... Time left: ");
        remainingTime -= 3;
    }
}

public void PauseWithCountdown(int seconds, string message)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.SetCursorPosition(0, 1);
        Console.WriteLine($"{message}{i} seconds remaining   ");
        Thread.Sleep(1000);
    }
}


 

}
