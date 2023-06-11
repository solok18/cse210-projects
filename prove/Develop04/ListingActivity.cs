public class ListingActivity : Activity
{

    public ListingActivity(string activityDescription, string activityName) : base(activityDescription, activityName)
    {
        Console.WriteLine($"Welcome to the {base._activityName}");
        Console.WriteLine();
        Console.WriteLine(base._activityDescription);
    }

    public List<string> GetPrompt()
    {
        List<string> prompt = new List<string>();
        prompt.Add("Who are people that you appreciate?");
        prompt.Add("What are personal strengths of yours?");
        prompt.Add("Who are people that you have helped this week?");
        prompt.Add("When have you felt the Holy Ghost this month?");
        prompt.Add("Who are some of your personal heroes?");

        return prompt;
    }

     public string GetRandomPrompt()
    {
        
        Random random = new Random();
        int index = random.Next(GetPrompt().Count);

        string randomPrompt = GetPrompt()[index];
        
        return randomPrompt;
    }

    public void Run()
    {
        base.DisplayStartMessage();
        base.ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the fallowing promp:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");
        base.ShowCountdownTimer(5);
        Console.WriteLine();


        DateTime startTime = DateTime.Now;
        DateTime endTime= startTime.AddSeconds(base._activityTime);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string list = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(list))
            {
                i++; 
            } 
        }
        Console.WriteLine();
        base.DisplayEndMessage();
        base.ShowSpinner(3);
        Console.WriteLine($"You listed: {i}");
        Console.WriteLine();
    

        Console.WriteLine($"You have completed another {base._activityTime} seconds of {base._activityName}");
        base.ShowSpinner(5);

    }
}