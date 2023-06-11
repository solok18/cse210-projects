public class BreathingActivity : Activity
{
    public BreathingActivity(string activityDescription, string activityName) : base(activityDescription, activityName)
    {
        Console.WriteLine($"Welcome to the {base._activityName}");
        Console.WriteLine();
        Console.WriteLine(base._activityDescription);
    }

    public void BreathIn(int duration)
    {
        Console.Write($"Breath in...");
        base.ShowCountdownTimer(duration);
    }
    public void BreathOut(int duration)
    {
        Console.Write($"Breath out...");
        base.ShowCountdownTimer(duration);
    }
    public void BreathInAndOut()
    {
        BreathIn(4);
        BreathOut(6);
    }
    
    public void Run()
    {
        base.DisplayStartMessage();
        base.ShowSpinner(3);
        DateTime startTime = DateTime.Now;
        DateTime endTime= startTime.AddSeconds(base._activityTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            BreathIn(4);
            Console.WriteLine();
            BreathOut(6);
            Console.WriteLine();
            
            i++;  
        }
        Console.WriteLine();
        base.DisplayEndMessage();
        base.ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {base._activityTime} seconds of {base._activityName}");
        base.ShowSpinner(5);

    }

}