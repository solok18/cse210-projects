using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> choices = new List<string>()
        {
            "Start breathing activity",
            "Start reflecting activity",
            "Start listening activity",
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
                    BreathingActivity breath = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","Breathing Activity");
                    Console.WriteLine();
                    breath.GetActivityTime();
                    Console.Clear();
                    breath.Run();
                    Console.Clear();
                    break;
                
                case 2:
                    Console.Clear();
                    ReflectionActivity reflect = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","Reflection Activity");
                    Console.WriteLine();
                    reflect.GetActivityTime();
                    Console.Clear();
                    reflect.Run();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    ListingActivity listen = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listening Activity");
                    Console.WriteLine();
                    listen.GetActivityTime();
                    listen.Run();
                    Console.Clear();
                    break;
                
                case 4:
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
            Console.WriteLine();
        }while (selectChoice !=4);
    }
}
