using System;

class Program
{
     static void Main(string[] args)
    {
        // Create customers
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("45 Oxford St", "London", "England", "UK");
        Customer customer2 = new Customer("Alice Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P003", 150, 1));
        order2.AddProduct(new Product("Keyboard", "P004", 100, 1));
        order2.AddProduct(new Product("Monitor", "P005", 300, 2));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");
    }
}