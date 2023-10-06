using System.Diagnostics.CodeAnalysis;

public class MathAssignment : Assignment
{
    
    private string _textbookSection;
    private string _problems;


    // Because we call in the base metthods object onthe contructor to handle the parameters that has been taken care of in the base class
    // now we have two parameters left to be taken care of in this constructor


    public  MathAssignment(String studentname, string topic, string textbookSection, string problems): base (studentname, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}