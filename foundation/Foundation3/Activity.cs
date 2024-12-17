using System;

abstract class Activity
{
    public DateTime Date { get; }
    public double DurationInMinutes { get; }

    public Activity(DateTime date, double durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        var distance = GetDistance();
        var pace = GetPace();
        var speed = GetSpeed();
        string unit = distance > 1 ? "mile" : "km";
        return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min)- " +
               $"Distance {distance:0.0}, Speed {speed:0.0}, Pace: {pace:0.0} min per {unit}";
    }
}
