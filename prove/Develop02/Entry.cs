public class Entry
{
    
    //Fields
    public DateTime _newDate {get; set;}
    public string _newPrompt {get; set;}
    public string _newResponse {get; set;}
    public string _showEntry {get; set;}

    public void EntryOutput(DateTime _date, string _prompt, string _response)
    {
        _newPrompt = _prompt;
        _newDate = _date;
        _newResponse = _response;

        Console.WriteLine($"Date: {_newDate.ToString("MM-dd-yyyy")} - Prompt: {_newPrompt}");
        Console.WriteLine($"{_newResponse}");
    }



    
}