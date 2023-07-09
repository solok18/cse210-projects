public class SetLowerWorkout
{
    public SetLowerWorkout()
    {
        StrengthLowerGenerator lower = new StrengthLowerGenerator();
        lower.Content();
        lower.GetRandomItem(3);
    }
}