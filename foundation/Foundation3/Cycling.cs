public class Cycling : Activity
{
    private double _speed; 

    public double Speed 
    { 
        get => _speed; 
        set => _speed = value; 
    }

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed; 
    }

    public override double GetDistance()
    {
        return _speed * Duration / 60; 
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }
}
