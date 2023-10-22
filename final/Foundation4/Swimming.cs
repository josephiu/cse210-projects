public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50.0) / (1000.0 * 60.0); // gets the Distance in miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / (GetLength() / 60.0)); // gets the Speed in mph
    }

    public override double GetPace()
    {
        return (GetLength() / GetDistance()) * 60.0; 
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min) - Distance {Math.Round(GetDistance(), 4)} km, Speed {Math.Round(GetSpeed(), 4)} kph, Pace: {GetPace()} seconds per km";
    }
}