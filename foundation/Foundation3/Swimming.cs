public class Swimming : Activity
{
    private int _laps; 

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.025; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / Duration * 60; 
    }

    public override double GetPace()
    {
        return Duration / _laps; 
    }
}
