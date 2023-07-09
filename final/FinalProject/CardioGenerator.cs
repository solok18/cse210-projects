public class CardioGenerator : Generator
{

    public override void Content()
    {
        _content.Add("Burpees");
        _content.Add("Jump Rope");
        _content.Add("Jumping Jacks");
        _content.Add("Squat Jumps");
        _content.Add("Kickboxing");
        _content.Add("Dancing");
        _content.Add("Running the Stairs");
        _content.Add("Jogging in Place");
        _listContent = _content.ToArray();
    }

    // public override void GetRandomItem(int howMany)
    // {
    //     Console.WriteLine("Single Cardio Workout");
    //     base.GetRandomItem(howMany);
    // }



    
}