public class OutdoorGathering : Event
{
    public string Weather { get; }

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) 
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string GenerateFullMessage()
    {
        return $"{base.GenerateFullMessage()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }
}
