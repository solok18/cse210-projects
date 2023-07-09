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
        base.DisplayMessage();
    }

    public override void DisplayQuote()
    {
        base.DisplayQuote();
    }
}