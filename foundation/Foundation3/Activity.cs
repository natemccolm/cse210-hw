public abstract class Activity
{
    private string date; 
    private int duration;

    public Activity(string date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public string Date => date;
    public int Duration => duration;

    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    
    public string GetSummary()
    {
        return $"{date} {this.GetType().Name} ({duration} min): Distance {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
