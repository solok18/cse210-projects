public abstract class Generator
{
    protected List<string> _content;
    protected string[] _listContent;

    public Generator()
    {
        _content = new List<string>();
        
    }

    public abstract void Content();

    public void GetRandomItem(int howMany)
    {
        List<string> printList = new();
        for(int i = 0; i < howMany; i++)
        {
            Random ranItem = new();
            int rand = ranItem.Next(_content.Count);
            printList.Add(_content[rand]);
            _content.RemoveAt(rand);
        }

        _content.Clear();
        _content.AddRange(_listContent);
        foreach(var item in printList)
        {
            Console.WriteLine(item);
        }
    }

}