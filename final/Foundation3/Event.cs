using System;

public class Event
{
    public string Title { get; }
    public string Description { get; }
    public string Date { get; }
    public string Time { get; }
    public Address Address { get; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GenerateStandardMessage()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
    }

    public virtual string GenerateFullMessage()
    {
        return GenerateStandardMessage();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: {GetType().Name}\nEvent: {Title}\nDate: {Date}";
    }
}
