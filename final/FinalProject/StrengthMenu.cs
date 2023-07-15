public class StrengthMenu : MainMenu
{

    public override void DisplayMenu()
    {
        List<string> choices = new List<string>()
        {
            "Chest Day",
            "Leg Day",
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
                    UpperStrengthMenu chest = new UpperStrengthMenu();
                    chest.DisplayMenu();
                    break;
                
                case 2:
                    Console.Clear();
                    LowerStrengthMenu leg = new LowerStrengthMenu();
                    leg.DisplayMenu();
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