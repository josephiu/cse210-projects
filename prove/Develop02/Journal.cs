

using System.ComponentModel;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    

    public void AddEntry(Entry myname)
    {
       _entries.Add(myname);    

    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            
           entry.Display();
            
        }
    }

    public void SaveToFile(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)

            outputFile.WriteLine($"Date:{entry._date}:Prompt:{entry._promptText}:MyResponse:{entry._entryText}");
        }
    }

 


   

    public void LoadFromFile(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);

        //this will empty the console while we reload the files
        
       _entries = new List<Entry>();


        foreach(string line in lines)
        {
                  
      
            string[] splt = line.Split(":");

            // Console.WriteLine($"{splt[0]} {splt[1]} {splt[2]} {splt[3]} {splt[4]} {splt[5]}");

                     
            
            Entry savingFile = new Entry();     

            
            savingFile._date = splt[1];
            savingFile._promptText = splt[3];
            savingFile._entryText = splt[5];
            
            //This adds the filles to the AddEntry Function
            AddEntry(savingFile);

         
        

            
        }
    }
   

}   