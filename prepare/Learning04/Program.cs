using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment info = new Assignment("Kevin Solorzano", "Multiplication");

        Math math = new Math("Kevin Solorzano", "multip;ication", "7.3", "8-19");

        Writing writing = new Writing("Kevin Solorzano", "European History", "The Cause of World War II");

        Console.WriteLine(info.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(info.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}