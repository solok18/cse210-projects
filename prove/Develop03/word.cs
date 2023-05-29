public class Word
{
    private string _word;
    private bool _reveal;

    public Word(){}
    public Word(string word)
    {
        _word = word;
        _reveal = true;
    }

    public Word(string word, bool reveal)
    {
        _word = word;
        _reveal = reveal;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
    public bool GetReveal()
    {
        return _reveal;
    }

    public void SetReveal(bool reveal)
    {
        _reveal = reveal;
    }
}