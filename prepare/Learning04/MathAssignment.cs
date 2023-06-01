public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string StudentName, string Topic, string TextbookSection, string Problems) : base(StudentName, Topic)
    {
        _textbookSection = TextbookSection;
        _problems = Problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}