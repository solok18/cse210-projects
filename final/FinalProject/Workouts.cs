public abstract class Workouts
{
    protected string _workoutDescription;
    protected string _workoutName;

    public Workouts(string workoutName, string workoutDescription)
    {
        _workoutDescription = workoutDescription;
        _workoutName = workoutName;
    }

    public virtual void DisplayMessage()
    {
    }

    public virtual void DisplayQuote()
    {
    }
}