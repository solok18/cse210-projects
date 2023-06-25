public class EternalGoal : Goal
{

    public EternalGoal(string goalTitle ,string goalDescription, int goalPoints) : base(goalTitle, goalDescription, goalPoints)
    {
      
    }

    public override void RecordGoal()
    {
        Console.WriteLine("Eternal goal was recorded.");
    }

     public static EternalGoal Deserialize(string title, string description, int points)
    {
        return new EternalGoal(title, description, points);
       
    }
    
}