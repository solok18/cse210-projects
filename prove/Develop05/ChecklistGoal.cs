public class ChecklistGoal : Goal
{
    protected int _completeCount {get; private set;}
    protected int _bonusPoints { get; set;}
    protected int _keepCount { get; set;}

    public ChecklistGoal(string goalTitle, string goalDescription, int goalPoints, int completeCount, int bonusPoints) : base(goalTitle, goalDescription, goalPoints)
    {
        _completeCount = completeCount;
        _bonusPoints = bonusPoints;
        _keepCount = 0;
    }

    public override void RecordGoal()
    {
        _keepCount++;
        Console.WriteLine("Checklist goal recorded");

        if (_keepCount == _completeCount)
        {
            Console.WriteLine($" Completed checklist goal bonus points earned: {_bonusPoints}");
            _goalPoints += _bonusPoints;
            _keepCount = 0;
            
        }
    }

    public override string Serialize()
    {
        return $"{base.Serialize()},{_completeCount},{_bonusPoints},{_keepCount}";
    }

    public static ChecklistGoal Deserialize(string title, string description, int points, int completionCount, int bonusPoints)
    {
        return new ChecklistGoal(title, description, points, completionCount, bonusPoints);
        
    }

}