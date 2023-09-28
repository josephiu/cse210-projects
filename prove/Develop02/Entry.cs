
public class Entry
{
    public string _date;
    public string _promptText;
    
    public string _entryText;

    
    
      public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\nMy Response: {_entryText}\n"); //I exceeded requirement by adding my response tag to the display
    }
    
}   