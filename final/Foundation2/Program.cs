using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Boise", "ID", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Fishing Rod", "FR123", 50, 2));
        order1.AddProduct(new Product("Fishing Reel", "FR456", 30, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Fishing Net", "FN789", 20, 3));
        order2.AddProduct(new Product("Fishing Bait", "FB101", 10, 5));

        // Display order details
        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
