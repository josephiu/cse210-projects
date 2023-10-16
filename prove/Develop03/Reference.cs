public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter= chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter= chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string  GetDisplayText()
    {
        if(_endVerse == null)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse} - {_endVerse}";
    }

 }