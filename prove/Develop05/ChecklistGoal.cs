public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;


    public CheckListGoal(string name, string description, string points, int bonus, int target) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }


 
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {

        _amountCompleted += 1;
        if (IsComplete() == true)
        {   // if the goal is completed, then this code the bonus will be added to the points
            int bonus = int.Parse(Getpoints()) + _bonus;
            SetPoints(bonus.ToString());
        }
    }
    public override void SetComplete(bool value)
    {
        _amountCompleted = 0;        
    }
public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else {return false;}
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal,{GetName()},{GetDescription()},{Getpoints()},{GetAmountCompleted()},{GetTarget()},{GetBonus()},{IsComplete()}";
    }
    public override string GetDetailsString()
    {
        string status = "[ ]";
        if (IsComplete() == true)
        {
            status = "[X]";
        }
        
        return $"{status} {GetName()} ({GetDescription()} -- Currently completed: {GetAmountCompleted()}/{GetTarget()})";
    }    




}