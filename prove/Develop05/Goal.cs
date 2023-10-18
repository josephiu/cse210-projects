
using System.Xml.Resolvers;

public abstract class Goal
   {
    
    private string _shortName;
    private string _points ;
    private string _description;

    //contructors with perimeter
    public Goal (string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

// this setter is created so that the bonus in the checklist class can be added as a string
    public void SetPoints(string point)
    {
       _points = point;
    }
   
    
    

    public string Getpoints()
    {
        return _points;
        
    }

    public string GetDescription()
    {
        return _description;
    }

    

    public abstract void RecordEvent();


    public abstract void SetComplete(bool value);
    
    
     public abstract bool IsComplete();

     public virtual string GetDetailsString()
     {
        string status = "[ ]";
        if (IsComplete() == true)
        {
            status = "[X]";
        }
        
        return $"{status} {GetName()} ({GetDescription()})";
     }

    public abstract string GetStringRepresentation();
    


   }