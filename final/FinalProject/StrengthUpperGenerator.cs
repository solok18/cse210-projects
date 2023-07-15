public class StrengthUpperGenerator : Generator
{
    public override void Content()
    {
        _content.Add("Push up: 3 x 10");
        _content.Add("Bicep curl: 3 x 7");
        _content.Add("One-arm dumbbell row: 2 x 15");
        _content.Add("plank: 3 x 30 seconds");
        _content.Add("Dumbbell Flyers: 3 x 10");
        _content.Add("Hammer Curl: 3 x 8");
        _content.Add("Dumbbell pullover 3 x 8");
        _content.Add("Dumbbell bench press: 3 x 10");
        _content.Add("High plank: 3 x 30 seconds");

        _listContent = _content.ToArray();
    }
}