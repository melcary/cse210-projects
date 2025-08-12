using System;
using System.Data.Common;
using System.Globalization;
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetType().Name} ({GetMinutes()} min) - " + $"Distance: {GetDistance():0.0} miles, " + $"Speed: {GetSpeed():0.00} mph, " + $"Pace: {GetPace():0.00} min per mile";
    }
}