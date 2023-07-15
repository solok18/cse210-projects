public class StrengthLowerGenerator : Generator
{
    public override void Content()
    {
        _content.Add("Squats: 3 x 15");
        _content.Add("Lunges: 3 x 10");
        _content.Add("Side Lunges: 3 x 20");
        _content.Add("Wall sit: 3 x 30 seconds");
        _content.Add("Single leg deadlift: 3 x 5 (each leg)");
        _content.Add("Leg raises: 3 x 10");
        _content.Add("Split squats: 3 x 10");
        _content.Add("Calf raises: 4 x 10");
        _content.Add("Goblet squat 2 x 7");

        _listContent = _content.ToArray();
    }
}