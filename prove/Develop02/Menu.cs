using System.IO;
public class Menu
{
    public void Display()
    {
        Journal _entry = new Journal();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");

            String userInput = Console.ReadLine();
                // int selection = int.Parse(userInput);
            if (userInput == "1")
            {
                Console.WriteLine();
                _entry.CreateNewEntry();
                    
            }
            else if (userInput == "2")
            {
                Console.WriteLine();
                _entry.DisplayEntry();
                Console.WriteLine();
                
            }
            else if (userInput == "3")
            {
                Console.WriteLine();
                Console.WriteLine("Enter file name to load entries: ");
                string fileName = Console.ReadLine();
                _entry.LoadEntry(fileName);
                Console.WriteLine();
            }
            else if (userInput == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Enter file name to save entries: ");
                string fileName = Console.ReadLine();
                _entry.SaveEntry(fileName);
                Console.WriteLine("Entries saved to file successfully.");
            }
            else if (userInput == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Option");
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}