public class CardioQuoteGenerator : Generator
{
    public override void Content()
    {
        _content.Add("My cardio, my conditioning, is a weapon.");
        
        _listContent = _content.ToArray();
    
    }
}