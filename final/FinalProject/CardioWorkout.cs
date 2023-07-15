public class CardioWorkout : Workouts
{
    public CardioWorkout(string workoutName, string workoutDescription) : base(workoutName, workoutDescription)
    {
        Console.WriteLine($"Lets do some {base._workoutName}");
        Console.WriteLine();
        Console.WriteLine(base._workoutDescription);
    }

    public override void DisplayMessage()
    {
        Console.WriteLine("Today you will be working out to the rhythm of your heart, Lets get ready to move our bodies and our heart pumping");
        Console.WriteLine();
    }

    public override void DisplayQuote()
    {
        CardioQuoteGenerator quote = new CardioQuoteGenerator();
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