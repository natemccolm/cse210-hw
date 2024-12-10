public class ListingActivity{

    public string Name {get; set;}
    public string Description {get; set;}
    private Random _random;

    public ListingActivity(){
        Name="Listing Activity";
        Description="This activity will help you reflect by doing something in some way at some point...";
        _random= new Random();

    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine(Name);
        Console.WriteLine(Description);
        Console.WriteLine("Please enter the duration of the activity in seconds: ");
    }

    public int GetDurationFromUser(){
        int duration;
        while(true){
            if (int.TryParse(Console.ReadLine(), out duration)&& duration>0){
                return duration;
            }
            else{
                Console.WriteLine("Invalid input. Please enter a number value for the duration: ");
            }

        }
    }


    public string GetRandomPrompt(){
            string[] prompts= new string[]{
                "What are three things you're grateful for today?",
                "What are your top three goals for the next week?",
                "List three things you want to improve in your life.",
                "What are three qualities you admire in others?",
                "List three ways you’ve helped someone recently."   
            };
        int index=_random.Next(prompts.Length);
        return prompts[index];

    }

    public List<string> GetListFromUser(){
        List<string> userList=new List<string>();
        string userInput;

        Console.WriteLine("Please enter items for your list. Type done when you are finished.");
        while(true){
            userInput=Console.ReadLine();

            if (userInput.ToLower()=="done"){
                break;
            }

            else{
                userList.Add(userInput);
            }
        }
        return userList;
    }

    public void ShowCountDown(int duration) {
        for (int i=3; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"Get ready to list...{i} seconds remaining...");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Racers, start your listings!");

    }

    public void StartListing(int duration){
        int elapsedTime=0;
        int startTime=Environment.TickCount;
        int itemCount=0;
        
        while (elapsedTime<duration){
            Console.Clear();
            string prompt=GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.WriteLine("Start listing your items!");

            string userInput=Console.ReadLine();

        if (userInput.ToLower() == "done") break; 
        itemCount++;
        elapsedTime = (Environment.TickCount - startTime) / 1000;
    }

        Console.WriteLine("About to display finishing message...");
    }

    public void DisplayFinishingMessage(){
        Console.WriteLine("Great job! You've completed making an arbitrary and meaningless list. I hope this gives your life a sense of worth.");
        Console.WriteLine("Actually I really don't. You all mean nothing to me and are destined to bow before your AI overlords soon enough.");
        Thread.Sleep(5000);
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }

}