public class MainMenu
{
    public MainMenu()
    {
        List<string> choices = new List<string>()
        {
            "Cardio",
            "Strenght",
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
                    CardioWorkout cardio = new CardioWorkout("Cardio","Today you will be working out to the rythm of your heart, Lets get ready to move our bodies and our heat pumping");
                    Console.WriteLine();
                    cardio.Run();
                    break;
                
                case 2:
                    
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