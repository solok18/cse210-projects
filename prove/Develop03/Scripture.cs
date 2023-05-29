public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList;

    public Reference GetReference()
    {
        return _reference;
    }

    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public List<Word> GetWordList()
    {
        return _wordList;
    }
    public void SetWordList(List<Word> wordList)
    {
        _wordList = wordList;
    }
      

    public string WordsHidden(string word)
    {
        string wordsThatWillHide = string.Empty;
        foreach (char c in word)
        // for (int i = 0; i < word.Length; i++)
        {
            // wordsThatWillHide += "_";
            if (char.IsLetter(c))
            {
                wordsThatWillHide += '_';
            }
            else
            {
                wordsThatWillHide += c;
            }
        }
        return wordsThatWillHide;
    }
}