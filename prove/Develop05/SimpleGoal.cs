public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false; // I did not add this variable to the parameter because i dont have before it works
    }


    public override void RecordEvent()
    {
        _isComplete = true;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetComplete(bool value)

    {
        _isComplete = value;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{Getpoints()},{IsComplete()}";
    }



}