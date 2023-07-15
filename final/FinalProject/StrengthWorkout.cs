public class StrengthWorkout : Workouts
{
    public StrengthWorkout(string workoutName, string workoutDescription) : base(workoutName, workoutDescription)
    {
        Console.WriteLine($"Lets do some {base._workoutName}");
        Console.WriteLine();
        Console.WriteLine(base._workoutDescription);
    }

    public override void DisplayMessage()
    {
        Console.WriteLine("Today you will be working towards the strengh of Hercules");
        Console.WriteLine();
    }

    public override void DisplayQuote()
    {
        StrengthQuoteGenerator quote = new StrengthQuoteGenerator();
        Console.WriteLine("Quote of the day: ");
        quote.Content();
        quote.GetRandomItem(1);
    }

    public void Run()
    {
        DisplayMessage();
        DisplayQuote();
    }
}