public class Lecture : Event
{
    public string Speaker { get; }
    public int Capacity { get; }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GenerateFullMessage()
    {
        return $"{base.GenerateFullMessage()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
