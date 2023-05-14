public class promptGenerator
{
    //This function will generate a random question
    //from a list of questions.
    public string[] _sentences = {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?"};
    public string getPrompt()
    {
    Random _prompt = new Random();
    int index = _prompt.Next(_sentences.Length);
    return _sentences[index];
    }
}