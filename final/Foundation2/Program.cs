using System;
using System.Collections.Generic;

class Program
{
    static Random rand = new Random();

    static string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Emma", "James", "Olivia" };
    static string[] lastNames = { "Doe", "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Martinez" };
    static string[] streets = { "123 Main St", "456 Elm St", "789 Oak St", "321 Pine St", "654 Maple St" };
    static string[] cities = { "Anytown", "Othertown", "Smallville", "Sunnydale", "Springfield" };
    static string[] states = { "CA", "NY", "TX", "FL", "IL" };
    static string[] countries = { "USA", "Canada", "UK", "Australia", "Germany" };
    static string[] productNames = { "Widget", "Gadget", "Thingamajig", "Doodad", "Contraption" };

    static string GetRandomName()
    {
        string firstName = firstNames[rand.Next(firstNames.Length)];
        string lastName = lastNames[rand.Next(lastNames.Length)];
        return $"{firstName} {lastName}";
    }

    static Address GetRandomAddress()
    {
        string street = streets[rand.Next(streets.Length)];
        string city = cities[rand.Next(cities.Length)];
        string state = states[rand.Next(states.Length)];
        string country = countries[rand.Next(countries.Length)];
        return new Address(street, city, state, country);
    }

    static string GetRandomProductName()
    {
        return productNames[rand.Next(productNames.Length)];
    }

    static void Main(string[] args)
    {
        // Create orders with random data
        List<Order> orders = new List<Order>();

        for (int i = 0; i < 2; i++)
        {
            Customer customer = new Customer(GetRandomName(), GetRandomAddress());
            Order order = new Order(customer);

            for (int j = 0; j < rand.Next(2, 4); j++)
            {
                string productName = GetRandomProductName();
                string productId = $"P{i}{j}";
                decimal pricePerUnit = Math.Round((decimal)(rand.NextDouble() * (50 - 5) + 5), 2);
                int quantity = rand.Next(1, 6);

                Product product = new Product(productName, productId, pricePerUnit, quantity);
                order.AddProduct(product);
            }

            orders.Add(order);
        }

        // Display order details
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("\nShipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("\nTotal Price:");
            Console.WriteLine("$" + order.TotalCost());
            Console.WriteLine();
        }
    }
}
