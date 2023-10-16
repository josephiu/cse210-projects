public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public void setName(string name)
    {
        _name = name;
    }

    public string getName()
    {
       return _name;
    }


    public void setdescription(string description)
    {
        _description = description;
    }

    public string getdescription()
    {
       return _description;
    }



    public void setduration(int duration)
    {
        _duration = duration;
    }

    public int getduration()
    {
        return _duration;
    }

    public Activity (string ActivityName, string ActivityDetails) 
    {       

        _name = ActivityName;
        _description = ActivityDetails;

    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine ($"Welcome to the {_name}");
        Console.WriteLine();

        Console.WriteLine ($"{_description} ");        
        Console.WriteLine();    

        Console.Write ("How long , in seconds, would you like for your session? ");  
          
    }

    
  

       public void DisplayEndingMessage()
    {
        Console.WriteLine ("Well Done");
        Console.WriteLine();
        Console.WriteLine ($"You just completed another {_name}.");

    
    }

    public void ShowSpinner() //i do not wish to have peremeter here
    {
    
        List<string> animationSpiner = new List<string>();
        animationSpiner.Add("/");
        animationSpiner.Add("-");
        animationSpiner.Add("\\");
        animationSpiner.Add("|");
        animationSpiner.Add("/");
       
      
        foreach(string i in animationSpiner)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); //this  will act like using a back arrow to write and deletes somethin thereby creating good animation

        }

        
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
            
    }





}