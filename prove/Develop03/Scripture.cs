public class Scripture
{
    private Reference _reference;
    private List<Word>_words = new List<Word>();

    
    public List<string> _mywords  = new List<string>();
    string _justAdd;


// contructor
    public Scripture(Reference Reference, string text)


    {

        _reference = Reference;
        
          string[] words = text.Split(" ");

             

        foreach (var item in words)

        {

            Word word = new Word(item);
        
            _words.Add(word);

            

             //Console.WriteLine($"{word} ");


          
            


            
           

        }
    }

    //getter that get the _words from the private list
 

       


 

    public void HideRandomWords()
    {  


        Random randomGenerator = new Random();
        int prompting = randomGenerator.Next(_words.Count);
        string promted = _words[prompting];

        return promted;
        
 
       
    }


    

    public string GetDisplayText()
    {

    }

    public bool IsCompletelyHidden()
    {
        
    }



}