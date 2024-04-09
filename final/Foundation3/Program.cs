using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Sparkling Avenue", "Festivity City", "Partyland", "Joyful Nation");

        Lecture lecture = new Lecture("Inspirational Talk", "Join us for a motivational speech!", "2024-05-10", "10:00 AM", address, "Samantha Shine", 100);
        Reception reception = new Reception("Grand Gala", "Celebrate in style with live music and gourmet food!", "2024-06-15", "7:00 PM", address, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Sunset Soiree", "Enjoy an evening under the stars with friends and laughter.", "2024-07-20", "6:00 PM", address, "Clear skies and a gentle breeze");

        Console.WriteLine("Standard Message:");
        Console.WriteLine(lecture.GenerateStandardMessage());
        Console.WriteLine();

        Console.WriteLine("Full Message:");
        Console.WriteLine(reception.GenerateFullMessage());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}
