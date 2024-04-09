using System;
using System.Collections.Generic;

public class Order
{
    public Customer Customer { get; }
    private List<Product> Products { get; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal totalProductCost = 0;
        foreach (var product in Products)
        {
            totalProductCost += product.TotalCost();
        }
        decimal shippingCost = Customer.IsUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
            label += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Customer Name: {Customer.Name}\nAddress:\n{Customer.Address.GetFullAddress()}";
    }
}
