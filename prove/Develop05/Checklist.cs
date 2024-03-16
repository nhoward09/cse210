class Checklist : Goal
{
    private int count;
    private int pointsEach;
    private int timesRepeated;

    public override string Display()
    {
        return $"{base.Display()} -- Currently Completed: {timesRepeated}/{count}";
    }

    public override int RecordEvent()
    {
        if (timesRepeated < count - 1)
        {
            timesRepeated++;
            return pointsEach;
        }
        else if (timesRepeated == count - 1)
        {
            return pointsEach + base.RecordEvent();
        }
        else return 0;
    }

    public override string Export()
    {
        return $"Checklist{base.Export()}~~{count}||{pointsEach}||{timesRepeated}";
    }

    public Checklist(string title, string description, int points, int count, int bonus) : base(title, description, bonus)
    {
        this.count = count;
        this.pointsEach = points;
        this.timesRepeated = 0;
    }
    public Checklist(string loadString) : base(loadString.Split("~~")[0])
    {
        string[] parts = loadString.Split("~~")[1].Split("||");
        this.count = int.Parse(parts[0]);
        this.pointsEach = int.Parse(parts[1]);
        this.timesRepeated = int.Parse(parts[2]);
    }
}