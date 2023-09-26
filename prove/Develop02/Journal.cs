
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    

    public void AddEntry(Entry myname)
    {
       _entries.Add(myname);    

    }

    public void DisplayAll()
    {
        foreach(Entry item in _entries)
        {
            
            Console.WriteLine(item);

            
        }
    }

    public void SaveToFile(string file)
    {

    }

    
}   