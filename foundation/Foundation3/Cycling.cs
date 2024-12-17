using System;

class Cycling : Activity
{
    public double Speed { get; set; } 

    public Cycling(DateTime date, double durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * DurationInMinutes) / 60;  
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}
