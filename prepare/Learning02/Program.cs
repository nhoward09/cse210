using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        var cars = new List<Car>();

        Car car = new Car();
        //new key words are only used when making a variable from a class (Car is the class, and ford is the variable name, but because i am specifying Car, i need to use "new")
        car.make = "Honda";
        car.model = "Civic";
        car.year = 2022;
        car.gallons = 10;
        car.milesPerGallon = 30;

        var owner = new Person();
        owner.name = "Bob";
        owner.phone = "123-456-7890";
        car.owner = owner;


        cars.Add(car);

        // car = new Car();
        car.make = "Ford";
        car.model = "Mustang";
        car.year = 2015;
        car.gallons = 15;
        car.milesPerGallon = 26;

        owner = new Person();
        owner.name = "Nick";
        owner.phone = "803-847-3088";
        car.owner = owner;

        cars.Add(car);


        Console.Clear();
        foreach (var c in cars)
        {
            // System.Console.WriteLine(($"{c.make} {c.model}: totalRange = {c.TotalRange()}"));
            c.Display();
        }
    }
}

