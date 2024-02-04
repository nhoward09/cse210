using System.Buffers;

class Car
{
    //when making varibales in classes, specify public so i can use it outside the class
    public string model;
    public string make;
    public int year;
    public int milesPerGallon;
    public int gallons;

    public Person owner;

    public int TotalRange()
    {
        return gallons * milesPerGallon;
    }

    public Car(string make, string model, int milesPerGallon, int gallons){
        this.model = model;
        this.make = make;
        this.milesPerGallon = milesPerGallon;
        this.gallons = gallons;
    }
    public void Display()
    {
        System.Console.WriteLine(($"{make} {model} {year} {owner.DisplayString()}: totalRange = {TotalRange()}"));
    }
}

