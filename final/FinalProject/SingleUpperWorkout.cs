public class SingleUpperWorkout
{
    public SingleUpperWorkout()
    {
        StrengthUpperGenerator upper = new StrengthUpperGenerator();
        upper.Content();
        upper.GetRandomItem(1);
    }
}