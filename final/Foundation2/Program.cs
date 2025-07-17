using System;
using Foundation2;

class Program

{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL","USA" ,"62701");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "12345", 999.99m,2));
        order1.AddProduct(new Product("Smartphone", "67890", 499.99m,3));

        Address address2 = new Address("456 Owen St", "Madison", "WI", "USA","53703");
        Customer customer2 = new Customer("Pablo Sanchez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Noise Cancelling Headphones", "H789", 129.99m,1));
        order2.AddProduct(new Product("USB-C Charger", "C456", 19.99m,2));

        
        List<Order> orders = new List<Order> { order1, order2 };
        List<Customer> customer = new List<Customer> { customer1, customer2 };
       
        Console.WriteLine("");
        Console.WriteLine("Orders Summary:");
        Console.WriteLine("=====================================");
        Console.WriteLine("");
        foreach (var order in orders)
        {
            Console.WriteLine($"Customer: {order.Customer.GetName()}");
            Console.WriteLine("_____________________________________");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}\n");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
        }
    }
}