public class Menu
{
    private List<string> _options;

    public Menu(List<string> options)
    {
        _options = options;
    }

    public int Show()
    {
        Console.WriteLine("Menu Options:");
        for (int i = 0; i <_options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }
        int selectChoice = GetValidChoice();
        return selectChoice;

    }

    public int GetValidChoice()
    {
        int selectChoice;
        while (true)
        {
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out selectChoice) && selectChoice >= 1 && selectChoice <= _options.Count)
            {
                break;
            }
            Console.WriteLine("Invalid Choice.");
        }

        return selectChoice;
    }
    public override string ToString()
    {
        return string.Join(", ", _options);
    }
}