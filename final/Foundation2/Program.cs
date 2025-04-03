using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Console.WriteLine("============================");

        // first customer and their address
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Taylor", address1);
        
        // first order
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("MacBookAir", "TECH001", 1299.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "TECH023", 25.99, 2));
        
        // Display order 1 details
        Console.WriteLine("\nORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost():F2}");
        
        // second customer and their address
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Rena Domon", address2);
        
        // second order
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Coffee Maker", "HOME056", 89.99, 1));
        order2.AddProduct(new Product("Coffee Beans (1kg)", "FOOD098", 15.50, 3));
        order2.AddProduct(new Product("Mug Set", "HOME057", 24.99, 1));
        
        // Display order 2 details
        Console.WriteLine("\nORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost():F2}");
    }
}