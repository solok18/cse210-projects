public abstract class Goal
{
    public string _goalTitle { get; set;}
    public string _goalDescription { get; set;}
    public int _goalPoints { get; set;}
    // public bool _isCompleted {get; set;}

    public Goal()
    {
        
    }

    public Goal(string goalTitle ,string goalDescription, int goalPoints)
    {
        _goalTitle =goalTitle;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        // _isCompleted = false;

    }

    public virtual void RecordGoal()
    {
        
    }

    public override string ToString()
    {
        return $"{_goalTitle} - {_goalDescription} - Points: {_goalPoints}";
    }

    public virtual string Serialize()
    {
        return $"{GetType().Name},{_goalTitle},{_goalDescription}, {_goalPoints}";
    }

    public static Goal Deserialize(string serializeGoal)
    {
        string[] location = serializeGoal.Split(',');

        if(location.Length >= 4)
        {
            string type = location[0];
            string goalTitle = location[1];
            string goalDescription = location[2];
            int goalPoints = int.Parse(location[3]);
            // bool isCompleted = bool.Parse(location[4]);

            switch(type)
            {
                case nameof(SimpleGoal):
                    return SimpleGoal.Deserialize(goalTitle, goalDescription, goalPoints);

                case nameof(EternalGoal):
                    return EternalGoal.Deserialize(goalTitle, goalDescription, goalPoints);
                
                case nameof(ChecklistGoal):
                    if (location.Length >= 6)
                    {
                        int completCount = int.Parse(location[4]);
                        int bonusPoints = int.Parse(location[5]);
                        return ChecklistGoal.Deserialize(goalTitle, goalDescription, goalPoints, completCount, bonusPoints);
                    }
                    break;
                default:
                    break;
            }
        }
        return null;
    }
}