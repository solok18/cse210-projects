public class LowerStrengthMenu : MainMenu
{

    public override void DisplayMenu()
    {
        List<string> choices = new List<string>()
        {
            "Single",
            "Set",
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
                    SingleLowerWorkout legDay = new SingleLowerWorkout();
                    break;
                
                case 2:
                    Console.Clear();
                    SetLowerWorkout ledDay2 = new SetLowerWorkout();

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