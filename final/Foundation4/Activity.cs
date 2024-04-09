using System;

public class Activity
{
    protected DateTime date;
    protected int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class doesn't have distance calculation
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class doesn't have speed calculation
    }

    public virtual double GetPace()
    {
        return 0; // Base class doesn't have pace calculation
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - {GetType().Name} ({durationInMinutes} min)";
    }
}
