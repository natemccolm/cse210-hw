using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
    }

     
     public static void ShowMenu(){

     while(true){
        
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App");
        Console.WriteLine("Please make a selection from the options below: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit the app");

        string userInput=Console.ReadLine();


        if (userInput=="1"){
            RunBreathingActivity();
        }

        else if (userInput=="2"){
            RunReflectingActivity();
        }

        else if (userInput=="3"){
            RunListingActivity();
        }

        else if (userInput=="4"){
            Console.WriteLine("Buh bye now!");
            break;
        }

        else{
            Console.WriteLine("Invalid input. Please enter a number value of 1-4.");
            Console.ReadKey();
        }
     }
    }
     
    public static void RunBreathingActivity(){
        BreathingActivity activity = new BreathingActivity();
        activity.DisplayStartingMessage();
        int duration = activity.GetDurationFromUser();
        activity.ShowCountDown(duration);
        activity.DisplayBreathingPrompts(duration);
        activity.DisplayFinishingMessage();
        Console.ReadKey();
    }

    public static void RunReflectingActivity(){
        ReflectingActivity activity=new ReflectingActivity();

        activity.DisplayStartingMessage();
        activity.DisplayPrompt();
        activity.DisplayQuestions();
        string reflection=activity.CaptureReflection();
        activity.DisplayReflection(reflection);

    }


    public static void RunListingActivity(){
        ListingActivity activity = new ListingActivity();
        activity.DisplayStartingMessage();
        int duration=activity.GetDurationFromUser();
        activity.ShowCountDown(duration);
        activity.StartListing(duration);
        activity.DisplayFinishingMessage();
    }
}
