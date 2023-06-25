public class SimpleGoal : Goal
{
    public SimpleGoal(string goalTitle ,string goalDescription, int goalPoints) : base(goalTitle ,goalDescription, goalPoints)
    {

    }

    public override void RecordGoal()
    {
        Console.WriteLine("Simple goal was recorded");
        
    }
    public static SimpleGoal Deserialize(string title, string description, int points)
    {
        return new SimpleGoal(title, description, points);
        
    }
}