public class MainMenu
{
    public MainMenu()
    {}

    public virtual void DisplayMenu()
    {
        List<string> choices = new List<string>()
        {
            "Cardio",
            "Strength",
            "Quit",
        
        };

        Menu menu = new Menu(choices);
        int selectChoice;
        do
        {
            selectChoice = menu.Show();

            switch (selectChoice)
            {
                case 1:
                    Console.Clear();
                    CardioWorkout cardio = new CardioWorkout("Cardio","A rhythmic activity that raises your heart rate into your target heart rate zone. This is the zone where you burn the most fat and calories.");
                    Console.WriteLine();
                    cardio.Run();
                    Console.WriteLine();
                    
                    CardioSingleOrSetMenu type = new CardioSingleOrSetMenu();
                    type.DisplayMenu();
                    break;
                
                case 2:
                    Console.Clear();
                    StrengthWorkout strenght = new StrengthWorkout("Strength", "The performance of physical exercises that are designed to improve strength and endurance.");
                    Console.WriteLine();
                    strenght.Run();
                    Console.WriteLine();

                    StrengthMenu type2 = new StrengthMenu();
                    type2.DisplayMenu();

                    
                    
                    break;
                
                case 3:
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
            Console.WriteLine();
        }while (selectChoice !=3);
    }
    

} 