using System;

public class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed:F1} kph, Pace: {GetPace():F2} min per km";
    }
}
