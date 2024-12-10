using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity{

    public string Name {get;set;}
    public string Description {get;set;}
    private Random _random;

    public ReflectingActivity(){
        Name="Reflecting Activity";
        Description="Something motivational and sappy about a kitten in a tree hanging in there or whatever.";
        _random=new Random();
    }
  

        public void DisplayStartingMessage(){
            
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine("Take a moment to reflect on a meaningful experience in your life. Or don't. We won't know or judge either way: ");

        }

        public string GetRandomPrompt(){
            string[] prompts=new string[]{
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            int index =_random.Next(prompts.Length);
            return prompts[index];
        }

        public void DisplayPrompt(){
            string prompt=GetRandomPrompt();

            Console.Clear();
            Console.WriteLine("Reflection prompt: ");
            Console.WriteLine(prompt);
            Console.WriteLine("Take a few moments to reflect on this.");
        }

        public void DisplayQuestions(){
            string question=GetRandomQuestion();

            Console.Clear();
            Console.WriteLine("Reflection question: ");
            Console.WriteLine(question);
            Console.WriteLine("Take a few moments to reflect on your answer.");

            Thread.Sleep(5000);
        }


        public string GetRandomQuestion(){
            var questions = new List<string>{
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            int randomIndex=_random.Next(questions.Count);

            return questions[randomIndex];
        }

        public string CaptureReflection(){
            Console.WriteLine("Please take a moment to reflect and type your response below. Press enter when finished to move to the next prompt: ");

            string reflection=Console.ReadLine();
            return reflection;

        }

    public void DisplayReflection(string reflection){
        Console.Clear();
        Console.WriteLine($"Your reflection: {reflection}");
        Console.Write("Good job! You've wasted time reflecting on things. Hit any key to return to the menu.");
        Console.ReadKey();
    }


}





