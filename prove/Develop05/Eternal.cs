class Eternal : Goal{
    public override int RecordEvent()
    {
        return points;
    }

    public override string Export()
    {
        return $"Eternal{base.Export()}";
    }

    public Eternal(string title, string description, int points) : base(title, description, points){}
    public Eternal(string loadString):base(loadString){}
}