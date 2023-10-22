public class Comment
{
    public string _commenter;
    public string _text ;


    public string GetComenter()
    {
        return _commenter;
    }

    public string GetText()
    {
        return _text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter}: {_text}");
    }


}

