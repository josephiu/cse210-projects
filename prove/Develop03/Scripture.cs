using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    // contructor
    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        string[] words = text.Split(" ");

        foreach (string i in words)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }


    public void HideRandomWords()
    {
        Random randomGenerator = new Random();
        int counter = 0;
        while (counter < 3 && !IsCompletelyHidden())
        {
            int index = 0;
            do
                index = randomGenerator.Next(_words.Count);
            while (_words[index].IsHidden == true);
            _words[index].IsHidden = true;
            counter++;
        }
    }


    public void DisplayWords()
    {
        Console.Write(_reference.GetDisplayText());
        Console.Write("\"");
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText());
            Console.Write(" ");
        }
        Console.Write("\"");
    }


    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }



}