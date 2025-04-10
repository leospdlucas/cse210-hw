using System;

class Program {
    static void Main(string[] args) {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mouse", "P001", 25.99, 2));
        order1.AddProduct(new Product("Keyboard", "P002", 49.99, 1));

        // Order 2 (International)
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Carlos Mendes", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P003", 150.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "P004", 12.50, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}