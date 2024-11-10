using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList=[];
        Boolean listBuild=false;
        while (listBuild==false){
        Console.WriteLine("Please enter a number greater than 0. When finished, enter 0 to show your list of numbers.");
        string input=Console.ReadLine();
        int adjustedInput=int.Parse(input);
            if (adjustedInput !=0){
                numList.Add(adjustedInput);
            }
            else{
                listBuild=true;
            }
        }
        
        int sum=0;
        int maxNum=0;

        foreach (int number in numList){
            sum=sum+number;
        }

        foreach (int number in numList) {
            if(number>maxNum){
                maxNum=number;
            }
             
        }

        int avg=sum/numList.Count;

        Console.WriteLine($"The total of the numbers in this list is {sum}");
        Console.WriteLine($"The average of the list is {avg}");
        Console.WriteLine($"The largest number in this list is {maxNum}");


    
    }
}