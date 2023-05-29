public class Reference
{
    private string _bookName;
    private string _chapter;
    private string _verse;
    private string _content;

    public Reference(){}
    public Reference(string bookName, string chapter, string verse, string content)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _content = content;
    }
    public string GetBookName()
    {
        return _bookName;
    }
    public void SetBookName(string bookName)
    {
        _bookName = bookName;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
    public string GetVerse()
    {
        return _verse;
    }
    public void SetVerse(string verse)
    {
        _verse = verse;
    }
    public string GetContent()
    {
        return _content;
    }
    public void SetContent(string content)
    {
        _content = content;
    }
}