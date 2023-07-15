public class CardioGenerator : Generator
{

    public override void Content()
    {
        _content.Add("Burpees: 3 x 10");
        _content.Add("Jump Rope: 3 x 1 minute");
        _content.Add("Jumping Jacks: 3 x 1 minute");
        _content.Add("Squat Jumps: 5 x 10");
        _content.Add("Kickboxing: 10 minutes");
        _content.Add("Dancing: 10 minutes");
        _content.Add("Running the Stairs: 10 minutes");
        _content.Add("Jogging in Place: 3 x 1 minute");
        _listContent = _content.ToArray();
    }

    


    
}