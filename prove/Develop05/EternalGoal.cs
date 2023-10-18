public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base ( name, description, points)
    {

    }


    public override void RecordEvent()
     {
        
     }

    public override void SetComplete(bool value)
    {
        
    }
    public override bool IsComplete()
     {
        return false;
     }

     public override string GetStringRepresentation()
     {
        return  $"EternalGoal,{GetName()},{GetDescription()},{Getpoints()},{IsComplete()}";
     }

    
}