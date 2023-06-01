public class Math : Assignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblem()
    {
        return _problems;
    }
    public void SetProblem(string problem)
    {
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}