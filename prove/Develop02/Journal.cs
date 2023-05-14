public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _entry)
    {
        _entries.Add(_entry);
    }

    public void CreateNewEntry()
    {
        promptGenerator _prompt = new promptGenerator();
        string _newPrompt = _prompt.getPrompt();
        DateTime _date = DateTime.Today;
        Console.WriteLine($"Prompt: {_newPrompt}");
        string _userInput = Console.ReadLine();
        
        Entry newEntry = new Entry();
        newEntry.EntryOutput(_date, _newPrompt, _userInput);
        AddEntry(newEntry);
    }

    public void DisplayEntry()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.EntryOutput(_entry._newDate, _entry._newPrompt, _entry._newResponse);
            Console.WriteLine();
        }
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
    }

    public void SaveEntry(string fileName)
    {
        using (StreamWriter textFile = new StreamWriter(fileName))
        {
            foreach (Entry _entry2 in _entries)
            {
                textFile.WriteLine($"{_entry2._newDate.ToString("MM-dd-yyyy")} - {_entry2._newPrompt}");
                // textFile.WriteLine(_entry2._newPrompt);
                textFile.WriteLine(_entry2._newResponse);
                textFile.WriteLine();
            }
        }
        Console.WriteLine("Entries saved to file successfully.");
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
    }

    public void LoadEntry(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            return;
        }
        

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
    }
}