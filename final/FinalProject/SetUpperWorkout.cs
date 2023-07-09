public class SetUpperWorkout
{
    public SetUpperWorkout()
    {
        StrengthUpperGenerator upper = new StrengthUpperGenerator();
        upper.Content();
        upper.GetRandomItem(3);
    }
}