using System;

class Program
{
    static void Main(string[] args)
    
    {
        int tries=1;
        Random randomGenerator=new Random();
        int number=randomGenerator.Next(1,11);
        Console.WriteLine($"{number}");
        Boolean fun=false;
        while (fun==false){
        
                Console.WriteLine("Please enter a guess of a number between 1-10: ");
                string input=Console.ReadLine();
                int adjustedNum=int.Parse(input);

                Console.WriteLine($"Your guess was {adjustedNum}");
                    if (number<adjustedNum){
                        Console.WriteLine("Your guess is lower than the number our underpants gnomes selected. Please try again.");
                        tries ++;
                    }
                    else if (number>adjustedNum){
                        Console.WriteLine($"Your guess is higher than the number our underpants gnomes selected. Please try again.");
                        tries ++;
                    }
                    else {
                        Console.WriteLine($"Your guess of {adjustedNum} matches the number our underpants gnomes selected! Get yourself a cookie, ?, PROFIT!");
                        Console.WriteLine($"It took you {tries} guess(es) to choose the correct number picked by our underpants gnomes!");
                        fun=true;
                    }
        }
    }
}