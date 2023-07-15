public class CardioSingleOrSetMenu : MainMenu
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
                    SingleCardio one = new SingleCardio();
                    break;
                
                case 2:
                    Console.Clear();
                    SetCardio set = new SetCardio();
                    
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