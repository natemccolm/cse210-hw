public abstract class Activity
{
    private string _date; 
    private int _duration;

    protected Activity(string date, int duration) 
    {
        _date = date;
        _duration = duration;
    }

    public string Date => _date;
    public int Duration => _duration;

    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min): Distance {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
