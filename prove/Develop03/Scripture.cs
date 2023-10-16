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

        foreach (string i  in words)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }



    public void  HideRandomWords()
    {  
        Word word = new Word();
        Random randomGenerator = new Random();
        int counter = 0;
        while (counter < 3 && !IsCompletelyHidden())
        {
            int index = 0;
            do
                index = randomGenerator.Next(word.count);
            while ( words[index].IsHidden == true );
                words[i].IsHidden == true;
                counter++;
        }
       
    }

    public void DisplayWords()
    {
            foreach word in words
                Console.Write( word.GetdisplayText());
                Console.WriteLine();

               
    }



    public bool IsCompletelyHidden()
    {
        foreach (var word in words)
        {
             if (!word.IsHidden)
             {
                return  false;
             }
        }
            
        return true;

        
            
    }



}