public class SingleLowerWorkout
{
    public SingleLowerWorkout()
    {
        StrengthLowerGenerator lower = new StrengthLowerGenerator();
        lower.Content();
        lower.GetRandomItem(1);
    }
}