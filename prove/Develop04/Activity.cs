public class Activity
{
    protected string _activityDescription;
    protected string _activityName;
    protected int _activityTime;

    public Activity(string activityDescription, string activityName)
    {
        _activityDescription = activityDescription;
        _activityName = activityName;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine("Get Ready");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done");
    }
    public int GetActivityTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        _activityTime = int.Parse(time);
        return _activityTime;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }

    public void ShowCountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime= startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }


}