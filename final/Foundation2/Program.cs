//Write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Address address1 = new Address("525 S Center St", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Jerry Steimer", address1);
        Product product1 = new Product("Dog Chew Toy", "8394", 7, 3);
        Product product2 = new Product("Grill Scraper", "1230", 30, 1);


        //Order 2
        Address address2 = new Address("80 Grayson Street", "Wentworth", "New South Wales", "Austrailia");
        Customer customer2 = new Customer("Nancy Drew", address2);
        Product product3 = new Product("How to code in C#", "929", 10, 1);
        Product product4 = new Product("Girl Scout Cookies", "0023", 5, 4);

        // Create orders with products and customers
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

        // Display packing label, shipping label, and total cost for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.TotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.TotalCost());
    }
}
