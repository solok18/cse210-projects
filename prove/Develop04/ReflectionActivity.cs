public class ReflectionActivity : Activity
{

    public ReflectionActivity(string activityDescription, string activityName) : base(activityDescription, activityName)
    {
        Console.WriteLine($"Welcome to the {base._activityName}");
        Console.WriteLine();
        Console.WriteLine(base._activityDescription);
    }
    public List<string> GetQuestion()
    {
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");


        return questions;
    }

    public List<string> GetPrompt()
    {
        List<string> prompt = new List<string>();
        prompt.Add("Think of a time when you stood up for someone else.");
        prompt.Add("Think of a time when you did something really difficult.");
        prompt.Add("Think of a time when you helped someone in need.");
        prompt.Add("Think of a time when you did something truly selfless.");

        return prompt;
    }
    
    public string GetRandomQuestion()
    {
        
        Random random = new Random();
        int index = random.Next(GetQuestion().Count);

        string randomQuestion = GetQuestion()[index];
        
        return randomQuestion;
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

        Console.WriteLine("Consider the fallowing prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When you have someting in mind, press enter to continue.");
        Console.ReadKey();
        Console.Write("You may begin in: ");
        base.ShowCountdownTimer(5);
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime endTime= startTime.AddSeconds(base._activityTime);

        int i = 0;
        int halfTime = base._activityTime/2;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write(GetRandomQuestion());
            base.ShowSpinner(halfTime);
            Console.WriteLine();
            Console.Write(GetRandomQuestion());
            base.ShowSpinner(halfTime);
            Console.WriteLine();
            
            i++;  
        }
        Console.WriteLine();
        base.DisplayEndMessage();
        base.ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {base._activityTime} seconds of {base._activityName}");
        base.ShowSpinner(5);

    }
}