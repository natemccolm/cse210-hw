using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your numeric grade percentage (1-100): ");
        string gradePercentage=Console.ReadLine();
        int number=int.Parse(gradePercentage);
        string letter=("");
        if (number>=90) {
            letter=("A");
        }
        else if (number<90 && number>=80) {
            letter=("B");
        }
        else if (number<80 && number>=70) {
            letter=("C");
        }
        else if (number<70 && number>=60) {
            letter=("D");
        }
        else if (number<60) {
            letter=("F");
        }
        else {
            Console.WriteLine("Please enter a valid number of 1-100");
        }


    Console.WriteLine($"A grade of {number} comes out to a letter grade of {letter}!");
        if (number>=70) {
            Console.WriteLine("Congratulations, you passed the class! Have a cookie and a gold star!");
        }
        else {
            Console.WriteLine("You did not pass. You have brought shame to the next dozen generations of your family. Even Xenu himself weeps at your pathetic and miserable attempt.");
        }
    }
}