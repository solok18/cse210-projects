public class Menu
{
    List<Goal> goals = new List<Goal>();
    int totalEarnedPoitns = 0;
   
    public Menu()
    {

        bool quit = false;
        while(!quit)
        {
            
            DisplayTotalPoints(); //Will display the total points that have been earned.

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select Choice From Menu: ");
            
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch(choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    
                    case 2:
                        Console.Clear();
                        ListNewGoals();
                        break;

                    case 3:
                        SaveNewGoals();
                        break;

                    case 4:
                        Console.Clear();
                        LoadNewGoal();
                        break;

                    case 5:
                        RecordNewGoal();
                        break;
                    
                    case 6:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
            Console.WriteLine();

        }
    }

    public void CreateNewGoal()
    {
        Console.Clear();
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("What type of goal would you like to create: ");
        
        int option;
        if (int.TryParse(Console.ReadLine(), out option))
        {
            Goal goal = null;

            switch (option)
            {
                case 1:
                    Console.Write("What is the name of your goal? ");
                    string simpleGoalTiltle = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string simpleGoalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int simplePoints = int.Parse(Console.ReadLine());

                    goal = new SimpleGoal(simpleGoalTiltle, simpleGoalDescription, simplePoints);
                    break;

                case 2:
                    Console.Write("What is the name of your goal? ");
                    string eternalGoalTiltle = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string eternalGoalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int eternalPoints = int.Parse(Console.ReadLine());
                    
                    goal= new EternalGoal(eternalGoalTiltle, eternalGoalDescription, eternalPoints);
                    break;

                case 3:
                    Console.Write("What is the name of your goal? ");
                    string checklistGoalTiltle = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string checklistGoalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be acomplished for a bonus? ");
                    int checklistCount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int checklistBonus = int.Parse(Console.ReadLine());

                    goal = new ChecklistGoal(checklistGoalTiltle, checklistGoalDescription, checklistPoints, checklistCount, checklistBonus);
                    break;


                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            if (goal != null)
            {
                goals.Add(goal);
                Console.WriteLine("Goal added.");
            }
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }    
    }

    public void ListNewGoals()
    {
        Console.WriteLine("List of Goals: ");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void RecordNewGoal()
    {
        Console.WriteLine("Enter the goal title: ");
        string goalTitle = Console.ReadLine();
        var goal = goals.Find(g => g._goalTitle.Equals(goalTitle, StringComparison.OrdinalIgnoreCase));

        if (goal != null)
        {
                goal.RecordGoal();
                Console.WriteLine("Goal is recorded");
                totalEarnedPoitns += goal._goalPoints;

        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveNewGoals()
    {
        Console.WriteLine("Enter filename:");
        string saveFile = Console.ReadLine();

        using (StreamWriter name = new StreamWriter(saveFile))
        {
            foreach (var goal in goals)
            {
                name.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goal Saved");
    }

    public void LoadNewGoal()
    {
        Console.WriteLine("Enter filename");
        string loadFile = Console.ReadLine();
        
        if (File.Exists(loadFile))
        {
            goals.Clear(); // will clear existing goals before uploading new ones.

            using (StreamReader goalName = new StreamReader(loadFile))
            {
                string line;
                while ((line = goalName.ReadLine()) != null)
                {   
                    
                    Goal goal = Goal.Deserialize(line);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals: ");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
            
        }
        else
        {
            Console.WriteLine("No files found");
        }
    }

    public void DisplayTotalPoints()
    {
        Console.WriteLine($"You have {totalEarnedPoitns}");
    }
}
