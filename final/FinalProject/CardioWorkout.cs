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
        Console.WriteLine("In two weeks, you'll feel it. In four weeks you'll see it. In eight weeks, you'll hear it");
    }

    public override void DisplayQuote()
    {
        CardioQuoteGenerator quote = new CardioQuoteGenerator();
        quote.Content();
        quote.GetRandomItem(1);
    }

    public void Run()
    {
        DisplayMessage();
        DisplayQuote();
    }
}