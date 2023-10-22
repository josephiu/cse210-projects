public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * (GetLength() / 60.0));
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return (60.0 / GetSpeed()) * 60.0;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min) - Distance {GetDistance()} miles, Speed {Math.Round(GetSpeed(), 4)} mph, Pace: {GetPace()} seconds per mile";
    }
}