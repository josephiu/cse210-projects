public class Word
{
    private string _text;
    private bool _isHidden;
    public bool IsHidden{ get{return _isHidden;} set{_isHidden = value;}}

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if(_isHidden)
        {
            string text = "";
            foreach(char letter in _text)
            {
                text += "_";
            }
            return text;
        }
        else
            return _text;
    }

    // //GETTER
    // public string GetText()
    // {
    //     // Additional logic...
    //     return _text;
    // }

    // //SETTER
    // public void SetText(string text)
    // {
    //     _text = text;
    //     // Additional logic...
    // }
}

