using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,20);

        int guessNumber = -1;
        while (number != guessNumber)
        {
            Console.Write("what is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        
            if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}