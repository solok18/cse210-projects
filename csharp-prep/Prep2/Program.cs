using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade score? ");
        string userInput = Console.ReadLine();
        int gradeScore = int.Parse(userInput);

        int remainder = gradeScore % 10;
        string letter = "";
        string sign = "";

        if (gradeScore >= 90)
        {
            letter = "A";
        }
        else if (gradeScore >= 80)
        {
            letter = "B";
        }
        else if (gradeScore >= 70)
        {
            letter = "C";
        }
        else if (gradeScore >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradeScore >= 97)
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if(gradeScore >=70)
        {
            Console.WriteLine("Congratulations you pass");
        }
        else
        {
            Console.WriteLine("Dont quit just yet, try again");
        }
    }
}