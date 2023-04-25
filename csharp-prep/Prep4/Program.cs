using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of number, type 0 when finish.");
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            // Wil add the numbers enter by the user except the 0 to the list.
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        // Adds the numbers in the list and gets the total.
        int sum = numbers.Sum();
        Console.WriteLine("The sum is: {0}", sum);

        // Will get the average for the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        Console.WriteLine("the Maximum is: " + numbers.Max());

        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.ReadLine();
    }
}