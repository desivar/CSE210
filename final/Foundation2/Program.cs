using System;

class Program
{
    
        static void Main()
    {
        var addressUSA = new Address
        {
            Street = "123 Main St",
            City = "Cityville",
            State = "CA",
            Country = "USA"
        };

        var customer = new Customer
        {
            Name = "John Doe",
            CustomerAddress = addressUSA
        };

        var products = new List<Product>
        {
            new Product { Name = "Widget A", ProductId = "W123", Price = 10, Quantity = 3 },
            new Product { Name = "Widget B", ProductId = "W456", Price = 15, Quantity = 2 }
        };

        var order = new Order { Customer = customer, Products = products };

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel);

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.ShippingLabel);

        Console.WriteLine($"\nTotal Price (including shipping): ${order.TotalCost}");
    }


}



